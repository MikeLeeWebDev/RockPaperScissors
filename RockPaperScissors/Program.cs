// SPEL Variabler
using RockPaperScissors.Helpers;
using RockPaperScissors.Models;
using System.Reflection.Emit;

//Random random = new Random();


// Menu Variabler
//(int left, int top) = Console.GetCursorPosition();
//


Console.WriteLine("Enter your name: ");
Variables.yourName = Console.ReadLine();
Console.CursorVisible = false;
Console.Clear();

Menu.MainMenu();

