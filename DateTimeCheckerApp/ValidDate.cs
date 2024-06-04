using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DateTimeCheckerApp
{
    public class ValidDate
    {
        public bool CheckDate(string dayStr, string monthStr, string yearStr)
        {
            string msg = "";

            
            int day, month, year;

            if (string.IsNullOrEmpty(dayStr) || string.IsNullOrEmpty(monthStr) || string.IsNullOrEmpty(yearStr))
            {
                msg = "Please enter all the date fields.";
                MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            try
            {
                day = int.Parse(dayStr);
                month = int.Parse(monthStr);
                year = int.Parse(yearStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (day < 1 || day > 31)
            {
                msg = "Input data for Day is out of range";
                MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (month < 1 || month > 12)
            {
                msg = "Input data for Month is out of range";
                MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (year < 1000 || year > 3000)
            {
                msg = "Input data for Year is out of range";
                MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            //DateTime.Parse($"{day}/{month}/{year}");
            //MessageBox.Show($"{day}/{month}/{year} is correct date time!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            //return true;
            try
            {
                monthStr = month.ToString();
                yearStr = year.ToString();

                DayInMonth dayInMonth = new DayInMonth();
                int daysInMonth = dayInMonth.CheckDayInMonth(monthStr, yearStr);

                if (daysInMonth == -1)
                {
                    return false; // Invalid month
                }
                else if (day < 1 || day > daysInMonth)
                {
                    MessageBox.Show($"{day}/{month}/{year} is not correct date time!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    return false; // Invalid day
                }
                else
                {
                    MessageBox.Show($"{day}/{month}/{year} is correct date time!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    return true; // Valid date
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"{day}/{month}/{year} is not correct date time!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
        }
    }
}
