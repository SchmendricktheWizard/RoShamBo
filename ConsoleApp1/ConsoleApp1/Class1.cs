using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RoShamBo
    {
        public int wins;
        public int losses;
        private Random Random = new Random();

        public void play()
        {
            String playerChoice;
            String computerChoice;
            Console.WriteLine("To play, select either Rock (R), Paper (P), or Scissors (S)");
            Console.WriteLine("Best of 3 wins, good luck!\n\n");
            Console.Write("Choose your weapon: ");
            playerChoice = Console.ReadLine();
            
        }

        private int game(String playerChoice, String computerChoice)
        {
            //Input player and computer choice in the form of a single character string
            //Outputs 0 for a tie, 1 for a computer win, and 2 for a player win, 3 for error
            //Rocks

            if(playerChoice == computerChoice)
            {
                return 0;
            }

            if(playerChoice == "R")
            {
                if(computerChoice == "P")
                {
                    return 1;
                }
                else { return 2; }
            }
            if (playerChoice == "P")
            {
                if (computerChoice == "S")
                {
                    return 1;
                }
                else { return 2; }
            }
            if (playerChoice == "S")
            {
                if (computerChoice == "R")
                {
                    return 1;
                }
                else { return 2; }
            }

            return 3;
        }

        public RoShamBo() { }

    }
}
