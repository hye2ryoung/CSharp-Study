using System;

namespace Section05_TextRPG2
{
    // TextRPG2

    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.Process();
            }
        }
    }
}
