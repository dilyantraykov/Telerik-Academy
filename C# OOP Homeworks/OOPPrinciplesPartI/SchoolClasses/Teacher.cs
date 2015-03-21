using System.Collections.Generic;

namespace SchoolClasses
{
    class Teacher : Person
    {
        public List<Discipline> Disciplines { get; private set; }

        public Teacher(string firstName, string lastName, List<Discipline> disciplines )
            : base(firstName, lastName)
        {
            this.Disciplines = new List<Discipline>(disciplines);
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
