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

            numberOfDashes++;
            dashes = new String('-', numberOfDashes);
            AddNoneEmptyString(dashes + ' ' + splitEntry[1].Trim(')'), resultList);
            numberOfDashes--;

            return numberOfDashes;
        }

        public int OpenParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            string[] splitEntry = input.Split('(');
            
            if (numberOfDashes > 0)
            {
                string dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + splitEntry[0], resultList);

                numberOfDashes++;
                dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + splitEntry[1], resultList);
            }
            else
            {
                AddNoneEmptyString(splitEntry[0], resultList);

                numberOfDashes++;
                string dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + splitEntry[1], resultList);
            }
            return numberOfDashes;
        }

        public int CloseParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            string[] splitEntry = input.Split(')');
            string dashes = new String('-', numberOfDashes);
            AddNoneEmptyString(dashes + ' ' + splitEntry[0], resultList);

            numberOfDashes--;

            return numberOfDashes;
        }

        public void NoParenLogic(string input, int numberOfDashes, ArrayList resultList)
        {
            if (numberOfDashes > 0)
            {
                string dashes = new String('-', numberOfDashes);
                AddNoneEmptyString(dashes + ' ' + input, resultList);
            }
            else
            {
                AddNoneEmptyString(input, resultList);
            }
        }

        public void AddNoneEmptyString(object input, ArrayList resultList)
        {
            if (input.Equals(string.Empty) == false)
            {
                resultList.Add(input);
            }
        }
    }
}
