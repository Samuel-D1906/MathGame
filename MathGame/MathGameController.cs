using Spectre.Console;

namespace MathGame;

public class MathGameController
{
    internal static void MathGame(string mathOperator)
    {
        var points = 0;
        Console.WriteLine("How many Questions do you want to do?");
        var howManyQuestions = Console.ReadLine(); ;
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

    private static void GameLoop(string questions, string mathOperator, string difficulty)
    {
        Console.WriteLine($"Questions: {questions}\nMathOperator: {mathOperator}\nDifficulty:{difficulty}");
    }
}