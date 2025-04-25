using SeegaLogic;

namespace SeegaUI.Args
{
    internal class PlayerEventArgs : EventArgs
    {
        public Player Player { get; set; }

        public PlayerEventArgs(Player player)
        {
            Player = player;
        }
    }
}
