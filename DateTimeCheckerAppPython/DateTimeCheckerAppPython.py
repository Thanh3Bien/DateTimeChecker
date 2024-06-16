import base64
import tkinter as tk
from DayInMonth import DayInMonth
from ValidDate import ValidDate
class MainWindow(tk.Tk):
    def __init__(self):
        # self.day_in_month = DayInMonth()
        # self.valid_date = ValidDate()
        super().__init__()
        self.title("Date Time Checker App")
        self.geometry("400x300")

        # Load the image
        # self.image = tk.PhotoImage(file="C:/Users/ADMIN\Documents/Summer2024/SWT/Labs/Labs/z5496230814142_b156eeade2dd618cf6cac9abab8817cd.jpg")
        # self.image = tk.PhotoImage(file='C:/Users/ADMIN/Downloads/FPT.jpg')
        # # # Create the widgets
        # self.image_label = tk.label(self, image=self.image).pack()
        # self.image_label.place(x=0, y=10, width=392, height=100)
        

        self.title_label = tk.Label(self, text="Date Time Checker", font=("Arial", 16))
        self.title_label.place(x=100, y=60, width=200, height=30)


        self.day_label = tk.Label(self, text="Day")
        self.day_label.place(x=50, y=130, width=50, height=27)
        self.day_entry = tk.Entry(self)
        self.day_entry.place(x=100, y=130, width=120)

        self.month_label = tk.Label(self, text="Month")
        self.month_label.place(x=50, y=170, width=50, height=27)
        self.month_entry = tk.Entry(self)
        self.month_entry.place(x=100, y=170, width=120)

        self.year_label = tk.Label(self, text="Year")
        self.year_label.place(x=50, y=210, width=50, height=27)
        self.year_entry = tk.Entry(self)
        self.year_entry.place(x=100, y=210, width=120)

        self.clear_button = tk.Button(self, text="Clear", command=self.clear_entries)
        self.clear_button.place(x=60, y=250, width=70, height=30)

        self.check_button = tk.Button(self, text="Check", command=self.check_date)
        self.check_button.place(x=150, y=250, width=70, height=30)

        # self.check2_button = tk.Button(self, text="Check2", command=self.check_day_in_month)
        # self.check2_button.place(x=240, y=250, width=70, height=30)

    def clear_entries(self):
        self.day_entry.delete(0, tk.END)
        self.month_entry.delete(0, tk.END)
        self.year_entry.delete(0, tk.END)

    def check_date(self):
        day = self.day_entry.get()
        month = self.month_entry.get()
        year = self.year_entry.get()
        date_checker = ValidDate()
        date_checker.check_date(day, month, year)
 

    # def check_day_in_month(self):
    #     month = self.month_entry.get()
    #     year = self.year_entry.get()
    #     day_checker = DayInMonth()
    #     days_in_month = day_checker.check_day_in_month(month, year)
    #     tk.messagebox.showinfo("Days in Month", f"There are {days_in_month} days in the selected month and year.")

if __name__ == "__main__":
    app = MainWindow()
    app.mainloop()