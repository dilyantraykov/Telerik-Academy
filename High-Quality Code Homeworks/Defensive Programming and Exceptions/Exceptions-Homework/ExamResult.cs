using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("maxGrade should be bigger than minGrade!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Grade should be greater than or equal to 0!");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("MinGrade should be greater than or equal to 0!");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade { get; private set; }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Comments");
            }

            this.comments = value;
        }
    }
}
