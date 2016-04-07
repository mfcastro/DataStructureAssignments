using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemString myTestString = new SystemString("One to many words");

            SystemArrayString testArray = new SystemArrayString("devCodeCamp");
            SystemArrayString testArray2 = new SystemArrayString(new[] { 'a', 'b', 'c' });

            SystemLinkedListString linkedList = new SystemLinkedListString("Link Link");

            CustomLinkedListString customLinkedListBuilder = new CustomLinkedListString();

            customLinkedListBuilder.Add('m');
            customLinkedListBuilder.Add('a');
            customLinkedListBuilder.Add('r');
            customLinkedListBuilder.Add('c');
            customLinkedListBuilder.Add('o');

            SortedList<int, ICustomString> sortedStringList = new SortedList<int, ICustomString>();

            sortedStringList.Add(customLinkedListBuilder.length(), customLinkedListBuilder);
            sortedStringList.Add(myTestString.length(), myTestString);
            sortedStringList.Add(testArray.length(), testArray);
            sortedStringList.Add(linkedList.length(), linkedList);
            sortedStringList.Add(testArray2.length(), testArray2);

            foreach (KeyValuePair<int, ICustomString> x in sortedStringList)
            {
                Console.WriteLine("Length: {0}, String: {1}", x.Key, x.Value);
            }

            Console.ReadLine();

        }
    }
}
