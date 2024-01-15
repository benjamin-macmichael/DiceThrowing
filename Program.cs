using DiceThrowing;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");

        while (true)
        {
            if (int.TryParse(System.Console.ReadLine(), out int NumberOfRolls))
            {
                int[] output = Dice.DiceRoll(NumberOfRolls);

                PrintHist(output, NumberOfRolls);

                break;
            }
            else
            {
                System.Console.Write("Invalid input. Enter an integer.");
            }
        }
    }

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