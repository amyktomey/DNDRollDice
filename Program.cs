//using CodeLouisvilleLibrary;
using DNDRollDice;

class Program
{
    static void Main(string[] args)
    {
        // select the dice to roll
        Console.WriteLine("Which dice do you need to roll: ");
        Console.WriteLine("d4, d6, d8, d10, d12, d20, Percentage?  ");
        Console.ReadLine();

        // how many dice to roll
        Console.WriteLine("How many times to roll?   ");
        Console.ReadLine();


        //calculate the result - roll the dice and total.

        //print the result to the console
        Console.WriteLine("You rolled { number of dice} {sides} sided dice for a total of {RollTotal}");

        //log the result

        // ORIGINAL PROGRAM BELOW
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


