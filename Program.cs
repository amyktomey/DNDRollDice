using DNDRollDice; 

class Program
{
    private readonly static object input;

    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Console.WriteLine("Welcome! This is a D&D dice rolling app.");
       
        Console.WriteLine("Which dice do you need to roll? ");

        //list available dice
        foreach(KeyValuePair<string, int> die in DNDDiceTypes.numberOfSides)
        {
            Console.WriteLine(die.Key, die.Value);
        }
        Console.WriteLine("Please enter the the number of sides.");
        Console.WriteLine("**For Percantage: input 100**");

        // retrieve dice type
        var sidesCountString = Console.ReadLine( );
        var sidesCount = Int32.Parse(sidesCountString);

        //add exception if entry is not in the dictionary or is null


        Console.WriteLine("How many times to roll the dice? ");

        var numberOfRolls = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfRolls; i++)
        {
            var diceRollGenerator = new RollDie(sidesCount);
            var results = diceRollGenerator.Roll();
            Console.WriteLine("Here is your roll... " + results);
        }


        //Roll again or exit
        //Console.WriteLine("Would you like to roll again?");
        //var userInput = Console.ReadLine();

        //static bool Prompt4YesNo(string prompt)
        //{
        //    string userInput = "";
        //    do
        //    {
        //        Console.Write("Would you like to roll again?");
        //        userInput = Console.ReadLine();
        //    } while (userInput.ToUpper() != "Y" && userInput.ToUpper() != "N");
        //    return userInput.ToUpper() == "Y";
        //}

        Console.ReadKey();
    }
}


