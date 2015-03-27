using System;
using System.Text;

namespace Students
{
    public enum Specialties
    {
        BusinessAdministration,
        ComputerScience,
        Psychology,
        Phylosophy,
        Mathematics,
        Law
    }

    public enum Universities
    {
        SofiaUniversity,
        TechnicalUniversity,
        UNWE,
        NBU,
        UASG
    }

    public enum Faculties
    {
        Mathematics,
        Finance,
        Languages,
        Psyhology,
        Europeistics,
        Journalism
    }

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string phone;
        private string email;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name should not be empty!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Middle name should not be empty!");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name should not be empty!");
                }
                this.lastName = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address should not be empty!");
                }
                this.address = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone should not be empty!");
                }
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Email should not be empty!");
                }
                this.email = value;
            }
        }

        public Student(string firstName, string middleName, string lastName,
            uint egn, string address, string phone, string email,
            byte course, Specialties specialty, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.EGN = egn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public uint EGN { get; set; }

        public byte Course { get; set; }

        public Specialties Specialty { get; set; }

        public Universities University { get; set; }

        public Faculties Faculty { get; set; }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.EGN.Equals((obj as Student).EGN)) return false;
            if (!this.Phone.Equals((obj as Student).Phone)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Specialty.Equals((obj as Student).Specialty)) return false;

            return true;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(String.Format("EGN: {0}", this.EGN));
            result.AppendLine(String.Format("Address: {0}", this.Address));
            result.AppendLine(String.Format("Phone: {0}", this.Phone));
            result.AppendLine(String.Format("Email: {0}", this.Email));
            result.AppendLine(String.Format("Course: {0}", this.Course));
            result.AppendLine(String.Format("University: {0}", this.University));
            result.AppendLine(String.Format("Faculty: {0}", this.Faculty));
            result.AppendLine(String.Format("Specialty: {0}", this.Specialty));


            return result.ToString().Trim();
        }

        public override int GetHashCode()
        {
            int hash = 23 * this.EGN.GetHashCode();
            hash *=  17 * this.Course.GetHashCode();
            return hash;
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !(st1.Equals(st2));
        }

        public object Clone()
        {
            var copy = new Student(this.FirstName, this.MiddleName, this.LastName,
                this.EGN, this.Address, this.Phone, this.Email,
                this.Course, this.Specialty, this.University, this.Faculty);

            return copy;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.EGN.CompareTo(other.EGN) != 0)
            {
                return this.EGN.CompareTo(other.EGN);
            }

            return 0;
        }
    }
}
