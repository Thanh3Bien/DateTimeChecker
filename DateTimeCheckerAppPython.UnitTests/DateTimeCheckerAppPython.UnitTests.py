import unittest
# Add references to the main project first to use this
from DateTimeCheckerAppPython import DayInMonth, ValidDate
                        
class TestValidDate(unittest.TestCase):
    def setUp(self):
        self.valid_date = ValidDate()

    def tearDown(self):
        del self.valid_date
    
    def test_is_valid_date(self):
        result = self.valid_date.check_date(30, 3, 1914)
        self.assertTrue(result)

    def test_invalid_date(self):
        result = self.valid_date.check_date(29, 2, 2023)
        self.assertFalse(result)
        
    def test_valid_leap_year(self):
        result = self.valid_date.check_date(29, 2, 2024)
        self.assertTrue(result)
     
    def test_out_of_boundary(self):
        result = self.valid_date.check_date(12, 2, 999)
        self.assertFalse(result)  
        
    def test_empty_day_input(self):
        result = self.valid_date.check_date("", 3, 2025)
        self.assertFalse(result) 
        
class TestDayInMonth(unittest.TestCase):
    def setUp(self):
        self.day_in_month = DayInMonth()

    def tearDown(self):
        del self.day_in_month
           
    def test_check_day_in_month_1(self):
        result = self.day_in_month.check_day_in_month(3, 2024)
        self.assertEqual(result, 31)

    def test_check_day_in_month_2(self):
        result = self.day_in_month.check_day_in_month(9, 2025)
        self.assertEqual(result, 30)
        
    def test_check_non_leap_year(self):
        result = self.day_in_month.check_day_in_month(2, 2025)
        self.assertEqual(result, 28)
        
    def test_check_leap_year(self):
        result = self.day_in_month.check_day_in_month(2, 2020)
        self.assertEqual(result, 29)
        
    def test_check_invalid_format(self): # Expected to Error
        result = self.day_in_month.check_day_in_month("xyz", 2025)
        self.assertEqual(result, -1)
        # with self.assertRaises(ValueError):
        #     result = self.day_in_month.check_day_in_month("xyz", 2025)
               
    # @unittest.skip("Demonstrating skipping a test")
    def test_check_empty_input(self): # Expected to Error
        result = self.day_in_month.check_day_in_month("", 2025)
        self.assertEqual(result, -1)
       
    # @unittest.expectedFailure    
    def test_check_out_of_boundary(self): # Expected to fail
        result = self.day_in_month.check_day_in_month(13, 2025)
        self.assertEqual(result, 1) # Should return -1
        
def suite():
    suite = unittest.TestSuite()
    suite.addTest(TestDayInMonth('test_check_non_leap_year'))
    suite.addTest(TestDayInMonth('test_check_leap_year'))
    return suite

if __name__ == '__main__':
    unittest.main()
    # runner = unittest.TextTestRunner()
    # runner.run(suite())
