﻿using System;
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

        public string MiddleName { get; set; }

        public int Age
        {
            get
            {
                int age = 0;
                if (DateTime.Today.Month>BirthDay.Month)
                {
                    return (DateTime.Today.Year-BirthDay.Year);
                }
                else if (DateTime.Today.Day<BirthDay.Day)
                {
                    return (DateTime.Today.Year - BirthDay.Year - 1);
                }
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
