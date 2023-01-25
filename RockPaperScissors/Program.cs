// SPEL Variabler
Random random = new Random();
string yourName;
string player = default!;
string computer;
int playerScore = 0;
int computerScore = 0;

bool playAgain = true;

// Menu Variabler
ConsoleKeyInfo key;

var option = 1;
var isSelected = false;
(int left, int top) = Console.GetCursorPosition();
var color = "\u001b[32m";

Console.CursorVisible = false;

//
//switch (random.Next(1, 4))
//{
//                    case 1:
//                        computer = "STEN";
//    break;
//                    case 2:
//                        computer = "SAX";
//    break;
//                    case 3:
//                        computer = "PÅSE";
//    break;
//}

//switch (option)
//{
//    case 1:
//        player = "ROCK";
//        break;
//    case 2:
//        player = "PAPER";
//        break;
//    case 3:
//        player = "SCISSORS";
//        break;
//}

// Menu
//while (!isSelected)
//{
//    Console.SetCursorPosition(left, top);

//    Console.WriteLine($"{(option == 1 ? color : "")} Option 1\u001b[0m");
//    Console.WriteLine($"{(option == 2 ? color : "")} Option 1\u001b[0m");
//    Console.WriteLine($"{(option == 3 ? color : "")} Option 1\u001b[0m");

//    key = Console.ReadKey();

//    switch (key.Key)
//    {
//        case ConsoleKey.DownArrow:
//            option = (option == 3 ? 1 : option + 1);
//            break;
//        case ConsoleKey.UpArrow:
//            option = (option == 1 ? 3 : option - 1);
//            break;
//        case ConsoleKey.Enter:
//            if (option == 1)
//            {
//                player = "ROCK";
//            }
//            else if (option == 2)
//            {
//                player = "PAPER";
//            }
//            else
//            {
//                player = "SCISSORS";
//            }
//            break;
//    }
//}


// Spel Start
//Console.WriteLine("What is your name?");
//yourName = Console.ReadLine();


while (playAgain)
{

        Console.Write("Choose ROCK, PAPER, OR SCISSORS\n");
        Thread.Sleep(3000);
        Console.Clear();

        while (!isSelected)
            {
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"{(option == 1 ? color : "")} ROCK\u001b[0m");
            Console.WriteLine($"{(option == 2 ? color : "")} PAPER\u001b[0m");
            Console.WriteLine($"{(option == 3 ? color : "")} SCISSORS\u001b[0m");

            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    //Console.Clear();
                    option = (option == 3 ? 1 : option + 1);
                    break;
                case ConsoleKey.UpArrow:
                    //Console.Clear();
                    option = (option == 1 ? 3 : option - 1);
                    break;
                case ConsoleKey.Enter:
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

    //Console.WriteLine($"\n{yourName} Score: {playerScore}\nComputer Score: {computerScore}");

    Console.WriteLine("Would you like to play again? (Y/N)");
    string answer = Console.ReadLine();
    answer = answer.ToUpper();
    if (answer == "Y")
    {
        playAgain = true;
        isSelected = false;
    }
    else
    {
        playAgain = false;
    }
}

//Console.WriteLine($"\nThank you for playing! \n\n{yourName} Score: {playerScore}\nComputer Score: {computerScore}");











