using System;
using System.Collections;
using System.Linq;
using FECodingChallenge.Library;

namespace FECodingChallenge.Library
{
    public class DashAssigner
    {

        public ArrayList IterativePrint(string input)
        {
            int numberOfDashes = 0;
            string cleanedInput = input.Replace(" ", "");
            cleanedInput = StringCleanUp.RemoveOuterParens(cleanedInput);
            string[] splitInput = cleanedInput.Split(',');
            ArrayList resultList = new ArrayList();

            ConditionLogic conditionLogic = new ConditionLogic();

            foreach (string entry in splitInput)
            {
                string trimmedEntry = entry.Trim(' ');

                //condition if the string has both '(' and ')'
                if (trimmedEntry.Contains('(') && trimmedEntry.Contains(')'))
                {
                  
                   numberOfDashes = conditionLogic.OpenAndCloseParenLogic(trimmedEntry, numberOfDashes, resultList);
                }
                //condition if the string only has '('
                if (trimmedEntry.Contains('(') && !trimmedEntry.Contains(')'))
                {
                    numberOfDashes = conditionLogic.OpenParenLogic(trimmedEntry, numberOfDashes, resultList);
                }
                //condition if the string only has ')'
                if (trimmedEntry.Contains(')') && !trimmedEntry.Contains('('))
                {
                    numberOfDashes = conditionLogic.CloseParenLogic(trimmedEntry, numberOfDashes, resultList);
                }
                //condition if the string has no parenthesis
                if (!trimmedEntry.Contains('(') && !trimmedEntry.Contains(')'))
                {
                    conditionLogic.NoParenLogic(trimmedEntry, numberOfDashes, resultList);
                }
            }
            return resultList;
        }
    }
}
