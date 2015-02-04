using System;

class Date
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        day++;
        switch(month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (day==32)
                {
                    day = 1;
                    month++;
                    if (month == 13)
                    {
                        month = 1;
                        year++;
                    }
                }
                break;
            case 2:
                if (year == 2012 || year == 2008 || year == 2004 || year == 2000)
                {
                    if (day == 30)
                    {
                        day = 1;
                        month++;
                    }
                }
                else
                {
                    if (day == 29)
                    {
                        day = 1;
                        month++;
                    }
                }
                break;
            default:
                if (day == 31)
                {
                    day = 1;
                    month++;
                }
                break;
        }
        Console.WriteLine("{0}.{1}.{2}", day, month, year);
    }
}

