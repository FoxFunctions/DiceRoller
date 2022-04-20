public static class Program
{
    static Random diceRoll = new Random();

    public static void Main()
    {
        DiceGame();
    }
    public static void RollDice(int roll)
    {
        int firstRoll = diceRoll.Next(1, roll+1);
        int secondRoll = diceRoll.Next(1, roll+1);
        Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll} ");
        Console.WriteLine($"You rolled for a total of {firstRoll+secondRoll}");

        if (roll == 6 && firstRoll == 1 && secondRoll == 1)
        {
            Console.WriteLine("Snake Eyes! Two 1s");
        }
        else if (roll == 6 && firstRoll == 1 && secondRoll == 2)
        {
            Console.WriteLine("Ace Deuce: A 1 and 2");
        }
        else if (roll == 6 && firstRoll == 6 && secondRoll == 6)
        {
            Console.WriteLine("Box Cars: Two 6s");
        }
        else if (roll ==6 && firstRoll + secondRoll == 7 || firstRoll + secondRoll == 11)
        {
            Console.WriteLine("Win: A total of 7 or 11");
        }
        else if (roll == 6 && firstRoll + secondRoll == 2 || firstRoll + secondRoll == 3 || firstRoll + secondRoll == 12)
        {
            Console.WriteLine("Craps: A total of 2, 3, or 12");
        }
        else if (roll == 10 && firstRoll + secondRoll == 20)
        {
            Console.WriteLine("You rolled for crit!");
        }
    }
    public static void DiceGame()
    {       int i;
        while (true)
        {
            try
            {
                Console.WriteLine("How many sided die would you like to roll? Please enter a whole number greater than or equal to 1");
                i = int.Parse(Console.ReadLine());
                
                if (i >= 1)
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
            RollDice(i);
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
}