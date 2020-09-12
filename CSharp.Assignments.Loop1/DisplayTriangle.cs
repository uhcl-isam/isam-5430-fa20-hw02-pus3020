using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {
        public static void Main()
        {
            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());

            // Write your codes here.
            Console.ReadLine();
            for (int rowA = 0; rowA < n; rowA++)
            {
                for (int columnA = 0; columnA < rowA; columnA++)
                {
                    Console.Write(t);
                }
            }
            for (int rowB = 0; rowB < n; rowB++)
            {
                for (int columnB = 0; columnB < rowB; columnB++)
                {
                    Console.Write(" ");
                }
                for (int columnB = 0; columnB < n - rowB; columnB++)
                {
                    Console.Write(t);
                }
            }
            for (int rowC = n; rowC > 0; rowC--)
            {
                for (int columnC = 0; columnC < rowC; columnC++)
                {
                    Console.Write(t);
                }
            }
            for (int rowD = n; rowD > 0; rowD--)
            {
                for (int columnD = 0; columnD < rowD; columnD++)
                {
                    Console.Write(" ");
                }
                for (int columnD = 0; columnD < n - rowD; columnD++)
                {
                    Console.Write(t);
                }
            }
        }
    }
}
