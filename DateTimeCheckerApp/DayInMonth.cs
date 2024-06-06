using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCheckerApp
{
    public class DayInMonth
    {
        public int CheckDayInMonth(string monthStr, string yearStr)
        {
            int month = int.Parse(monthStr);
            int year = int.Parse(yearStr);
            int result = -1;
            int[] thirty_one = { 1, 3, 5, 7, 8, 10, 12 };
            int[] thirty = { 4, 6, 9, 11 };

            if (Array.IndexOf(thirty_one, month) != -1)
            {
                result = 31;
            }

            if (Array.IndexOf(thirty, month) != -1)
            {
                result = 30;
            }

            if (month == 2)
            {
                if (year % 400 == 0)
                {
                    result = 29;
                }
                else if (year % 100 == 0)
                {
                    result = 28;
                }
                else if (year % 4 == 0)
                {
                    result = 29;
                }
                else
                {
                    result = 28;
                }
            }
            return result;
        }
    }
}
