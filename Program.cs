using System;
using System.Collections.Generic;
using DNDRollDice; 

class Program
{
    private static string userInput = "Y";

    static void Main(string[] args)

    {
        while (userInput == "Y")
        {
            Console.Clear();
            Console.WriteLine("Welcome! This is a D&D dice rolling app.");

            Console.WriteLine("Which dice do you need to roll? ");

            //list available dice
            foreach (KeyValuePair<string, int> die in DNDDiceTypes.numberOfSides)
            {
                Console.WriteLine(die.Key, die.Value);
            }
            Console.WriteLine("Please enter the the number of sides.");
            Console.WriteLine("**For Percantage: input 100**");

            // retrieve dice type
            var sidesCountString = Console.ReadLine();
            var sidesCount = Int32.Parse(sidesCountString);
           
            Console.WriteLine("How many times to roll the dice? ");

            var numberOfRolls = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRolls; i++)
            {
                var diceRollGenerator = new RollDie(sidesCount);
                var results = diceRollGenerator.Roll();
                Console.WriteLine("Here is your roll... " + results);
            }

            Console.WriteLine("Would you like to roll again?");
            Console.WriteLine("Enter Y for yes or N for no.");
            userInput = Console.ReadLine().ToUpper();


            if (userInput != "Y")
            {
                Console.WriteLine("Thank you, brave adventurers, for rolling dice with us. Safe journeys ahead!");
                Environment.Exit(0);
            }
        }
         Console.ReadKey();
    }
}


