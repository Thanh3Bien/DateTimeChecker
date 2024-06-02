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

            try
            {
                int day = int.Parse(dayStr);
                int month = int.Parse(monthStr);
                int year = int.Parse(yearStr);

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

                DateTime.Parse($"{day}/{month}/{year}");
                MessageBox.Show($"{day}/{month}/{year} is correct date time!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            catch (Exception ex)
            {
                int day = int.Parse(dayStr);
                int month = int.Parse(monthStr);
                int year = int.Parse(yearStr);
                MessageBox.Show($"{day}/{month}/{year} is not correct date time!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
        }
    }
}
