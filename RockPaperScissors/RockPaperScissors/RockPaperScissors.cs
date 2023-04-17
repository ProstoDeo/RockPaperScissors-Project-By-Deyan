string Rock = "Rock";
string Paper = "Paper";
string Scissors = "Scissors";
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
                break;
            case "Rock":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
                break;
            case "Paper":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
                break;
        }
        break;
    case "Paper":
        switch (computerMove)
        {
            case "Rock":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win.");
                break;
            case "Paper":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
                break;
            case "Scissors":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
                break;
        }
        break;
    case "Scissors":
        switch (computerMove)
        {
            case "Paper":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win.");
                break;
            case "Scissors":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
                break;
            case "Rock":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
                break;
        }
        break;
}
Console.ResetColor();