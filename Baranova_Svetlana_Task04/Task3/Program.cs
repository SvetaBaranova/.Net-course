using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void ComparingCulture(CultureInfo firstCul, CultureInfo secondCul)
        {
            Console.WriteLine("Comparing of culture:");
            Console.WriteLine("Name:\n{0, 15}|{1, 15}", firstCul.DisplayName, secondCul.DisplayName);
            NumberFormatInfo num1 = firstCul.NumberFormat;
            NumberFormatInfo num2 = secondCul.NumberFormat;
            Console.WriteLine("Decimal separator:\n{0, 15}|{1, 15}", num1.CurrencyDecimalSeparator, num2.CurrencyDecimalSeparator);
            Console.WriteLine("Group separator:\n{0, 15}|{1, 15}", num1.CurrencyGroupSeparator, num2.CurrencyGroupSeparator);
            Console.WriteLine("Currency symbol:\n{0, 15}|{1, 15}", num1.CurrencySymbol, num2.CurrencySymbol);
            DateTimeFormatInfo date1 = firstCul.DateTimeFormat;
            DateTimeFormatInfo date2 = secondCul.DateTimeFormat;
            Console.WriteLine("Date:\n{0, 15}|{1, 15}", date1.ShortDatePattern, date2.ShortDatePattern);
            Console.WriteLine("Time:\n{0, 15}|{1, 15}", date1.ShortTimePattern, date2.ShortTimePattern);
            Console.WriteLine("First day of week:\n{0, 15}|{1, 15}", date1.FirstDayOfWeek, date2.FirstDayOfWeek);
        }
        static void Main(string[] args)
        {
            CultureInfo[] allCulture = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo ci in allCulture)
            {
                Console.WriteLine("{0}", ci.Name);
            }
            string s;
            Console.WriteLine("Write first culture");
            s = Console.ReadLine();
            CultureInfo firstCulture = new CultureInfo(s);
            Console.WriteLine("Write second culture");
            s = Console.ReadLine();
            CultureInfo secondCulture = new CultureInfo(s);
            ComparingCulture(firstCulture, secondCulture);
            Console.ReadKey();
        }
    }
}
