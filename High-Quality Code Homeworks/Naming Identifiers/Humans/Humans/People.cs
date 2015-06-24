namespace Humans
{
    public class People
    {
        public enum Genders
        {
            Male, 
            Female
        }

        public class Person
        {
            public Genders Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }

        public void CreatePerson(int personAge)
        {
            Person person1 = new Person();
            person1.Age = personAge;
            if (personAge % 2 == 0)
            {
                person1.Name = "The Rock";
                person1.Gender = Genders.Male;
            }
            else
            {
                person1.Name = "The Damsel in Distress";
                person1.Gender = Genders.Female;
            }
        }
    }
}
