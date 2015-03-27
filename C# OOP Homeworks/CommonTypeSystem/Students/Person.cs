using System;

namespace Students
{
    class Person
    {
        private string name;
        private byte? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, byte? age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name should not be empty!");
                }
                name = value;
            }
        }

        public byte? Age { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());
        }
    }
}
