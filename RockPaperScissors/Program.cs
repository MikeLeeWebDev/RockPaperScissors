// SPEL Variabler
using RockPaperScissors.Helpers;
using RockPaperScissors.Models;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;


//Random random = new Random();


// Menu Variabler
//(int left, int top) = Console.GetCursorPosition();
//


Console.WriteLine("Enter your name: ");
Variables.yourName = Console.ReadLine();
Console.CursorVisible = false;
Console.Clear();

Menu.MainMenu();

