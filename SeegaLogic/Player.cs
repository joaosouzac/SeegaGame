using System;
using System.Collections.Generic;
using System.Drawing;

namespace SeegaLogic
{
    // Contains the player's logic
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Currently not used
        public Color Color { get; set; }

        public Player(int ID, string name, Color color)
        {
            this.ID = ID;
            this.Name = name;
            this.Color = color;
        }

        

    }
}
