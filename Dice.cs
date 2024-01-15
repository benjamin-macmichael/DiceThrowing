using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrowing
{
    internal class Dice
    {
        public static int[] DiceRoll(int NumberOfRolls) 
        {
            Random random = new Random();

            int[] output = new int[11];

            for (int iCount = 0; iCount < NumberOfRolls; iCount++) 
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int total = die1 + die2;

                output[total - 2] = output[total - 2] + 1;
            }

            return output;
        }
    }
}
