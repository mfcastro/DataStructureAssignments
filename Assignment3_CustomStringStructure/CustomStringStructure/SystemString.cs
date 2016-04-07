using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class SystemString : ICustomString
    {
        string initializedString;

        public SystemString(string initializedString)
        {
            this.initializedString = initializedString;
        }

        public override string ToString()
        {
            return initializedString.ToString();
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            initializedString.Insert(startIndex, stringToInsert);
        }

        public int length()
        {
            return initializedString.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            initializedString.Remove(startIndex, numCharsToRemove);
        }

    }
}
