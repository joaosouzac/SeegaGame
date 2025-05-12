using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeegaUI;
using SeegaLogic;
using Sockets;

namespace SeegaUI
{
    // Main window of the application. Controls the overall window flow and transitions
    public partial class MainWindow : Form
    {
        // Initializes the form and sets up a handler for when the form loads
        public MainWindow()
        {
            InitializeComponent();

            // Attach method to handle the Load event (when the form first appears)
            this.Load += MainWindow_Load;
        }

        // Called once when the MainWindow is loaded
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Display the Start Window
            ShowStartWindow();

        }

        // Displays the initial StartWindow where the user chooses to host or join a game
        private void ShowStartWindow()
        {
            StartWindow startWindow = new StartWindow();

            // Event for when the user chooses to host a game
            // The player will be treated as the server
            startWindow.OpenHostWindow += (s, args) =>
            {
                // Hide the start window
                startWindow.Hide();

                // Show the host configuration window
                ShowHostConfigWindow();

            };

            // Event for when the user chooses to host a game
            // The player will be treated as the server
            startWindow.OpenClientWindow += (s, args) =>
            {
                // Hide the start window
                startWindow.Hide();

                // Show the client configuration window
                ShowClientConfigWindow();

            };

            // If the StartWindow is closed manually, close the entire application
            startWindow.FormClosed += (s, args) => this.Close();

            // Display the StartWindow
            startWindow.Show();
        }

        // Opens the window to configure host options (e.g. server IP, player name)
        private void ShowHostConfigWindow()
        {
            ConfigWindow hostConfigWindow = new ConfigWindow(true); // true - starts in host mode

            // Event: user finished configuring and clicked "Host"
            hostConfigWindow.HostGame += (s, args) =>
            {
                // Hide configuration window
                hostConfigWindow.Hide();

                // Proceed to server-side game window, passing the server object and player info
                ShowServerGameWindow(args.Host, args.Player);

            };

            // If closed manually, close the whole app
            hostConfigWindow.FormClosed += (s, args) => this.Close();

            // Display the host configuration window
            hostConfigWindow.Show();
        }

        // Opens the window to configure client options (e.g. IP to connect, player name)
        private void ShowClientConfigWindow()
        {
            ConfigWindow clientConfigWindow = new ConfigWindow(false); // false - starts in client mode

            // Event: user finished configuring and clicked "Join"
            clientConfigWindow.JoinGame += (s, args) =>
            {
                // Hide configuration window
                clientConfigWindow.Hide();

                // Proceed to client-side game window, passing the client object and player info
                ShowClientGameWindow(args.Client, args.Player);
            };

            // If closed manually, close the whole app
            clientConfigWindow.FormClosed += (s, args) => this.Close();

            // Display the client configuration window
            clientConfigWindow.Show();
        }

        // Opens the actual game window for the host
        private void ShowServerGameWindow(Server host, Player player)
        {
            // Creates a GameWindow with the host and player data
            GameWindow serverGameWindow = new GameWindow(host, player);

            // If closed manually, close the whole app
            serverGameWindow.FormClosed += (s, args) => this.Close();

            // Display the server's game window
            serverGameWindow.Show();
        }

        // Opens the actual game window for the client
        private void ShowClientGameWindow(Client client, Player player)
        {
            // Creates a GameWindow with the client and player data
            GameWindow clientGameWindow = new GameWindow(client, player);

            // If closed manually, close the whole app
            clientGameWindow.FormClosed += (s, args) => this.Close();

            // Display the client's game window
            clientGameWindow.Show();
        }
    }
}
