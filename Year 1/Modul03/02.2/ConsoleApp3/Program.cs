using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var datesdf1 = Console.ReadLine();
            var datedf2 = Console.ReadLine();
            var had = new DateModifier();
            var result = had.TimeDiff(datesdf1, datedf2);
            Console.WriteLine(result);
        }
    }
    class DateModifier
    {
        DateTime date1;

        public DateTime Date1
        {
            get
            {
                return date1;
            }
            set
            {
                date1 = value;
            }
        }
        public int TimeDiff(string date1, string date2)
        {
            DateTime dateafied1 = DateTime.Parse(date1);
            DateTime dateafied2 = DateTime.Parse(date2);
            var modifiedDate = 0;
            if (dateafied1 < dateafied2)
            {
                 modifiedDate = (dateafied2.Date - dateafied1.Date).Days;
            }
            else
            {
                 modifiedDate = (dateafied1.Date - dateafied2.Date).Days;
            }
            return modifiedDate;
        }
    }
}
