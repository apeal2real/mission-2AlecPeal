//Section 001 Alexander Peal

using RollingTheDice; // Import the RollingTheDice namespace

internal class Program
{
    // Main method, entry point of the program
    private static void Main(string[] args)
    {
        int numRolls = 0;

        // Display a welcome message
        Console.WriteLine("Welcome to the dice throwing simulator!\n");

        // Prompt the user for the number of dice rolls to simulate
        Console.WriteLine("How many dice rolls would you like to simulate?");
        numRolls = int.Parse(Console.ReadLine());

        // Call the RollIt method from the DiceRolls class and display the results
        Console.WriteLine(DiceRolls.RollIt(numRolls));
    }
}
