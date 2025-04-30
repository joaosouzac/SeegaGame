using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeegaLogic
{
    public enum Cellstate
    {
        Empty,
        Player1,
        Player2
    }

    public enum GamePhase
    {
        Placement,
        Movement
    }

    public class Game
    {
        public Cellstate[,] Board { get; set; }
        public GamePhase Phase { get; set; }
        public int Turn { get; set; } // 1 or 2
        private int p1Placed = 0;
        private int p2Placed = 0;
        private int maxPieces = 12;
        private (int row, int column)? selectedPiece = null;

        public Game()
        {
            Board = new Cellstate[5, 5];
            Phase = GamePhase.Placement;
            Turn = 1;
        }

        public bool PlacePiece(int row, int column)
        {
            if (Board[row, column] != Cellstate.Empty || (row == 2 && column == 2))
                return false;

            if (Turn == 1 && p1Placed < maxPieces)
            {
                Board[row, column] = Cellstate.Player1;
                p1Placed++;
                Turn = 2;
            }
            else if (Turn == 2 && p2Placed < maxPieces)
            {
                Board[row, column] = Cellstate.Player2;
                p2Placed++;
                Turn = 1;
            }

            if (p1Placed == maxPieces && p2Placed == maxPieces)
                Phase = GamePhase.Movement;

            return true;
        }

        public bool SelectPiece(int row, int column)
        {
            if (Phase != GamePhase.Movement) return false;

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

            return false;
        }

        public bool MoveSelectedPiece(int newRow, int newColumn)
        {
            if (selectedPiece == null) return false;

            var (row, column) = selectedPiece.Value;

            // Só permite movimento ortogonal de 1 casa
            if (Math.Abs(newRow - row) + Math.Abs(newColumn - column) != 1)
                return false;

            if (Board[newRow, newColumn] != Cellstate.Empty)
                return false;

            // Move
            Board[newRow, newColumn] = Board[row, column];
            Board[row, column] = Cellstate.Empty;

            // Captura
            CheckCapture(newRow, newColumn);

            // Turno
            Turn = (Turn == 1) ? 2 : 1;
            selectedPiece = null;

            return true;
        }

        private void CheckCapture(int row, int column)
        {
            var self = Board[row, column];
            var enemy = (self == Cellstate.Player1) ? Cellstate.Player2 : Cellstate.Player1;

            // Direções: cima, baixo, esquerda, direita
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

                if (nr >= 0 && nr < 5 && nc >= 0 && nc < 5 &&
                    fr >= 0 && fr < 5 && fc >= 0 && fc < 5)
                {
                    if (Board[nr, nc] == enemy && Board[fr, fc] == self)
                    {
                        Board[nr, nc] = Cellstate.Empty; // captura
                    }
                }
            }
        }
    }
}
