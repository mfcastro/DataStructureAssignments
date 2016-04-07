using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class CustomLinkedListString : ICustomString
    {

        Node<char> firstNode;
        Node<char> lastNode;
        int listSize;

        public CustomLinkedListString()
        {
            this.listSize = 0;
            firstNode = null;
        }


        public void PrintNodes()
        {
            Node<char> tempNode = firstNode;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.value);
                tempNode = tempNode.next;
            }
        }


        public void Add(Char letter)
        {
            listSize++;

            Node<char> newNode = new Node<char>(letter);

            if (firstNode == null)
            {
                firstNode = newNode;
            }
            else
            {
                lastNode.next = newNode;
            }
            lastNode = newNode;
        }


        public Node<char> Find(char letter)
        {
            Node<char> current = new Node<char>(letter);
            current = firstNode;

            while (!letter.Equals(current.value) && current.next != null)
            {
                current = current.next;
            }

            return current;

        }

        public void AddAfter(char letterToAddAfter, char letter)
        {
            Node<char> current = Find(letterToAddAfter);
            Node<char> newNode = new Node<char>(letter);

            newNode.next = current.next;
            current.next = newNode;
        }


        public override string ToString()
        {
            string newString = "";

            Node<char> current = firstNode;

            while (current != null)
            {
                newString += current.value;
                current = current.next;
            }
            return newString;

        }

        public void Insert(int startIndex, string stringToInsert)
        {
            string startWord = ToString();

            char[] stringToChar = stringToInsert.ToCharArray();

            char lastChar = startWord[startIndex];


            for (int i = 0; i < stringToChar.Length; i++)
            {
                AddAfter(lastChar, stringToChar[i]);
                lastChar = stringToChar[i];
                startIndex++;
            }
        }


        public int length()
        {
            int lengthCounter = 0;

            Node<char> current = firstNode;

            while (current != null)
            {
                lengthCounter++;
                current = current.next;
            }

            return lengthCounter;

        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            for (int i = 0; i < numCharsToRemove; i++)
            {
                if (startIndex == 1)
                {
                    firstNode = firstNode.next;

                }
                else if (startIndex > 1 && startIndex <= listSize)
                {
                    Node<char> current = firstNode;

                    Node<char> tempLastNode = null;
                    int count = 0;

                    while (current != null)
                    {
                        if (count == startIndex - 1)
                        {
                            tempLastNode.next = current.next;
                        }
                        count++;

                        tempLastNode = current;
                        current = current.next;
                    }
                }
            }


        }

    }
}
