using DNDRollDice; 

class Program
{
    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Console.WriteLine("Welcome! This is a D&D dice rolling app.");
       

        // first ask user for the dice type
        Console.WriteLine("Which dice do you need to roll? ");

        //list available dice
        foreach(KeyValuePair<string, int> die in DNDDiceTypes.numberOfSides)
        {
            Console.WriteLine(die.Key, die.Value);
        }

        // second retrieve dice type
        var sidesCountString = Console.ReadLine( );
        var sidesCount = Int32.Parse(sidesCountString);

        // ask for number of rolls
        Console.WriteLine("How many times to roll the dice? ");

        var numberOfRolls = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfRolls; i++)
        {
            var diceRollGenerator = new RollDie(sidesCount);
            var results = diceRollGenerator.Roll();
            Console.WriteLine("Here is your roll... " + results);
        }

        //print to console
        //ask if done?


        //RollDie fourSided = new(4);
        //RollDie sixSided = new (6);
        //RollDie eightSided = new(8);
        //RollDie tenSided = new (10);
        //RollDie twelveSided = new(12);
        //RollDie twentySided = new(20);
        //RollDie percentage = new(100);

        ////Rolls the 4-sided die
        //Console.WriteLine("\n\n" + fourSided);
        //for (int i = 0; i < 2; i++)
        //    Console.Write( fourSided.Roll() + " ");

        ////Rolls the 6 - sided die
        //Console.WriteLine("\n\n" + sixSided);
        //for (int i = 0; i < 2; i++)
        //    Console.Write(sixSided.Roll() + " ");

        ////   Rolls the 8-sided die
        //Console.WriteLine("\n\n" + eightSided);
        //for (int i = 0; i < 2; i++)
        //    Console.Write(eightSided.Roll() + " ");

        ////Rolls the 10 - sided die
        //Console.WriteLine("\n\n" + tenSided);
        //for (int i = 0; i < 2; i++)
        //    Console.Write(tenSided.Roll() + " ");

        ////Rolls the 12-sided die
        //Console.WriteLine("\n\n" + twelveSided);
        //for (int i = 0; i < 2; i++)
        //    Console.Write(twelveSided.Roll() + " ");

        ////   Rolls the 20-sided die
        //Console.WriteLine("\n\n" + twentySided);
        //for (int i = 0; i < 2; i++)
        //    Console.Write(twentySided.Roll() + " ");

        ////   Rolls percentage
        //Console.WriteLine("\n\n" + percentage);
        //for (int i = 0; i < 1; i++)
        //    Console.Write(percentage.Roll() + " ");

        Console.ReadKey();
    }
}


