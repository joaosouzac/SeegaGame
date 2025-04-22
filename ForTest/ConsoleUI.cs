using SeegaLogic;

namespace ForTest
{
    internal class ConsoleUI
    {
        static public Player Register()
        {
            string name;
            PieceColor color;

            Console.WriteLine("What is your name?");
            Console.Write(">> ");

            name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What is your color?");
            Console.Write(">> ");

            if (Console.ReadLine() == "Black")
            {
                color = PieceColor.Black;
            }
            else
            {
                color = PieceColor.Red;
            }

            Console.WriteLine();

            return new Player(name, color);
        }
    }
}
