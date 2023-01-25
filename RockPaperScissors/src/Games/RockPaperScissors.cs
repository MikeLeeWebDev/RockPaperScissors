using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.src.Games
{
    internal class RockPaperScissors
    {

        public void RockPaperScissorsGame()
        {


            while (playAgain)
            {


            
               

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        Console.WriteLine($"Computer choose {computer}");
                        if (player == "ROCK")
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else if (player == "PAPER")
                        {
                            Console.WriteLine("YOU WON!");
                            playerScore++;
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                            computerScore++;
                        }
                        break;
                    case 2:
                        computer = "PAPER";
                        Console.WriteLine($"Computer choose {computer}");
                        if (player == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE!");
                            computerScore++;
                        }
                        else if (player == "PAPER")
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WON!");
                            playerScore++;
                        }
                        break;
                    case 3:
                        computer = "SCISSORS";
                        Console.WriteLine($"Computer choose {computer}");
                        if (player == "ROCK")
                        {
                            Console.WriteLine("YOU WON!");
                            playerScore++;
                        }
                        else if (player == "SCISSORS")
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                            computerScore++;
                        }

                        break;


                }

              

               

                
            }



        }


    }
}
