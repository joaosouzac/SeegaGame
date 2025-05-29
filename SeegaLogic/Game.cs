using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeegaLogic
{
    // Refers to the state of a board cell - whether it's controlled by the Host (P1), the Client (P2) or is Empty.
    public enum Cellstate
    {
        Empty,
        Player1,
        Player2
    }

    // Refers to the action the players will be doing - whether it's the Placement or the Movement of the pieces.
    public enum GamePhase
    {
        Placement,
        Movement
    }

    // Contains all the game's logic - control of turns, player's actions, board management.
    public class Game
    {
        public Player player;

        // Create a logical 5x5 board where every cell is occupied by P1, P2 or is Empty.
        public Cellstate[,] Board { get; set; } = new Cellstate[5, 5];

        // Starts the Game in the Placement phase.
        public GamePhase Phase { get; set; } = GamePhase.Placement;

        // Indicates which player's turn is it. For default, the Host starts.
        // Options: 1 = Host or 2 = Client
        public int Turn { get; set; } = 1;

        // Tracks how many pieces each player has placed
        private int p1Placed = 0;
        private int p2Placed = 0;

        // Total number of pieces each player is allowed to place
        private int maxPieces = 12;

        // Holds the coordinates of the piece currently selected for movement (during Movement phase)
        private (int row, int column)? selectedPiece = null;

        // Indicates if the game has finished
        // It can be caused by either victory or forfeit
        public bool isFinished = false;

        public Game(Player player)
        {
            this.player = player;
        }

        // Places a piece on the board during the Placement Phase
        public bool PlacePiece(int row, int column)
        {
            // Can't place on non-empty cells or the center cell (2,2)
            if (Board[row, column] != Cellstate.Empty || (row == 2 && column == 2))
                return false;

            // Checks if P1 can place pieces
            if (Turn == 1 && p1Placed < maxPieces)
            {
                
                    Board[row, column] = Cellstate.Player1;
                    p1Placed++;
                    Turn = 2;

                
            }
            // Checks if P2 can place pieces
            else if (Turn == 2 && p2Placed < maxPieces)
            {
                
                    Board[row, column] = Cellstate.Player2;
                    p2Placed++;
                    Turn = 1;

                
            }

            // If both players have placed all their pieces, switch to Movement phase
            if (p1Placed == maxPieces && p2Placed == maxPieces)
                this.Phase = GamePhase.Movement;

            return true;
        }

        // Selects a piece during the Movement phase
        public bool SelectPiece(int row, int column)
        {
            // Checks if the current phase is of Movement
            if (Phase != GamePhase.Movement)
            {
                return false;
            }

            // Check if the selected piece belongs to the current player
            if (Turn == 1 && Board[row, column] == Cellstate.Player1)
            {
                selectedPiece = (row, column);

                return true;
            }
            else if (Turn == 2 && Board[row, column] == Cellstate.Player2)
            {
                selectedPiece = (row, column);

                return true;
            }

            // Selection not valid
            return false;
        }

        // Moves the previously selected piece to a new position
        public bool MoveSelectedPiece(int newRow, int newColumn)
        {
            if (selectedPiece == null) return false;

            var (row, column) = selectedPiece.Value;

            // Allow only orthogonal movement by 1 cell (no diagonals, no jumping)
            if (Math.Abs(newRow - row) + Math.Abs(newColumn - column) != 1)
                return false;

            // Target cell must be empty
            if (Board[newRow, newColumn] != Cellstate.Empty)
                return false;

            // Move the piece
            Board[newRow, newColumn] = Board[row, column];
            Board[row, column] = Cellstate.Empty;

            // Checks if there is a capture
            CheckCapture(newRow, newColumn);

            // Checks if there is a victory
            if (CheckVictory())
            {
                return true;
            }

            // End turn and clear selected piece
            Turn = (Turn == 1) ? 2 : 1;
            selectedPiece = null;

            return false;
        }

        // Checks for and performs captures in the four cardinal directions
        private void CheckCapture(int row, int column)
        {
            var self = Board[row, column];
            var enemy = (self == Cellstate.Player1) ? Cellstate.Player2 : Cellstate.Player1;

            // Directions: Up, Down, Left, Right
            var dirs = new (int dr, int dc)[]
            {
            (-1,0), (1,0), (0,-1), (0,1)
            };

            foreach (var (dr, dc) in dirs)
            {
                int nr = row + dr;
                int fr = row + dr * 2;
                int nc = column + dc;
                int fc = column + dc * 2;

                // Ensure all coordinates are within the board bounds
                if (nr >= 0 && nr < 5 && nc >= 0 && nc < 5 &&
                    fr >= 0 && fr < 5 && fc >= 0 && fc < 5)
                {
                    // Checks if an enemy piece is sandwiched between two of the current player's pieces
                    if (Board[nr, nc] == enemy && Board[fr, fc] == self)
                    {
                        Board[nr, nc] = Cellstate.Empty; // Piece is captured

                    }
                }
            }
        }

        // Counts and return the current number of selected player's pieces on the board 
        // The player is selected through owner
        private int CountPieces(Cellstate owner)
        {
            int numberOfPlayerPieces = 0;

            foreach (var piece in Board)
            {
                if (piece == owner)
                {
                    numberOfPlayerPieces++;
                }
            }

            return numberOfPlayerPieces;
        }

        // Checks for current player's victory
        public bool CheckVictory()
        {
            // Defines who is the current player's opponent
            Cellstate enemy = (this.player.ID == 1) ? Cellstate.Player2 : Cellstate.Player1;

            // If the opponent holds no more pieces, the current player wins
            if (CountPieces(enemy) == 0)
            {
                this.isFinished = true;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
