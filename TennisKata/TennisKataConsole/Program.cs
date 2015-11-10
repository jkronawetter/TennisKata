using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisKata;

namespace TennisKataConsole
{
    class Program
    {
        private IGame game;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        public void Start()
        {
            game = new Game();
            bool running = true;
            string input;
            int choice;
            ShowResult();
            ShowOptions();
            while (running)
            {
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out choice) || (choice != 1 && choice != 2))
                {
                    Console.WriteLine("Invalid input, try again.");
                    continue;
                }
                if (game.GameOver())
                {
                    if (choice == 1)
                    {
                        game.Reset();
                        ShowResult();
                        ShowOptions();
                    }
                    else
                    {
                        running = false;
                    }
                }
                else
                {
                    game.AwardPoint(choice);
                    ShowResult();
                    ShowOptions();
                }
            }
        }

        public void ShowResult()
        {
            if (game.GameOver())
            {
                Console.WriteLine("{0} wins!", game.GetWinner());
            }
            else
            {
                Console.WriteLine("The score is now {0}", game.GetScore());
            }
            Console.WriteLine();
        }

        public void ShowOptions()
        {
            if (game.GameOver())
            {
                Console.WriteLine("1. Restart\n2. Quit");
            }
            else
            {
                Console.WriteLine("Who wins this point?\n1. Team 1\n2. Team 2");
            }
            Console.WriteLine();
        }
    }
}
