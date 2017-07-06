using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prompt the user to enter an integer from 1 to 10
 * Display the factorial of the umber enetered by the user.
 * Ask if the user wants to continue
 * */


namespace CsLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean cont = true;

            long output = 1;
            while (cont)
            {
                Console.WriteLine("Calculate the factorial of a number!");
                int factNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= factNum; i++)
                {
                    output = i * output;
                    Console.WriteLine(output);
                }
            }
        }
    }
}
