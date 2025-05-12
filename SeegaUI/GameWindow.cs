using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeegaLogic.Network;
using SeegaLogic;
using Sockets;

namespace SeegaUI
{
    // The main game window for both Host (Server) and Client players
    // Handles board rendering, game interaction, chat, surrendering, and win/loss
    public partial class GameWindow : Form
    {
        private Server? server;     // Reference to the Server object if host
        private Client? client;     // Reference to the Client object if client

        // Handles communication and message logic
        private MessageHandler handler;

        // Game logic (turns, board, phase, etc.)
        private Game game;

        // Holds the button grid for the 5x5 board UI
        private Button[,] buttons = new Button[5, 5];

        // Constructor for the Host
        public GameWindow(Server server, Player player)
        {
            InitializeComponent();

            this.server = server;

            this.game = new Game(player);

            this.handler = new MessageHandler(this.game, this.server);

            // Change window's title
            this.Text = "Seega - Server";

            // Register message handlers
            this.server.MessageReceived += handler.HandleMessage;

            this.handler.ChatReceived += (sender, message) => AddMessage($"{sender}: {message}", Color.Blue);
            this.handler.BoardUpdated += () => UpdateBoard();

            this.handler.OpponentWon += (sender) => HandleDefeat(sender);
            this.handler.OpponentForfeit += (sender) => HandleForfeit(sender);

            // Creates the board in the UI
            this.CreateBoard();
        }

        // Constructor for the Client
        public GameWindow(Client client, Player player)
        {
            InitializeComponent();

            this.client = client;

            this.game = new Game(player);

            this.handler = new MessageHandler(this.game, this.client);

            // Change window's title
            this.Text = "Seega - Client";

            // Register message handlers
            this.client.MessageReceived += handler.HandleMessage;

            this.handler.ChatReceived += (sender, message) => AddMessage($"{sender}: {message}", Color.Brown);
            this.handler.BoardUpdated += () => UpdateBoard();

            this.handler.OpponentWon += (sender) => HandleDefeat(sender);
            this.handler.OpponentForfeit += (sender) => HandleForfeit(sender);

            // Creates the board in the UI
            this.CreateBoard();
        }

        // Called when the GameWindow loads
        private void ServerGameWindow_Load(object sender, EventArgs e)
        {
            if (this.handler.isServer)
            {
                // Start listening as server
                this.server.Start();
            }
            else if (!this.handler.isServer)
            {
                // Connect to a server as client
                this.client.Connect();
            }
        }

        // Sends a chat message if the text is not empty
        private void SendMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                this.handler.SendChat(this.game.player.Name, message);

                this.AddMessage($"You: {message}", Color.Black);

                this.ChatTextbox.Clear();
            }
        }

        // Handles win for the local player
        private void HandleVictory()
        {
            this.game.isFinished = true;

            this.AddMessage($"You won the game!", Color.Green);

            MessageBox.Show($"Congratulations!\n You won the game!", "You won!");

            this.UpdateBoard();
        }

        // Handles defeat by opponent
        private void HandleDefeat(string sender)
        {
            this.game.isFinished = true;

            this.AddMessage($"{sender} won the match!", Color.Red);

            this.UpdateBoard();

            //MessageBox.Show($"Too bad! You lost the match!", "You lost!");

            //this.Close();
        }

        // Handles forfeit from the opponent (you win)
        private void HandleForfeit(string sender)
        {
            this.game.isFinished= true;

            this.AddMessage($"{sender} forfeit the match!", Color.Red);

            HandleVictory();

            this.UpdateBoard();

            //MessageBox.Show($"Too bad! You lost the match!", "You lost!");

            //this.Close();
        }

        // Triggered when the Send button is clicked
        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = this.ChatTextbox.Text.Trim();

            this.SendMessage(message);
        }

        // Triggered when the user presses Enter in the chat textbox
        private void ChatTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            string message = this.ChatTextbox.Text.Trim();

            if (e.KeyCode == Keys.Enter)
            {
                this.SendMessage(message);
            }
        }

        // Handles the board click: selects or moves a piece, or places a piece
        private void BoardButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var (row, col) = ((int, int))btn.Tag;

            if (this.game.player.ID == this.game.Turn)
            {
                if (this.game.Phase == GamePhase.Placement)
                {
                    this.game.PlacePiece(row, col);
                }
                else
                {
                    if (!this.game.SelectPiece(row, col))
                        if (this.game.MoveSelectedPiece(row, col))
                        {
                            this.handler.SendVictory(this.PlayerLabel.Name);

                            HandleVictory();

                        }
                }

                this.handler.SendMove(row, col);
                this.UpdateBoard();

            }

        }

        // Handles the surrender button click — forfeit the match
        private void SurrenderLabel_Click(object sender, EventArgs e)
        {
            this.game.isFinished = true;

            this.handler.SendForfeit(this.game.player.Name);

            this.AddMessage($"You forfeit the match!", Color.Red);

            MessageBox.Show($"Too bad!\n You forfeit the match!", "You forfeit!");

            this.UpdateBoard();
        }

        // Adds a message to the chat panel with a specific color
        private void AddMessage(string text, Color textColor)
        {
            if (this.ChatPanel.InvokeRequired)
            {
                this.ChatPanel.Invoke(new Action(() => AddMessage(text, textColor)));
            }
            else
            {
                Label lbl = new Label();

                lbl.Text = text;
                lbl.AutoSize = true;
                lbl.MaximumSize = new Size(this.ChatPanel.Width - 20, 0);
                lbl.ForeColor = textColor;
                lbl.Padding = new Padding(5);

                this.ChatPanel.Controls.Add(lbl);
            }
        }

        // Builds the 5x5 board grid using Button controls and assigns click handlers
        private void CreateBoard()
        {
            GameBoardPanel.Controls.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();

                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(2);
                    btn.Tag = (i, j);
                    btn.Click += BoardButton_Click;

                    buttons[i, j] = btn;
                    this.GameBoardPanel.Controls.Add(btn, j, i); // col, row
                }
            }

            this.UpdateBoard();
        }

        // Updates the visual board to reflect the current game state
        private void UpdateBoard()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var cell = game.Board[i, j];
                    var btn = buttons[i, j];


                    switch (cell)
                    {
                        case Cellstate.Empty:
                            btn.Text = "";
                            btn.BackColor = Color.White;
                            break;
                        case Cellstate.Player1:
                            btn.Text = "P1";
                            btn.BackColor = Color.Red;
                            break;
                        case Cellstate.Player2:
                            btn.Text = "P2";
                            btn.BackColor = Color.Blue;
                            break;
                    }

                    // Disable movement and forfeit if the game is finished
                    if (this.game.isFinished)
                    {
                        btn.Enabled = false;
                        this.SurrenderLabel.Enabled = false;
                    }
                }
            }

            // Update turn indicator
            if (this.game.player.ID == this.game.Turn)
            {
                this.PlayerLabel.Text = "You Turn!";
            }
            else
            {
                this.PlayerLabel.Text = "Opponent's Turn";
            }

        }

    }
}
