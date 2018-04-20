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
 *  -That the items will always be separated by commas
 */

namespace FECodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DashAssigner dashAssigner = new DashAssigner();
            //(firstname, ideal), throw, ball, accidnet
            //(id,created,employee(id,firstname,employeeType(id), lastname),location)
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
