using System;
using System.Collections.Generic;

namespace PayOutProgram
{
    public class PayOutProgram
    {
       
        public static void Main(string[] args)
        {

            IPayOut pay = new PayOut();

            List<int> notes = new List<int>();
            List<int> amounts = new List<int>() { 10, 50, 100 };


            Console.WriteLine("Pay Out Amount(possible combinations) : 30");
            pay.CalculatePayOut(notes, amounts, 0, 0, 30);

            Console.WriteLine("Pay Out Amount(possible combinations) : 50");
            pay.CalculatePayOut(notes, amounts, 0, 0, 50);

            Console.WriteLine("Pay Out Amount(possible combinations) : 60");
            pay.CalculatePayOut(notes, amounts, 0, 0, 60);

            Console.WriteLine("Pay Out Amount(possible combinations) : 80");
            pay.CalculatePayOut(notes, amounts, 0, 0, 80);

            Console.WriteLine("Pay Out Amount(possible combinations) : 140");
            pay.CalculatePayOut(notes, amounts, 0, 0, 140);

            Console.WriteLine("Pay Out Amount(possible combinations) : 230");
            pay.CalculatePayOut(notes, amounts, 0, 0, 230);

            Console.WriteLine("Pay Out Amount(possible combinations) : 370");
            pay.CalculatePayOut(notes, amounts, 0, 0, 370);

            Console.WriteLine("Pay Out Amount(possible combinations) : 610");
            pay.CalculatePayOut(notes, amounts, 0, 0, 610);

            Console.WriteLine("Pay Out Amount(possible combinations) : 980");
            pay.CalculatePayOut(notes, amounts, 0, 0, 980);

            Console.ReadLine();
        }
       
    }
}

