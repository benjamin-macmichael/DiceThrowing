﻿using DiceThrowing;

internal class Program
{
    private static void Main(string[] args)
    {
        // Greeting/Prompt
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");

        //Loop that checks if user input an integer
        while (true)
        {   
            //If user input a valid integer, then it gets assigned to a variable
            if (int.TryParse(System.Console.ReadLine(), out int NumberOfRolls))
            {   
                //pass the Number of rolls to the method in our Dice class and assign what is returned to output
                int[] output = Dice.DiceRoll(NumberOfRolls);

                //pass the output and the initial number of rolls to the PrintHist method
                PrintHist(output, NumberOfRolls);

                break;
            }
            //If not a number, the system lets the user know and gives them another chance to enter an integer
            else
            {
                System.Console.Write("Invalid input. Enter an integer.");
            }
        }
    }

    //This is the method that shows the user the histogram and stats associated with the number of rolls they chose
    private static void PrintHist(int[] output, int NumberOfRolls)
    {
        System.Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = {NumberOfRolls}.\n");

        for (int iCount = 0; iCount < output.Length; iCount++)
        {
            int percentage = output[iCount] * 100 / NumberOfRolls;
            System.Console.WriteLine($"{iCount + 2}: {new string('*', percentage)}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}