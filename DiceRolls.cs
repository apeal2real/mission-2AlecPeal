using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingTheDice
{
    internal class DiceRolls
    {
        // Method to simulate dice rolls and generate a string with results
        public static string RollIt(int numRolls)
        {
            // Array to store the count of each possible total from rolling two dice
            int[] rollCounts = new int[11]; // 0 to 10, index 0 is not used

            // Random number generator for dice rolls
            Random random = new Random();

            int numRolled = 0;
            int numRolled2 = 0;
            int totalRolled = 0;

            // Loop through the specified number of rolls
            for (int i = 0; i < numRolls; i++)
            {
                // Generate random rolls for two six-sided dice
                numRolled = random.Next(1, 7);
                numRolled2 = random.Next(1, 7);

                // Calculate the total from the two rolls
                totalRolled = numRolled + numRolled2;

                // Increment the count for the corresponding total in the array
                rollCounts[totalRolled - 2]++;
            }

            // Generate the result string with simulation details
            string returnString = "DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls." +
                "\r\nTotal number of rolls = " + numRolls + ".\r\n\n";

            // Loop through the array to create a visual representation of the results
            for (int i = 0; i < rollCounts.Length; i++)
            {
                // Calculate the rounded count for display
                int roundedCount = (int)Math.Round(rollCounts[i] * 0.10);

                // Append the total and the visual representation to the return string
                returnString += $"{i + 2}: ";

                for (int j = 0; j < roundedCount; j++)
                {
                    returnString += "*";
                }

                returnString += "\n";
            }

            // Append a closing message to the return string
            returnString += "\nThank you for using the dice throwing simulator. Goodbye!";

            // Return the final result string
            return returnString;
        }
    }
}






