//using CodeLouisvilleLibrary;
using DNDRollDice;

class Program
{
    static void Main(string[] args)
    {
        //include menu include a percentage roll and an average the last 'pick how many numbers' averages

        // Create instances
        //public static Dice
        //RollDie fourSided = new RollDie(4);
        RollDie sixSided = new RollDie(6);
        //RollDie eightSided = new RollDie(8);
        RollDie tenSided = new RollDie(10);
        //RollDie twelveSided = new RollDie(12);
        //RollDie twentySided = new RollDie(6);
        //RollDie hundredSided = new RollDie(100); 

        // Rolls the 6-sided die
        Console.WriteLine(sixSided);
        for (int i = 0; i < 10; i++)
            Console.Write(sixSided.Roll() + " ");

        // Rolls the 10-sided die
        Console.WriteLine("\n\n" + tenSided);
        for (int i = 0; i < 10; i++)
            Console.Write(tenSided.Roll() + " ");

        Console.ReadKey();
    }
}


