namespace SchoolClasses
{
    class Student : Person
    {
        public uint ClassNumber { get; private set; }

        public Student(string firstName, string lastName, uint number)
            : base(firstName, lastName)
        {
            this.ClassNumber = number;
        }
    }
}
