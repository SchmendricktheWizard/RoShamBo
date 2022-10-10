
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
           int rand =  random.Next(0, 3);
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
            //Console.WriteLine("Computer Chose {0} Comment out line under comment marker 1 to hide", computerChoice);
            Console.WriteLine("Best of 3 wins, good luck!\n");
            while(true)
            {
                Console.Clear();
                
                switch (result)
                {
                    case 0: //Tie
                        Console.WriteLine(playerWins + "   " + computerWins);
                        Console.WriteLine("A tie! Try again.");
                        break;
                    case 1: //Computer Win
                        computerWins++;
                        Console.WriteLine(playerWins + "   " + computerWins);
                        Console.WriteLine("You lost! But it's not over yet.");
                        break;
                    case 2: //Player Win
                        playerWins++;
                        Console.WriteLine(playerWins + "   " + computerWins);
                        Console.WriteLine("You Won! But it's not over yet.");
                        break;
                    case 3: //Starting, as well as error or invalid input
                        Console.WriteLine(playerWins + "   " + computerWins);
                        Console.WriteLine("Enter R for Rock, P for Paper, or S for Scissors.");
                        break;
                    default: //Shouldn't happen
                        Console.WriteLine("I'm confused");
                        break;
                }
                //End game if best of 3 is reached
                if (computerWins == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Alas, you're done for. Better luck next time.");
                    break;
                }
                if (playerWins == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations, You Win!");
                    break;
                }

                Console.Write("\n\nChoose your weapon: ");
                playerChoice = Console.ReadLine();
                computerChoice = randString();
                result = game(playerChoice, computerChoice);
                
            }
             Console.ReadKey();
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

