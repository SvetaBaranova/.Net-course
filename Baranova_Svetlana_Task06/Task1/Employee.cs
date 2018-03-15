using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User
    {
        private int lengthOfWork;
        private string post;

        public Employee (string name, string middle, string sur, DateTime birth, int length, string p) : 
            base(name, birth, sur, middle)
        {
            LengthOfWork = length;
            Post = p;
        }

        public int LengthOfWork
        {
            get
            {
                return lengthOfWork;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length of work can't be less than 0");
                }
                lengthOfWork = value;
            }
        }

        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Position can't be null or empty");
                }
                post = value;
            }
        }
    }
}
