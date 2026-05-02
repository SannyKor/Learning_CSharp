using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_MyDate_
{
    public class MyDate
    {
        private int Day { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }

        public MyDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        private DateTime ToDateTime()
        { 
            return new DateTime(Year, Month, Day); 
        }
        public static MyDate operator +(MyDate date, int days)
        {
            DateTime newDate = date.ToDateTime().AddDays(days);
            return new MyDate(newDate.Day, newDate.Month, newDate.Year);
        }
        public static int operator -(MyDate date1, MyDate date2)
        {
            return (date1.ToDateTime() - date2.ToDateTime()).Days;
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

    }
}
