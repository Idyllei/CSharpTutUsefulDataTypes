using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutUsefuleDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);

            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 00);
            lunchTime = lunchTime.Subtract(new TimeSpan(00, 15, 00));
            lunchTime = lunchTime.Add(new TimeSpan(1, 00, 00));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            Console.ReadLine();
        }
    }
}
