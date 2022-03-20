using DNDRollDice;

class Program
{
    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        RollDie fourSided = new(4);
        RollDie sixSided = new (6);
        RollDie eightSided = new(8);
        RollDie tenSided = new (10);
        RollDie twelveSided = new(12);
        RollDie twentySided = new(20);
        RollDie percentage = new(100);

        //Rolls the 4-sided die
        Console.WriteLine("\n\n" + fourSided);
        for (int i = 0; i < 2; i++)
            Console.Write( fourSided.Roll() + " ");

        //Rolls the 6 - sided die
        Console.WriteLine("\n\n" + sixSided);
        for (int i = 0; i < 2; i++)
            Console.Write(sixSided.Roll() + " ");

        //   Rolls the 8-sided die
        Console.WriteLine("\n\n" + eightSided);
        for (int i = 0; i < 2; i++)
            Console.Write(eightSided.Roll() + " ");

        //Rolls the 10 - sided die
        Console.WriteLine("\n\n" + tenSided);
        for (int i = 0; i < 2; i++)
            Console.Write(tenSided.Roll() + " ");

        //Rolls the 12-sided die
        Console.WriteLine("\n\n" + twelveSided);
        for (int i = 0; i < 2; i++)
            Console.Write(twelveSided.Roll() + " ");

        //   Rolls the 20-sided die
        Console.WriteLine("\n\n" + twentySided);
        for (int i = 0; i < 2; i++)
            Console.Write(twentySided.Roll() + " ");

        //   Rolls percentage
        Console.WriteLine("\n\n" + percentage);
        for (int i = 0; i < 1; i++)
            Console.Write(percentage.Roll() + " ");

        Console.ReadKey();
    }
}


