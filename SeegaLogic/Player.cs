using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeegaLogic
{
    public enum PieceColor
    {
        None,
        Black,
        Red
    }

    public class Player(string name, PieceColor color)
    {
        private string _name = name;
        private PieceColor _color = color;

        public string Name { get => _name; set => _name = value; }
        public PieceColor Color { get => _color; set => _color = value; }
    }
}
