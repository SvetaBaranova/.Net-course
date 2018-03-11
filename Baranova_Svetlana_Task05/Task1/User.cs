using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string name;
        private string surname;
        private string middleName;
        private int age;
        private DateTime birthDay;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty or null");
                }
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Surname can't be empty or null");
                }
                surname = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name can't be empty or null");
                }
                middleName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be less that 0");
                }
                age = value;
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return birthDay.Date;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Date of birth can't be in the future");
                }
                birthDay = value;
            }
        }
    }
}
