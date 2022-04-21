public static class Program
{
    static Random diceRoll = new Random();
    static bool runAgain = true;

    public static void Main()
    {
        Console.WriteLine("Welcome to the Grand Circus Casino!");

        while (runAgain)
        {
            DiceGame();
            runAgain = RunAgain();
        }
    }
    public static void RollDiceAndPrintResult(int roll)
    {
        int firstRoll = diceRoll.Next(1, roll+1);
        int secondRoll = diceRoll.Next(1, roll+1);
        Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll}.");
        Console.WriteLine($"You rolled for a total of {firstRoll+secondRoll}.");

        if (roll == 6)
        {
            if (firstRoll == 1 & secondRoll == 1)
            {
                Console.WriteLine("Snake Eyes! Two 1s");
            }
        }
        if (roll == 6)
        {
            if (firstRoll == 1 && secondRoll == 2)
            {
                Console.WriteLine("Ace Deuce: A 1 and 2");
            }
        }
        if (roll == 6)
        {
            if(firstRoll == 2 && secondRoll == 1)
            {
                Console.WriteLine("Ace Deuce: A 1 and 2");
            }
        }
        if (roll == 6)
        {
           if (firstRoll == 6 && secondRoll == 6)
            {
                Console.WriteLine("Box Cars: Two 6s");
            }
        }
        if (roll ==6)
        { 
            if (firstRoll + secondRoll == 7 || firstRoll + secondRoll == 11)
            {
                Console.WriteLine("Win: A total of 7 or 11");
            } 
        }
        if (roll == 6)
        {
            if (firstRoll + secondRoll == 2 || firstRoll + secondRoll == 3 || firstRoll + secondRoll == 12)
            {
                Console.WriteLine("Craps: A total of 2, 3, or 12");
            }
        }
        if (roll == 10)
        {
            if (firstRoll == 10 && secondRoll == 10)
            {
                Console.WriteLine("You rolled for crit!");
            }
        }
        if (roll == 20)
        {
            if (firstRoll == 20 && secondRoll == 20)
            {
                Console.WriteLine("HOLY SMOKES THAT'S A DOUBLE CRIT! THERE IS ONLY A 0.25% CHANCE OF THIS HAPPENING!");
            }
        }
    }
    public static void DiceGame()
    {   int i;
        while (true)
        {
            try
            {
                Console.WriteLine("How many sided die would you like to roll? Please enter a whole number greater than 1");
                i = int.Parse(Console.ReadLine());
                
                if (i > 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid input.");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Sorry, that is not a valid input. Please enter an integer value.");
                continue;
            }
        }
        while (true)
        {
            RollDiceAndPrintResult(i);
            Console.WriteLine("Would you like to roll again? please enter y/n");
            string response = Console.ReadLine().ToLower().Trim();

            if (response == "y")
            {
                continue;
            }
            else if (response == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't get that. Please try again.");
                continue;
            }
        }
    }
    public static bool RunAgain()
    {
        Console.WriteLine("Would you like to roll again with a different dice? please enter y/n");
        string response = Console.ReadLine().ToLower().Trim();

        if (response == "y")
        {
            return true;
        }
        else if (response == "n")
        {
            Console.WriteLine("Goodbye.");
            return false;
        }
        else
        {
            Console.WriteLine("Sorry, I didn't get that. Please try again.");
            return RunAgain();
        }
    }
}