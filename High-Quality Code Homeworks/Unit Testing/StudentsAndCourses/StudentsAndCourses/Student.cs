using System;

public class Student
{
    private string name;
    private int uniqueNumber;

    public Student(string name, int uniqueNumber)
    {
        this.Name = name;
        this.UniqueNumber = uniqueNumber;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentNullException("Name cannot be missing!");
            }
        }
    }

    public int UniqueNumber
    {
        get
        {
            return this.uniqueNumber;
        }

        set
        {
            if (value >= 10000 && value <= 99999)
            {
                this.uniqueNumber = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The unique number of student" + this.Name +
                    "should be between 10000 and 99999!");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Student {0}, ID {1}; ", this.Name, this.UniqueNumber);
    }
}