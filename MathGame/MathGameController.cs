using System.Diagnostics;
using Spectre.Console;
using static MathGame.UserInterface;

namespace MathGame;

public static class MathGameController
{
    private static List<string> _previousGameHistory = [];
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
        var randomNumberMin = 0;
        var randomNumberMax = 10;
        var points = 0;
        var stopWatch = new Stopwatch();
        stopWatch.Start();
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
            
            if (mathOperator == "/")
            {
                if (randomNumberOne % randomNumberTwo != 0 )
                {
                    break;
                }

                Console.WriteLine($"Question Number: {i + 1}");
                Console.WriteLine($"{randomNumberOne} {mathOperator} {randomNumberTwo}");
            }
            else
            {
                Console.WriteLine($"Question Number: {i + 1}");
                Console.WriteLine($"{randomNumberOne} {mathOperator} {randomNumberTwo}");
            }

            try
            {
                var answer = int.Parse(Console.ReadLine()!);
                switch (mathOperator)
                {
                    case "+":
                        if (answer == randomNumberOne + randomNumberTwo)
                        {
                            points++;
                        }
                        break;
                    case "-":
                        if (answer == randomNumberOne - randomNumberTwo)
                        {
                            points++;
                        }
                        break;
                    case "*":
                        if (answer == randomNumberOne * randomNumberTwo)
                        {
                            points++;
                        }
                        break;
                    case "/":
                        if (answer == randomNumberOne / randomNumberTwo)
                        {
                            points++;
                        }

                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
        stopWatch.Stop();
        var time = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            time.Hours, time.Minutes, time.Seconds);
        var gameLeaderboard = $"Difficulty: {difficulty}\t Points: {points} Time needed: {elapsedTime}";
        Console.WriteLine(gameLeaderboard);
        _previousGameHistory.Add(gameLeaderboard);
        
        GetMenu();
    }
    
    internal static void GetList()
    {
        Console.WriteLine("Previous Games: \n" + string.Join("\n", _previousGameHistory));
        UserInterface.GetMenu();
        
    }

    internal static void DeleteList()
    {
        _previousGameHistory.Clear();
    }
}



