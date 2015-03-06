/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;

class Program
{
    static void Main()
    {
        DateTime date;
        bool input = DateTime.TryParse(Console.ReadLine(), out date);
        DateTime[] holidays = { new DateTime(2015, 3, 2),
                                new DateTime(2015, 3, 3)};
        if (input)
        {
            string today = DateTime.Today.ToString("dd.MM.yy");
            string inputDate = date.ToString("dd.MM.yy");
            Console.WriteLine("Number of workdays between {0} and {1} is {2}", today, inputDate, GetNumberOfWorkdays(date, holidays));
        }
        else
        {
            Console.WriteLine("Invalid date!");
        }
    }

    static int GetNumberOfWorkdays(DateTime day, params DateTime[] holidays)
    {
        DateTime firstDay;
        DateTime lastDay;
        if (DateTime.Today > day)
        {
            firstDay = day;
            lastDay = DateTime.Today;
        }
        else
        {
            firstDay = DateTime.Today;
            lastDay = day;
        }
        firstDay = firstDay.Date;
        lastDay = lastDay.Date;

        TimeSpan span = lastDay - firstDay;
        int workDays = span.Days + 1;
        int fullWeekCount = workDays / 7;
        // find out if there are weekends during the time exceedng the full weeks
        if (workDays > fullWeekCount * 7)
        {
            // we are here to find out if there is a 1-day or 2-days weekend
            // in the time interval remaining after subtracting the complete weeks
            int firstDayOfWeek = (int)firstDay.DayOfWeek;
            int lastDayOfWeek = (int)lastDay.DayOfWeek;
            if (lastDayOfWeek < firstDayOfWeek)
                lastDayOfWeek += 7;
            if (firstDayOfWeek <= 6)
            {
                if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                    workDays -= 2;
                else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                    workDays -= 1;
            }
            else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                workDays -= 1;
        }

        // subtract the weekends during the full weeks in the interval
        workDays -= fullWeekCount + fullWeekCount;

        // subtract the number of holidays during the time interval
        foreach (DateTime holiday in holidays)
        {
            DateTime bh = holiday.Date;
            if (firstDay <= bh && bh <= lastDay)
                --workDays;
        }

        return workDays;
    }
}
