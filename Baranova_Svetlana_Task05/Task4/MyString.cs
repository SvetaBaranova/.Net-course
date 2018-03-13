using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char[] line;

        public MyString(char[] line)
        {
            this.line = line;
        }

        public static MyString operator + (MyString line1, MyString line2)
        {
            string lineOne = line1.ToString();
            string lineTwo = line2.ToString();
            lineOne += lineTwo;
            return new MyString (lineOne.ToArray());
        }

        public static MyString operator - (MyString line1, MyString line2)
        {
            string lineOne = line1.ToString();
            string lineTwo = line2.ToString();
            lineOne = lineOne.Replace(lineTwo, string.Empty);
            return new MyString(lineOne.ToArray());
        }

        public static bool operator == (MyString line1, MyString line2)
        {
            string lineOne = line1.ToString();
            string lineTwo = line2.ToString();
            return lineOne.Equals(lineTwo);
        }

        public static bool operator != (MyString line1, MyString line2)
        {
            return !(line1 == line2);
        }


        public override string ToString()
        {
            return new string(line);
        }
        public override bool Equals(object obj)
        {
            var @str = obj as MyString;
            if (@str != null)
            {
                return @str == this;
            }
            return false;
        }
    }
}
