import tkinter as tk
from tkinter import messagebox
from DayInMonth import DayInMonth


class ValidDate:
    def __init__(self): self.day_in_month = DayInMonth()
    def check_date(self, day_str, month_str, year_str):
        try:
            day = int(day_str)
            month = int(month_str)
            year = int(year_str)
        except ValueError:
            messagebox.showerror("Invalid Input", "Invalid input format.")
            return False
        
        if day < 1 or day > 31:
            messagebox.showerror("Invalid Input", "Input data for Day is out of range")
            return False
        if month < 1 or month > 12:
            messagebox.showerror("Invalid Input", "Input data for Month is out of range")
            return False
        if year < 1000 or year > 3000:
            messagebox.showerror("Invalid Input", "Input data for Year is out of range")
            return False
        
        try:
            day_in_month = DayInMonth().check_day_in_month(month_str, year_str)
            if day_in_month == -1:
                return False  # Invalid month
            elif day < 1 or day > day_in_month:
                messagebox.showerror("Invalid Date", f"{day}/{month}/{year} is not correct date time!")
                return False  # Invalid day
            else:
                messagebox.showinfo("Valid Date", f"{day}/{month}/{year} is correct date time!")
                return True  # Valid date
        except Exception as e:
            messagebox.showerror("Invalid Date", f"{day}/{month}/{year} is not correct date time!")
            return False




