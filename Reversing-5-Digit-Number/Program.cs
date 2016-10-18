using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_5_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse5DigitNumber();
        }

        /// <summary>
        /// Write a program to reverse a 5 digit number input by the user
        /// </summary>

        static void Reverse5DigitNumber()
        {
            int number = 0;
            Console.WriteLine("Please input a 5 digit number");
            number = Convert.ToInt32(Console.ReadLine());

            int[] arrDigits = new int[5];

            for(int i = 0; i <= arrDigits.Length - 1; i++)
            {
                if (i < arrDigits.Length - 1)
                {
                    arrDigits[i] = number % 10;
                    number = number - arrDigits[i];
                    number = number / 10;
                } else if (i == arrDigits.Length - 1)
                {
                    arrDigits[i] = number;
                }
                
            }

            
            for (int i = 0; i < arrDigits.Length; i++)
            {
                Console.WriteLine(arrDigits[i]);
            }
        }
    }
}
