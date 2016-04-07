using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class SystemArrayString : ICustomString
    {
        char[] initializedArray;

        public SystemArrayString(string initializedString)
        {
            this.initializedArray = initializedString.ToCharArray();
            
        }

        public SystemArrayString(char [] initializedArray)
        {
            this.initializedArray = initializedArray;
        }

        public override string ToString()
        {
             return new string(initializedArray);
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            char[] newArrayToPutMerges;
            
            char[] newStringToInsert = stringToInsert.Trim().ToCharArray();
            int newArrayLength = newStringToInsert.Length + initializedArray.Length;

            newArrayToPutMerges = new char[newArrayLength];

            for(int i = 0; i < startIndex; i++)
            {
                newArrayToPutMerges[i] = initializedArray[i];
            }

            for (int i = 0; i < newStringToInsert.Length; i++)
            {
                newArrayToPutMerges[startIndex + i] = newStringToInsert[i];
            }

            int endIndex = startIndex + newStringToInsert.Length;

            for (int i = startIndex; i < initializedArray.Length; i++)
            {
                newArrayToPutMerges[endIndex] = initializedArray[i];
                endIndex++;
            }
        }

        public int length()
        {
           return initializedArray.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] newArrayToPutMerges;

           
            int newArrayLength =  initializedArray.Length - numCharsToRemove;

            newArrayToPutMerges = new char[newArrayLength];

            int counter = 0;


            for (int i = 0; i < startIndex; i++)
            {
                newArrayToPutMerges[i] = initializedArray[i];
                counter++;
            }

            int endIndex = startIndex + numCharsToRemove;

            for (int i = endIndex; i < initializedArray.Length; i++)
            {
                newArrayToPutMerges[counter] = initializedArray[endIndex];
            }

            
        }
    }
}
