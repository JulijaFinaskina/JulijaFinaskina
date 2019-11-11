using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Game_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.StartNewGame();
                game.Loop();

                if (!ConsoleInput.GetBool("Play again? y/n"))
                {
                    Environment.Exit(0); //iziet no loga
                    break;
                }
                Console.ReadLine();
            }

        }
    }
}
