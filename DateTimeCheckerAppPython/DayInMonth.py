class DayInMonth:
    def check_day_in_month(self, month_str, year_str):
        month = int(month_str)
        year = int(year_str)
        thirty_one = [1, 3, 5, 7, 8, 10, 12]
        thirty = [4, 6, 9, 11]
        
        if month in thirty_one:
            return 31
        elif month in thirty:
            return 30
        elif month == 2:
            if year % 400 == 0:
                return 29
            elif year % 100 == 0:
                return 28
            elif year % 4 == 0:
                return 29
            else:
                return 28
        else:
            return -1




