

/* The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100.
   Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer. */ 


/* You should record previous games in a List and there should be an option in the menu for the user to visualize
   a history of previous games. */
var points = new List<string>();
var gameModeHistory = new List<string>();
ShowMenu();



// Users should be presented with a menu to choose an operation
void ShowMenu()
{
   // You need to create a Math game containing the 4 basic operations
   
   Console.WriteLine("Please enter a option to select the Operation you want");
   Console.WriteLine("1. Summation");
   Console.WriteLine("2. Subtraction");
   Console.WriteLine("3. Multiplication");
   Console.WriteLine("4. Division");
   Console.WriteLine("5. Random Game Mode");
   
   /* You should record previous games in a List and there should be an option in the menu for the user to visualize
   a history of previous games. */
   
   Console.WriteLine("6. Show history Previous games");
   Console.WriteLine("7. Exit");

  string option = Console.ReadLine()!;

  switch (option)
  {
     case "1": 
        GameMode("Summation");
        break;
     case "2":
        GameMode("Subtraction");
        break;
     case "3":
        GameMode("Multiplication");
        break;
     case "4":
        GameMode("Division");
        break;
     case "5":
        RandomGameMode();
        break;
     case "6":
        ShowHistory();
        break;
     case "7":
        break;
  }


  
}

void GameMode(string gameMode)
  {
     var difficulty = CheckDifficulty();

     GameLoopDifficulty(gameMode, difficulty);
  }

 //Try to implement levels of difficulty. 
int  CheckDifficulty()
  {
     Console.WriteLine("Please enter the difficulty you want to check: ");
     Console.WriteLine("1. Easy");
     Console.WriteLine("2. Normal");
     Console.WriteLine("3. Hard");
     Console.WriteLine("4. Expert");
     var difficulty = int.Parse(Console.ReadLine()!);
     return difficulty;
     
  }

//Try to implement levels of difficulty.
void GameLoopDifficulty(string whichGame, int difficulty)
  {
     string mathOperator = "";
     switch (whichGame)
     {
        case "Summation":
           mathOperator = "+";
           break;
        case "Subtraction":
           mathOperator = "-";
           break;
        case "Multiplication":
           mathOperator = "*";
           break;
        case "Division":
           mathOperator = "/";
           break;
     }
     var random = new Random();
     int firstNumber = 0;
     int secondNumber = 0;
     switch (difficulty)
     {
        case 1:
           ForLoopGame(firstNumber, secondNumber, mathOperator,1, 10);
           break;
        case 2:
           ForLoopGame(firstNumber, secondNumber, mathOperator,1, 50);
           break;
        case 3:
           ForLoopGame(firstNumber, secondNumber, mathOperator,10, 75);
           break;
        case 4:
           ForLoopGame(firstNumber, secondNumber, mathOperator,10, 100);
           break;
     }
  }

//Generates the Loop for everygame Mode
void ForLoopGame(int firstNumber, int secondNumber, string mathOperator,int randomNumberMin, int randomNumberMax)
  {
     var random = new Random();
     var score = 0;
     Console.WriteLine("Please enter the number of questions you want ?");
     int questions = int.Parse(Console.ReadLine()!);
     
     for (int i = 0; i < questions; i++)
     {
        firstNumber = random.Next(randomNumberMin, randomNumberMax);
        secondNumber = random.Next(randomNumberMin, randomNumberMax);

        

        if (mathOperator == "/" )
        {
           if (firstNumber % secondNumber == 0)
           {
              Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber}");
           }
           else
           {
              continue;
           }
        }
        else
        {
           Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber}");
        }
        var result = Console.ReadLine();
        

        switch (mathOperator)
        {
           case "+":
              if (int.Parse(result!) == firstNumber + secondNumber)
              {
                 Console.WriteLine("Your answer was correct! Type any key to continue");
                 score++;
              }
              else
              {
                 Console.WriteLine("Your answer was incorrect! Type any key to continue");
              }

              if (i == questions - 1 )
              {
                 GameOver(score);
              }
              break;
           case "-":
              if (int.Parse(result!) == firstNumber - secondNumber)
              {
                 Console.WriteLine("Your answer was correct! Type any key to continue");
                 score++;
              }
              else
              {
                 Console.WriteLine("Your answer was incorrect! Type any key to continue");
              }

              if (i == questions - 1 )
              {
                 GameOver(score);
              }
              
              break;
           case "*":
              if (int.Parse(result!) == firstNumber * secondNumber)
              {
                 Console.WriteLine("Your answer was correct! Type any key to continue");
                 score++;
              }
              else
              {
                 Console.WriteLine("Your answer was incorrect! Type any key to continue");
              }

              if (i == questions - 1 )
              {
                 GameOver(score);
              }
              break;
           case "/":
              if (int.Parse(result!) == firstNumber / secondNumber )
              {
                 Console.WriteLine("Your answer was correct! Type any key to continue");
                 score++;
              }
              else
              {
                 Console.WriteLine("Your answer was incorrect! Type any key to continue");
              }

              if (i == questions - 1 )
              {
                 GameOver(score);
              }
              break;
           
        }

        
     }
  }

// Shows the History of the games played before
void ShowHistory()
  {
     
     for (int i = 0; i < points.Count; i++)
     {
        Console.WriteLine($"{i+1}. Previous Game Mode: {gameModeHistory[i]} Points: {points[i]}.");
     }
  }

// Game Over
void GameOver(int score)
  {
     Console.WriteLine($"Game over! Your score is {score}");
     points.Add(score.ToString());
     gameModeHistory.Add("Summation");
     ShowMenu();
  }


// Create a 'Random Game' option where the players will be presented with questions from random operations
void RandomGameMode()
{
   return;
}


//Add a timer to track how long the user takes to finish the game.
void TrackTimer()
{
   return;
}

 