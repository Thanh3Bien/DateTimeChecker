using System.Windows;

namespace DateTimeCheckerApp.UnitTests
{
    public class ValidDateTests
    {
        private ValidDate _validDate;
        [SetUp]
        public void Setup()
        {
            _validDate = new ValidDate();
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