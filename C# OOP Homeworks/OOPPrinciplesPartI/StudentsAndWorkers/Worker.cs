using System;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private double weekSalary;

        private double workHoursPerDay;

        public double WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Salary should be positive!");
                }
                weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }
            set
            {
                if (value < 0 && value > 24)
                {
                    throw new ArgumentOutOfRangeException("Workhours per day should be between 0 and 24!");
                }
                workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:F3}", base.ToString(), this.MoneyPerHour());
        }
    }
}
