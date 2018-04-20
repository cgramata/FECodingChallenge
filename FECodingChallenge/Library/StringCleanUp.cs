using System;

namespace FECodingChallenge.Library
{
    //class that contains method(s) that will help with the clean up of a string
    public class StringCleanUp
    {
        //removes the outer parenthesis of the string 
        public string RemoveOuterParens(string input)
        {
            int inputLength = input.Length;
            string cleanedInput = input;

            //tries to account for scenarios where there are mutliple sets of outer parenthesis
            while (cleanedInput[0].Equals('(') && cleanedInput[inputLength - 1].Equals(')'))
            {
                cleanedInput = cleanedInput.Trim('(',')');
            }
            return cleanedInput;
        }

    }
}
