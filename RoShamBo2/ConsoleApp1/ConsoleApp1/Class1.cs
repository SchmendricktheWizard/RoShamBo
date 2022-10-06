
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
        private Random random = new Random();

        private string randString()
        {
            //generates a random number between 0 and 2
           int rand =  random.Next(0, 2);
            //switch statements are basically if else statements for
            // case 0 means if rand == 0
            // and so on 
            // break gets out of the switch statment
            
            //if
            switch (rand)
            {
                // if rand == 0
                case 0:
                    // return "R" since this function returns a string
                    return "R";
                    break;
                case 1:
                    return "P";
                    break;
                case 2:
                    return "S";
                    break;
                    /* default  occurs when a case number is not
                     * 0 1 2 ex if case =3 then it will return e 
                     * for error */
                default:
                    return "E";
                    break;

            }

        }
        public void play()
        {
            string playerChoice;
            /*declares computer choice but initalses
             * with the return value from  function 
             * that was created above*/
            string computerChoice = randString();
            // for debugging comment this out when not testing
            Console.WriteLine("Computer Chose {0} Comment out line under comment marker 1 to hide", computerChoice);
            Console.WriteLine("To play, select either Rock (R), Paper (P), or Scissors (S)");
            Console.WriteLine("Best of 3 wins, good luck!\n\n");
            Console.Write("Choose your weapon: ");
            playerChoice = Console.ReadLine();
            int result = game(playerChoice, computerChoice);
            Console.WriteLine(result);
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

