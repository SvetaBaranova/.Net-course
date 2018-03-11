using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            User me = new User();
            me.Name = "Света";
            me.Surname = "Baranova";
            me.MiddleName = "Nikolaevna";
            me.Age = 18;
            me.BirthDay = DateTime.Parse("08.04.2098");
            Console.WriteLine($"{me.Name}, {me.Surname}, {me.MiddleName}, {me.Age}, {me.BirthDay}");
            Console.ReadKey();
        }
    }
}
