using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FECodingChallenge.Library;


/*
 * Assumptions:
 *  -That the string can be encapsulated by 0 to many sets of parenthesis
 *  -That the items will always be separated by commas, even it if wasn't...that could be changed in Line 18 of DashAssigner.cs
 *  -That the string input only needs to be changed in the code and not through a console ui
 *  -That the input will always be string and not objects or any other datatype
 *  -That parenthesis will always be used to illustrate the different levels of separations (the number of dashes in before the word)
 */

namespace FECodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DashAssigner dashAssigner = new DashAssigner();

            string input = "(id,created,employee(id,firstname,employeeType(id), lastname),location)";
            ArrayList theList = dashAssigner.IterativePrint(input);

            foreach (string entry in theList)
            {
                Console.WriteLine(entry);
            }

            Console.Read();
        }
    }
}
