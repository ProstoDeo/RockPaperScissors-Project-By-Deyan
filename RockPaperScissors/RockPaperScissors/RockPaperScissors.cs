int playerScore = 0;
int pcScore = 0;
bool playAgain = true;
while (playAgain)
{
    string winorlose = "";
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
    Console.ForegroundColor = ConsoleColor.White;
    string playerMove = Console.ReadLine();
    switch (playerMove)
    {
        case "r":
        case "rock":
            playerMove = "Rock";
            break;
        case "s":
        case "scissors":
            playerMove = "Scissors";
            break;
        case "p":
        case "paper":
            playerMove = "Paper";
            break;
        default:
            Console.WriteLine("Invlaid Input. Try Again...");
            return;
    }
    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);
    string computerMove = "";
    switch (computerRandomNumber)
    {
        case 1:
            computerMove = "Rock";
            break;
        case 2:
            computerMove = "Paper";
            break;
        case 3:
            computerMove = "Scissors";
            break;
    }
    Console.WriteLine($"The computer chose {computerMove}.");
    switch (playerMove)
    {
        case "Rock":
            switch (computerMove)
            {
                case "Scissors":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    winorlose = "won";
                    break;
                case "Rock":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was a draw.");
                    winorlose = "draw";
                    break;
                case "Paper":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    winorlose = "lost";
                    break;
            }
            break;
        case "Paper":
            switch (computerMove)
            {
                case "Rock":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    winorlose = "won";
                    break;
                case "Paper":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was a draw.");
                    winorlose = "draw";
                    break;
                case "Scissors":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    winorlose = "lost";
                    break;
            }
            break;
        case "Scissors":
            switch (computerMove)
            {
                case "Paper":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    winorlose = "won";
                    break;
                case "Scissors":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was a draw.");
                    winorlose = "draw";
                    break;
                case "Rock":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    winorlose = "lost";
                    break;
            }
            break;
    }
    switch (winorlose)
    {
        case "won":
            Console.ForegroundColor = ConsoleColor.Green;
            playerScore += 1;
            break;
        case "lost":
            Console.ForegroundColor = ConsoleColor.Red;
            pcScore += 1;
            break;
        case "draw":
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        default:
            Console.ResetColor();
            break;
    }
    string playerEnding = "";
    string pcEnding = "";
    if (playerScore > 1 || playerScore == 0)
    {
        playerEnding = "s";
    }
    if (pcScore > 1 || pcScore == 0)
    {
        pcEnding = "s";
    }
    if (playerScore >= 0)
    {
        Console.WriteLine($"You have won {playerScore} time{playerEnding} and the machine has won {pcScore} time{pcEnding}.");
    }
    else
    {
        Console.WriteLine($"You haven't won so far but the machine has won {pcScore} time{pcEnding}.");
    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Do you want to play again (Yes or No)");
    string input = Console.ReadLine();
    playAgain = (input == "Yes" || input == "yes");
    Console.ResetColor();
}