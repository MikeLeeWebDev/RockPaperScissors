// SPEL Variabler
Random random = new Random();
string yourName;
string player = default!;
string computer;
int playerScore = 0;
int computerScore = 0;
string answer;

bool playAgain = true;

// Menu Variabler
ConsoleKeyInfo key;
ConsoleKeyInfo key2;

var option = 1;
var gameOverOption = 1;
var isSelected = false;
var gameOverSelected = false;
(int left, int top) = Console.GetCursorPosition();
var colorGreen = "\u001b[32m";
var colorRed = "\u001b[31m";

Console.CursorVisible = false;
Console.WriteLine("Enter your name: ");
yourName = Console.ReadLine();


while (playAgain)
{

        

        while (!isSelected)
            {
            //Console.SetCursorPosition(left, top);
            Console.Write("Choose ROCK, PAPER, OR SCISSORS\n");
            Console.WriteLine($"{(option == 1 ? colorGreen : "")} ROCK\u001b[0m");
            Console.WriteLine($"{(option == 2 ? colorGreen : "")} PAPER\u001b[0m");
            Console.WriteLine($"{(option == 3 ? colorGreen : "")} SCISSORS\u001b[0m");

            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                Console.Clear();
                option = (option == 3 ? 1 : option + 1);
                    break;
                case ConsoleKey.UpArrow:
                Console.Clear();
                option = (option == 1 ? 3 : option - 1);
                    break;
                case ConsoleKey.Enter:
                Console.Clear();
                    if (option == 1)
                    {
                        player = "ROCK";
                    }
                    else if (option == 2)
                    {
                        player = "PAPER";
                    }
                    else
                    {
                        player = "SCISSORS";
                    }
                    isSelected= true;
                    break;
            }
        }

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

    Console.WriteLine($"\n{yourName} score: {playerScore}\ncomputer score: {computerScore}");
    Thread.Sleep(1500);
    Console.Clear();
    //Console.WriteLine("Would you like to play again? (Y/N)");
    gameOverSelected = false;

    while (!gameOverSelected)
    {
        //Console.SetCursorPosition(left, top);
        Console.WriteLine("Would you like to play again? (Y/N)");
        Console.WriteLine($"{(gameOver == 1 ? colorGreen : "")} YES\u001b[0m");
        Console.WriteLine($"{(gameOver == 2 ? colorRed : "")} NO\u001b[0m");
        


        key2 = Console.ReadKey();

        switch (key2.Key)
        {
            case ConsoleKey.DownArrow:
                Console.Clear();
                gameOver = (gameOver == 2 ? 1 : gameOver + 1);
                break;
            case ConsoleKey.UpArrow:
                Console.Clear();
                gameOver = (gameOver == 1 ? 2 : gameOver - 1);
                break;
            case ConsoleKey.Enter:
                Console.Clear();
                if (gameOver == 1)
                {
                    playAgain = true;
                    isSelected= false;  
                }
                else 
                {
                    playAgain = false;
                }
                gameOverSelected = true;

                break;
        }
        
        //END SCORE
        Console.WriteLine($"GAME OVER!\n{yourName} score: {playerScore}\ncomputer score: {computerScore}");

    }
}

Console.WriteLine("Test");










