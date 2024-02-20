using System;
using System.Collections.Generic;
using System.Linq;

namespace PayOutProgram
{
    public class PayOut: IPayOut
    {
        public void CalculatePayOut(List<int> cartridges, List<int> amounts, int highest, int sum, int payOutAmount)
        {

            if (sum == payOutAmount)
            {
                Print(cartridges, amounts);
                return;
            }

            if (sum > payOutAmount)
            {
                return;
            }

            foreach (int value in amounts)
            {
                if (value >= highest)
                {
                    List<int> cartridge = new List<int>(cartridges);
                    cartridge.Add(value);
                    this.CalculatePayOut(cartridge, amounts, value, sum + value, payOutAmount);
                }
            }
        }
        void Print(List<int> cartridge, List<int> amounts)
        {
            foreach (int amount in amounts)
            {
                int count = cartridge.Count(value => value == amount);
                Console.WriteLine("{0}: {1}", amount, count);
            }
            Console.WriteLine();
        }
    }
}
