using System;
using System.Collections.Generic;

namespace SchoolClasses
{
    class School
    {
        private string name;

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name should not be empty!");
                }
                this.name = value;
            }
        }

        private List<Class> Classes;

        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<Class>();
        }

        public void AddClass(Class Class)
        {
            this.Classes.Add(Class);
        }

        public List<Class> GetClasses()
        {
            return new List<Class>(this.Classes);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
