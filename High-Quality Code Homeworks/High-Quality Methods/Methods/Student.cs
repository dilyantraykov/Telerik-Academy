namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDay, string town, string comments = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            this.Town = town;
            this.Comments = comments;
        }

        // should add validation
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Town { get; set; }

        public string Comments { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.BirthDay < other.BirthDay;
        }
    }
}
