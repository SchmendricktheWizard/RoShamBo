
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
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
            int playerWins = 0;
            int computerWins = 0;
            int result = 3;
            string playerChoice = "X";
            /*declares computer choice but initalses
             * with the return value from  function 
             * that was created above*/
            string computerChoice = randString();
            // for debugging comment this out when not testing
            Console.WriteLine("Computer Chose {0} Comment out line under comment marker 1 to hide", computerChoice);
            Console.WriteLine("Best of 3 wins, good luck!\n");
            while(true)
            {
                switch (result)
                {
                    case 0:
                        Console.WriteLine("A tie! Try again.\n\n");
                        Console.Write("Choose your weapon: ");
                        playerChoice = Console.ReadLine();
                        break;
                    case 1:
                        computerWins++;
                        if (computerWins == 2)
                        {
                            Console.WriteLine("Alas, you're done for. Better luck next time.");
                            goto end;
                        }
                        Console.WriteLine("You lost! But it's not over yet.\n\n");
                        Console.Write("Choose your weapon: ");
                        playerChoice = Console.ReadLine();
                        break;
                    case 2:
                        playerWins++;
                        if (playerWins == 2)
                        {
                            Console.WriteLine("Congratulations, You Win!");
                            goto end;
                        }
                        Console.WriteLine("You Won! But it's not over yet.\n\n");
                        Console.Write("Choose your weapon: ");
                        playerChoice = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter R for Rock, P for Paper, or S for Scissors.\n\n");
                        Console.Write("Choose your weapon: ");
                        playerChoice = Console.ReadLine();
                        result = game(playerChoice, computerChoice);
                        break;
                    default:
                        Console.WriteLine("I'm confused");
                        break;
                }
                computerChoice = randString();
                result = game(playerChoice, computerChoice);
                Console.Clear();
            }
        end:
             Console.Read();
        }

        private int game(String playerChoice, String computerChoice)
        {
            //Input player and computer choice in the form of a single character string
            //Outputs 0 for a tie, 1 for a computer win, and 2 for a player win, 3 for error
            //Rocks

            if (playerChoice == computerChoice)
            {
                return 0;
            }
            switch (playerChoice)
            {
                case "R":
                    if(computerChoice == "P")
                    {
                        return 1;
                    }
                    if(computerChoice == "S")
                    {
                        return 2;
                    }
                    break;
                case "P":
                    if (computerChoice == "S")
                    {
                        return 1;
                    }
                    if (computerChoice == "R")
                    {
                        return 2;
                    }
                    break;
                case "S":
                    if (computerChoice == "R")
                    {
                        return 1;
                    }
                    if (computerChoice == "P")
                    {
                        return 2;
                    }
                    break;
                

            }
            return 3;
        }
    }
}

