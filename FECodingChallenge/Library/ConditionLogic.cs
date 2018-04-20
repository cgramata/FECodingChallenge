using System;
using System.Collections;
using FECodingChallenge.Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FECodingChallenge.Library
{
    public class ConditionLogic
    {
        public int OpenAndCloseParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            string[] splitEntry = input.Split('(');
            string dashes = new String('-', numberOfDashes);
            AddNoneEmptyString(dashes + ' ' + splitEntry[0], resultList);
            //resultList.Add(dashes + ' ' + splitEntry[0]);

            numberOfDashes++;
            dashes = new String('-', numberOfDashes);
            AddNoneEmptyString(dashes + ' ' + splitEntry[1].Trim(')'), resultList);
            //resultList.Add(dashes + ' ' + splitEntry[1].Trim(')'));
            numberOfDashes--;

            return numberOfDashes;
        }

        public int OpenParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            if (numberOfDashes > 0)
            {
                string[] splitEntry = input.Split('(');
                string dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + splitEntry[0], resultList);
                //resultList.Add(dashes + ' ' + splitEntry[0]);

                numberOfDashes++;
                dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + splitEntry[1], resultList);
                //resultList.Add(dashes + ' ' + splitEntry[1]);
            }
            else
            {
                string[] splitEntry = input.Split('(');
                AddNoneEmptyString(splitEntry[0], resultList);
                //resultList.Add(dashes + ' ' + splitEntry[0]);

                numberOfDashes++;
                string dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + splitEntry[1], resultList);
                //resultList.Add(dashes + ' ' + splitEntry[1]);
            }
            return numberOfDashes;
        }

        public int CloseParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            string[] splitEntry = input.Split(')');
            string dashes = new String('-', numberOfDashes);
            AddNoneEmptyString(dashes + ' ' + splitEntry[0], resultList);
            //resultList.Add(dashes + ' ' + splitEntry[0]);

            numberOfDashes--;

            return numberOfDashes;
        }

        public void NoParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            if (numberOfDashes > 0)
            {
                string dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + input, resultList);
                //resultList.Add(dashes + ' ' + input);
            }
            else
            {
                AddNoneEmptyString(input, resultList);
                //resultList.Add(input);
            }
        }

        public void AddNoneEmptyString(string input, ArrayList resultList)
        {
            if (!input.Equals(" "))
            {
                resultList.Add(input);
            }
        }
    }
}
