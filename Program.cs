using DNDRollDice;

class Program
{
    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        // RollDie fourSided = new(4);
        RollDie sixSided = new RollDie(6);
       //  RollDie eightSided = new(8);
       RollDie tenSided = new RollDie(10);
        // RollDie twelveSided = new (12);
        // RollDie twentySided = new(6);
        // RollDie percentage = new(100);

    ////Rolls the 4-sided die
    //    Console.WriteLine(fourSided);
    //    for (int i = 0; i< 10; i++)
    //        Console.Write(fourSided.Roll() + " ");

        //Rolls the 6-sided die
        Console.WriteLine(sixSided);
        for (int i = 0; i < 10; i++)
            Console.Write(sixSided.Roll() + " ");

        ////   Rolls the 8-sided die
        //Console.WriteLine("\n\n" + eightSided);
        //for (int i = 0; i < 10; i++)
        //    Console.Write(eightSided.Roll() + " ");

        //   Rolls the 10-sided die
        Console.WriteLine("\n\n" + tenSided);
        for (int i = 0; i < 10; i++)
            Console.Write(tenSided.Roll() + " ");

        ////Rolls the 12-sided die
        //Console.WriteLine(twelveSided);
        //for (int i = 0; i < 10; i++)
        //    Console.Write(twelveSided.Roll() + " ");

        ////   Rolls the 20-sided die
        //Console.WriteLine("\n\n" + twentySided);
        //for (int i = 0; i < 10; i++)
        //    Console.Write(twentySided.Roll() + " ");
        ////   Rolls percentage
        //Console.WriteLine("\n\n" + percentage);
        //for (int i = 0; i < 10; i++)
        //    Console.Write(percentage.Roll() + " ");

        Console.ReadKey();
    }
}


