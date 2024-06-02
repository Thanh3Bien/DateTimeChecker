using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DateTimeCheckerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void CheckDate_Click(object sender, RoutedEventArgs e)
        {
            ValidDate _dateTimeChecker = new ValidDate();
            string dayStr = txtDay.Text;
            string monthStr = txtMonth.Text;
            string yearStr = txtYear.Text;


            bool isValidDate = _dateTimeChecker.CheckDate(dayStr, monthStr, yearStr);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDay.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtYear.Text = string.Empty;
        }

        private void CheckDayInMonth_Click(object sender, RoutedEventArgs e)
        {
            DayInMonth dayInMonths = new DayInMonth();
            txtDay.Text = string.Empty;
            string monthStr = txtMonth.Text;
            string yearStr = txtYear.Text;
            if (string.IsNullOrEmpty(monthStr) || string.IsNullOrEmpty(yearStr))
            {
                string msg = "Please enter all the date fields.";
                MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            int DayInMonth = dayInMonths.CheckDayInMonth(monthStr, yearStr);
            MessageBox.Show($"{DayInMonth}", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}