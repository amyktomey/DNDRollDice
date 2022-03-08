//using CodeLouisvilleLibrary;
using DNDRollDice;

class Program
{
    static void Main(string[] args)
    {
       //insert menu - list of available dice to roll

        RollDie sixSided = new RollDie();
        RollDie tenSided = new RollDie(10);

        Console.WriteLine(sixSided);

        Console.ReadKey();
    }
}


