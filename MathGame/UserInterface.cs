using System.Diagnostics;

namespace MathGame;
using Spectre.Console;

public class UserInterface
{
    internal static void GetMenu()
    {
        var whichOperator = "";
        
        var userOption = AnsiConsole.Prompt(
            new SelectionPrompt<Enums.MenuOptions>().Title("Which mode do you want to do?").AddChoices(
                Enums.MenuOptions.Addition,
                Enums.MenuOptions.Subtraction,
                Enums.MenuOptions.Multiplication, 
                Enums.MenuOptions.Division, 
                Enums.MenuOptions.Random, 
                Enums.MenuOptions.Quit)); 
            
            string menuMessage;

            switch (userOption)
            {
                case Enums.MenuOptions.Addition:
                    whichOperator = "+";
                    MathGameController.MathGame(whichOperator);
                    break;
                case Enums.MenuOptions.Subtraction:
                    whichOperator = "-";
                    MathGameController.MathGame(whichOperator);
                    break;
                case Enums.MenuOptions.Multiplication:
                    whichOperator = "*";
                    MathGameController.MathGame(whichOperator);
                    break;
                case Enums.MenuOptions.Division:
                    whichOperator = "/";
                    MathGameController.MathGame(whichOperator);
                    break;
                case Enums.MenuOptions.Random:
                    whichOperator = GetRandomOperator();
                    MathGameController.MathGame(whichOperator);
                    break;
                case Enums.MenuOptions.Quit:
                    break;
            }
        }
        
        
        
    

    private static string  GetRandomOperator()
    { 
        var random = new Random();
        int randomOperator = random.Next(0, 3);
        var whichOperator = "";
        switch (randomOperator)
        {
          case 0:
              whichOperator =  "+";
              break;
          case 1:
              whichOperator =  "-";
              break;
          case 2:
              whichOperator =  "*";
              break;
          case 3:
              whichOperator =  "/";
              break;
          
        }
        return whichOperator;
    }
    
    
}