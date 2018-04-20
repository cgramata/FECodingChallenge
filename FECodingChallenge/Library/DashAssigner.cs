using System;
using System.Collections;
using System.Linq;
using FECodingChallenge.Library;


namespace FECodingChallenge.Library
{
    public class DashAssigner
    {
        /*
        * Assigns the number of dashes in front of the word
        * param: string input
        */
        public ArrayList IterativePrint(string input)
        {
            StringCleanUp stringCleanUp = new StringCleanUp();

            //Cleans the input string up
            //Note: replacing the spaces only needed one line of code, separate method was not needed
            string cleanedInput = input.Replace(" ", "");
            cleanedInput = stringCleanUp.RemoveOuterParens(cleanedInput);

            int numberOfDashes = 0;
            
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
