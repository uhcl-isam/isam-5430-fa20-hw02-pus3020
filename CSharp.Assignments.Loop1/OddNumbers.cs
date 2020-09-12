using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            int numberStart = int.Parse(Console.ReadLine());
            Console.Error.WriteLine("Enter the ending number");
            // Codes to enter end.
            int numberEnd = int.Parse(Console.ReadLine());
            int number = 0;
            if (numberStart > numberEnd)
            {
                for (number = numberStart; number <= numberEnd; number++)
                {
                    if (number % 2 == 1)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
            else if (numberEnd > numberStart)
            {
                for (number = numberEnd; number <= numberStart; number--)
                {
                    if (number % 2 == 1)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
