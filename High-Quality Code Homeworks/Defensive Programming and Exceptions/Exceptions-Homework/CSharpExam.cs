using System;

public class CSharpExam : Exam
{
    public const int MinScore = 0;
    public const int MaxScore = 100;

    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new NullReferenceException("Score should be greater than or equal to 0!");
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (Score < MinScore || Score > MaxScore)
        {
            throw new ArgumentOutOfRangeException("Score", "Score should be between " + MinScore + " and " + MaxScore);
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
