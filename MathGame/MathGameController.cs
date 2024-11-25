using Spectre.Console;

namespace MathGame;

public class MathGameController
{
    internal static void MathGame(string mathOperator)
    {
        var points = 0;
        Console.WriteLine("How many Questions do you want to do?");
        var howManyQuestions = int.Parse(Console.ReadLine()!); ;
        string difficulty;
        var difficultyMode = AnsiConsole.Prompt(
            new SelectionPrompt<Enums.Difficulty>().Title("Which difficulty do you want to do?").AddChoices(
                Enums.Difficulty.Easy,
                Enums.Difficulty.Medium,
                Enums.Difficulty.Hard,
                Enums.Difficulty.Expert));

        switch (difficultyMode)
        {
            case Enums.Difficulty.Easy:
                difficulty = "Easy";
                GameLoop(howManyQuestions!, mathOperator, difficulty);
                break;
            case Enums.Difficulty.Medium:
                difficulty = "Medium";
                GameLoop(howManyQuestions!, mathOperator, difficulty);
                break;
            case Enums.Difficulty.Hard:
                difficulty = "Hard";
                GameLoop(howManyQuestions!, mathOperator, difficulty);
                break;
            case Enums.Difficulty.Expert:
                difficulty = "Expert";
                GameLoop(howManyQuestions!, mathOperator, difficulty);
                break;
        }
    }

    private static void GameLoop(int questions, string mathOperator, string difficulty)
    {
        int randomNumberMin = 0;
        int randomNumberMax = 10;
        for (var i = 0; i < questions; i++)
        {
            switch (difficulty)
            {
                case "Easy":
                    randomNumberMin = 0;
                    randomNumberMax = 10;
                    break;
                case "Medium":
                    randomNumberMin = 10;
                    randomNumberMax = 25;
                    break;
                case "Hard":
                    randomNumberMin = 25;
                    randomNumberMax = 50;
                    break;
                case "Expert":
                    randomNumberMin = 50;
                    randomNumberMax = 100;
                    break;
            }
            var random = new Random();
            var randomNumberOne = random.Next(randomNumberMin, randomNumberMax);
            var randomNumberTwo = random.Next(randomNumberMin, randomNumberMax);
            Console.WriteLine($"Question Number: {i + 1}");
            Console.WriteLine($"{randomNumberOne} {mathOperator} {randomNumberTwo}");
            var answer = Console.ReadLine();
            
        }
    }
}