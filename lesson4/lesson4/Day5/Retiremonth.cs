using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day5
{
    internal class Retiremonth
    {
        public static void FindRetirementDate()
        {
            Console.WriteLine("Enter your date of birth (yyyy/mm/dd)");
            String yearmonthday = String.Empty;
            try
            {

                yearmonthday = $"{Console.ReadLine()}";
                DateTime Dob = DateTime.Parse(yearmonthday);
                DateTime nextMonthDate = Dob.AddYears(60).AddMonths(1);
                DateTime retirementdate=new DateTime(nextMonthDate.Year, nextMonthDate.Month,1).AddDays(-1);

                DateTime retirementdates = nextMonthDate.AddDays(-1);
                Console.WriteLine("your retirement date is" + retirementdates.ToShortDateString());
            }
            catch
            {

            }



            }
    }
}
