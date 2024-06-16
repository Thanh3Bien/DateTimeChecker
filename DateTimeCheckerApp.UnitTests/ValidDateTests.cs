using System.Windows;

namespace DateTimeCheckerApp.UnitTests
{
    public class ValidDateTests
    {
        private ValidDate _validDate;
        private DayInMonth dayInMonth;
        [SetUp]
        public void Setup()
        {
            _validDate = new ValidDate();
            dayInMonth = new DayInMonth();
        }

        [TestCase("", "12", "2018")]
        public void DateCheckerTests_IsNull(string dayStr, string monthStr, string yearStr)
        {


            //Act
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            //Assert
            Assert.That(isValid, Is.EqualTo(false));
            Assert.That(GetLastMessageBoxText(), Is.EqualTo($"Please enter all the date fields."));
        }

        [TestCase("32", "12", "2020")]
        public void DateCheckerTests_DayRange(string dayStr, string monthStr, string yearStr)
        {


            //Act
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            //Assert
            Assert.That(isValid, Is.EqualTo(false));
            //Assert.That(GetLastMessageBoxText(), Is.EqualTo($"Please enter all the date fields."));
        }

        //Assign
        [TestCase("28", "02", "2018")]
        public void DateCheckerTests_ValidDate(string dayStr, string monthStr, string yearStr)
        {
            

            //Act
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            //Assert
            Assert.That(isValid, Is.EqualTo(true));
        }



        [TestCase("5", "2024")] // Using a 31-day month
        public void TestDayInMonth_1(string monthStr, string yearStr)
        {
            // Call the method and parse in the given month+year and put the return value in a variable
            int returnValue = dayInMonth.CheckDayInMonth(monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(returnValue, Is.EqualTo(31));
        }

        [TestCase("2", "2020")] // Using February in leap year
        public void TestDayInMonth_2(string monthStr, string yearStr)
        {
            // Call the method and parse in the given month+year, save return value in a variable
            int returnValue = dayInMonth.CheckDayInMonth(monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(returnValue, Is.EqualTo(29));
        }

        [TestCase("9", "2025")] // Using a 30-day month
        public void TestDayInMonth_3(string monthStr, string yearStr)
        {
            // Call the method and parse in the given month+year, save return value in a variable
            int returnValue = dayInMonth.CheckDayInMonth(monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(returnValue, Is.EqualTo(30));
        }

        [TestCase("1", "10")] // Using small year number
        public void TestDayInMonth_4(string monthStr, string yearStr)
        {
            // Call the method and parse in the given month+year, save return value in a variable
            int returnValue = dayInMonth.CheckDayInMonth(monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(returnValue, Is.EqualTo(31));
        }

        [TestCase("12", "2022")] // Need to change
        public void TestDayInMonth_5(string monthStr, string yearStr)
        {
            // Call the method and parse in the given month+year, save return value in a variable
            int returnValue = dayInMonth.CheckDayInMonth(monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(returnValue, Is.EqualTo(31));
        }

        [TestCase("2", "2025")] // Using February in non-leap year
        public void TestDayInMonth_6(string monthStr, string yearStr)
        {
            // Call the method and parse in the given month+year, save return value in a variable
            int returnValue = dayInMonth.CheckDayInMonth(monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(returnValue, Is.EqualTo(28));
        }

        /// <summary>
        /// Check if CheckDate method correctly return whether the inputted date (dd/mm/yyyy)
        /// exist or not.
        /// </summary>
        /// <param name="dayStr">Represent the day</param>
        /// <param name="monthStr">Represent the month</param>
        /// <param name="yearStr">Represent the year</param>

        [TestCase("29", "2", "2024")] // Using a valid leap year date
        public void CheckDate_1(string dayStr, string monthStr, string yearStr)
        {
            // Call the method and parse in the given dd/mm/yyyy, save return value in a variable
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(isValid, Is.EqualTo(true));
        }

        [TestCase("30", "3", "1914")] // Using an valid date
        public void CheckDate_2(string dayStr, string monthStr, string yearStr)
        {
            // Call the method and parse in the given dd/mm/yyyy, save return value in a variable
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(isValid, Is.EqualTo(true));
        }

        [TestCase("29", "2", "2023")] // Using an invalid day (29) for a non-leap year
        public void CheckDate_3(string dayStr, string monthStr, string yearStr)
        {
            // Call the method and parse in the given dd/mm/yyyy, save return value in a variable
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(isValid, Is.EqualTo(false));
        }

        [TestCase("28", "2", "2025")] // Using a valid non-leap year date
        public void CheckDate_4(string dayStr, string monthStr, string yearStr)
        {
            // Call the method and parse in the given dd/mm/yyyy, save return value in a variable
            var isValid = _validDate.CheckDate(dayStr, monthStr, yearStr);
            // Check if the variable match the expected result
            Assert.That(isValid, Is.EqualTo(true));
        }



        private string? GetLastMessageBoxText()
        {
            // Code để lấy nội dung của MessageBox cuối cùng được hiển thị
            // Ví dụ sử dụng Windows Presentation Foundation (WPF)
            // Chưa nghĩ ra cách lấy cho từng test case
            return Application.Current.Windows
                .OfType<Window>()
                .LastOrDefault(w => w is MessageBox)
                ?.Content
                ?.ToString();
        }


    }
}