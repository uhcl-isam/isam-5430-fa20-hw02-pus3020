using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.
            string numberForward = "";
            string numberBackward = "";
            int index = 0; 
            Console.Error.WriteLine("Enter a 9 digits number.");
            numberForward = Console.ReadLine();
            while (numberForward.Length == 9)
            {
                Console.Error.WriteLine("Enter a 9 digits number.");
                numberForward = Console.ReadLine();
            }
            index = numberForward.Length - 1;
            while (index >= 0)
            {
                numberBackward += numberForward.Substring(index, 1);
                index--;
            }
            if (numberForward == numberBackward)
            {
                Console.WriteLine("a palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
        }
    }
}
