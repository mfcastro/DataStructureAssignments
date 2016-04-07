using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class SystemLinkedListString : ICustomString
    {
        public LinkedList<char> linkedList = new LinkedList<char>();
        int listSize;
        string startWord;

        public SystemLinkedListString(string startWord)
        {
            this.startWord = startWord;

            this.listSize = startWord.Length;

            for (int i = 0; i < startWord.Length; i++)
            {
                if (i == 0)
                {
                    linkedList.AddFirst(startWord[i]);
                }
                else
                {
                    linkedList.AddLast(startWord[i]);
                }
            }
        }

        public override string ToString()
        {
            string newString = "";

            foreach (char x in linkedList)
            {
                newString += x;
            }

            return newString;
        }


        public void Insert(int startIndex, string stringToInsert)
        {
            char[] stringToChar = stringToInsert.ToCharArray();

            char lastChar = startWord[startIndex];

            for (int i = 0; i < stringToChar.Length; i++)
            {
                LinkedListNode<char> node = linkedList.Find(lastChar);
                linkedList.AddAfter(node, stringToChar[i]);
                lastChar = stringToChar[i];
            }

            startWord = ToString();            
        }

        public int length()
        {
            int lengthCounter = 0;

            foreach (char x in linkedList)
            {
                lengthCounter++;
            }

            return lengthCounter;
        }


        public void Remove(int startIndex, int numCharsToRemove)
        {
            for (int i = 0; i < numCharsToRemove; i++)
            {
                linkedList.Remove(startWord[startIndex - 1]);

                startIndex++;
            }

        }
    }
}
