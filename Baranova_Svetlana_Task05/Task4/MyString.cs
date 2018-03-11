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
            Line = line;
        }
        public char[] Line
        {
            get
            {
                return line;
            }
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new ArgumentException("String can't be empty");
                }
                line = value.ToArray();
            }
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
            lineOne = lineOne.Replace(lineTwo, "");
            return new MyString(lineOne.ToArray());
        }
        public static bool operator == (MyString line1, MyString line2)
        {
            if (line1.Line.Length != line2.Line.Length)
            {
                return false;
            }
            else
            {
                bool flag = false;
                for (int i = 0; i < line1.Line.Length; i++)
                {
                    if (line1.Line[i] == line2.Line[i])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                return flag;
            }
        }
        public static bool operator != (MyString line1, MyString line2)
        {
            if (line1.Line.Length != line2.Line.Length)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < line1.Line.Length; i++)
                {
                    if (line1.Line[i] != line2.Line[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public override string ToString()
        {
            return new string (Line);
        }
    }
}
