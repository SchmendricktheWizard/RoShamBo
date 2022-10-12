
using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class RoShamBo
    {
        int playerWins = 0;
        int computerWins = 0;

        private Random random = new Random();

        private string RandString()
        {
            //generates a random number between 0 and 2
            int rand = random.Next(0, 3);
            //switch statements are basically if else statements for
            // case 0 means if rand == 0
            // and so on 
            // break gets out of the switch statement

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

        private void Scoring(int result)
        {
            switch (result)
            {
                case 0: //Tie
                    Console.WriteLine("{0,0}{1,15}", playerWins, computerWins);
                    Console.WriteLine("A tie! Try again.");
                    break;
                case 1: //Computer Win
                    computerWins++;
                    Console.WriteLine("{0}{1,15}", playerWins, computerWins);
                    Console.WriteLine("You lost! But it's not over yet.");
                    break;
                case 2: //Player Win
                    playerWins++;
                    Console.WriteLine("{0}{1,15}", playerWins, computerWins);
                    Console.WriteLine("You Won! But it's not over yet.");
                    break;
                case 3: //Starting, as well as error or invalid input
                    Console.WriteLine("{0}{1,15}", playerWins, computerWins);
                    Console.WriteLine("Enter R for Rock, P for Paper, or S for Scissors.");
                    break;
                default: //Shouldn't happen
                    Console.WriteLine("I'm confused");
                    break;
            }

        }
        public void Play()
        {
            int result = 3;
            string playerChoice = "X";
            /*declares computer choice but initalses
             * with the return value from  function 
             * that was created above*/
            string computerChoice = RandString();
            // for debugging comment this out when not testing
            //Console.WriteLine("Computer Chose {0} Comment out line under comment marker 1 to hide", computerChoice);
            Console.WriteLine("Best of 3 wins, good luck!\n");
            while (true)
            {
                Console.Clear();
                Scoring(result);
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
                computerChoice = RandString();
                result = Game(playerChoice, computerChoice);

            }
            Console.ReadKey();
        }
        //this code sucks but looks cool
        private void Animation(string computerChoice, string playerChoice)
        {
            //arrays are cool here we basically have a list of three items to choose from
            // also notice how it says string[] 
            // to select somthing from our list we do  stringArray[0] for rocks stringarray[1] for paper etc
            string[] stringArray = { "Rocks", "Paper", "Scissors" };

            Console.CursorVisible = false;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Clear();
                    switch (playerChoice)
                    {
                        case "R":
                            Console.Write("If You Choose {0}", stringArray[0]);
                            break;
                        case "P":
                            Console.Write("If You Choose {0}", stringArray[1]);
                            break;
                        case "S":
                            Console.Write("If You Choose {0}", stringArray[2]);
                            break;
                        default:
                            Console.Write("If You Tried to outsmart me");
                            break;
                    }
                    Console.Write("\nI Shall Choose {0}", stringArray[j]);
                    Thread.Sleep(20);
                }
            }

            Console.Clear();
            switch (playerChoice)
            {
                case "R":
                    Console.Write("If You Choose {0}", stringArray[0]);
                    break;
                case "P":
                    Console.Write("If You Choose {0}", stringArray[1]);
                    break;
                case "S":
                    Console.Write("If You Choose {0}", stringArray[2]);
                    break;
                default:
                    Console.Write("If You Tried to outsmart me");
                    break;
            }
            Console.WriteLine();
            switch (computerChoice)
            {
                case "R":
                    Console.Write("I Shall Choose {0}", stringArray[0]);
                    break;
                case "P":
                    Console.Write("I Shall Choose {0}", stringArray[1]);
                    break;
                case "S":
                    Console.Write("I Shall Choose {0}", stringArray[2]);
                    break;
                default:
                    Console.Write("etawoetaejiawotgjaweiwhoeh9giaweg");
                    break;
            }
            Thread.Sleep(1000);
        }


        private int Game(String playerChoice, String computerChoice)
        {
            //Input player and computer choice in the form of a single character string
            //Outputs 0 for a tie, 1 for a computer win, and 2 for a player win, 3 for error
            //Rocks
            Animation(computerChoice,playerChoice);
            if (playerChoice == computerChoice)
            {
                return 0;
            }
            switch (playerChoice)
            {
                case "R":
                    if (computerChoice == "P")
                    {
                        return 1;
                    }
                    if (computerChoice == "S")
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

