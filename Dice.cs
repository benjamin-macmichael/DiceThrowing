using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrowing
{
    internal class Dice
    {
        //receive the number of rolls as a parameter for this method
        public static int[] DiceRoll(int NumberOfRolls) 
        {
            //create an instance of the system's random class that we'll use below to roll the dice
            Random random = new Random();

            //the array that keeps track of the roll outcomes
            int[] output = new int[11];

            //this loop rolls the 2 dice however many times the user input to roll
            for (int iCount = 0; iCount < NumberOfRolls; iCount++) 
            {
                //rolls each die
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int total = die1 + die2;

                //adjusts the array accordingly, we use -2 since position 0 in the array is 2 and position 10 is 12
                output[total - 2] = output[total - 2] + 1;
            }

            return output;
        }
    }
}
