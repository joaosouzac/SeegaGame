using System;
using SeegaLogic;
using SeegaLogic.Network;
using Sockets;

namespace SeegaUI.GameWindow
{
    public partial class ServerGameWindow : Form
    {
        private Server server;

        private Game game;
        private Button[,] buttons = new Button[5, 5];

        private ServerHandler handler;

        public ServerGameWindow(Server server)
        {
            InitializeComponent();

            this.server = server;

            this.game = new Game();

            this.handler = new ServerHandler(this.game, this.server);

            this.server.MessageReceived += handler.HandleMessage;
            this.handler.ChatReceived += (msg) => AddMessage("Opponent: " + msg, Color.LightBlue);
            this.handler.BoardUpdated += () => UpdateBoard();

            CreateBoard();
        }

        private void ServerGameWindow_Load(object sender, EventArgs e)
        {
            this.server.Start();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = this.ChatTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                this.handler.SendChat(message);
                AddSentMessage("You: " + message);
                this.ChatTextbox.Clear();
            }
        }

        private void AddSentMessage(string text)
        {
            AddMessage(text, Color.LightGray);
        }

        private void AddReceivedMessage(string text)
        {
            if (text.StartsWith("CHAT:"))
            {
                string chatText = text.Substring(5); // remove prefixo

                AddMessage("Opponent: " + chatText, Color.LightBlue);
            }
            else if (text.StartsWith("MOVE:"))
            {
                string[] parts = text.Substring(5).Split(',');

                int row = int.Parse(parts[0]);
                int col = int.Parse(parts[1]);

                if (this.game.Phase == GamePhase.Placement)
                {
                    this.game.PlacePiece(row, col);
                }
                else
                {
                    if (!this.game.SelectPiece(row, col))
                        this.game.MoveSelectedPiece(row, col);
                }

                this.UpdateBoard();
            }
        }

        private void AddMessage(string text, Color backgroundColor)
        {
            if (this.ChatPanel.InvokeRequired)
            {
                this.ChatPanel.Invoke(new Action(() => AddMessage(text, backgroundColor)));
            }
            else
            {
                Label lbl = new Label();

                lbl.Text = text;
                lbl.AutoSize = true;
                lbl.MaximumSize = new Size(this.ChatPanel.Width - 20, 0);
                lbl.BackColor = backgroundColor;
                lbl.Padding = new Padding(5);

                this.ChatPanel.Controls.Add(lbl);
            }
        }

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

        private void BoardButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var (row, col) = ((int, int))btn.Tag;

            if (this.game.Phase == GamePhase.Placement)
            {
                this.game.PlacePiece(row, col);
            }
            else
            {
                if (!this.game.SelectPiece(row, col))
                    this.game.MoveSelectedPiece(row, col);
            }

            this.handler.SendMove(row, col);
            this.UpdateBoard();
        }

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
                }
            }

            this.GameStatusLabel.Text = $"Servidor - Turno: Jogador {this.game.Turn} - Fase: {this.game.Phase}";
        }
    }
}
