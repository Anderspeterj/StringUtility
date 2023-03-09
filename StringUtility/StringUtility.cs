using Microsoft.VisualBasic.FileIO;

namespace StringUtility
{
    public class StringUtility
    {


        public int CountOccourences(string stringToCheck, string stringToFind)
        {
            var stringAsCharArray = stringToCheck.ToLower().ToCharArray();
            var stringToCCheckForAsChar = stringToFind[0];
            var occuranceCount = 0;
            

            for (var characterIndex = 0; characterIndex < stringAsCharArray.Length; characterIndex++) 
            {

                if (stringAsCharArray[characterIndex] == stringToCCheckForAsChar) 
                { 
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }
    }
}