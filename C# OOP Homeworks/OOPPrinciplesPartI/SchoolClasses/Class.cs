using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    class Class : ICommentable
    {
        private List<Teacher> teachers;

        private List<Student> students;

        private string name;

        private StringBuilder comments;

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

        public Class(string name, params Teacher[] teachers)
        {
            this.Name = name;
            this.teachers = new List<Teacher>();
            this.teachers.AddRange(teachers);
            this.students = new List<Student>();
            this.comments = new StringBuilder();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(String.Format("Class \"{0}\" has {1} teachers and {2} students.",
                                    this.Name, this.teachers.Count, this.students.Count));
            return result.ToString();
        }

        public StringBuilder Comments
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comments.ToString()))
                {
                    return new StringBuilder("No comments available!");
                }

                return this.comments;
            }
            set
            {
                if (value.Length < 20)
                {
                    throw new ArgumentException("Comment should be at least 20 chars!");
                }
                this.comments = value;
            }
        }

        public void AddComment(string comment)
        {
            if (comment.Length < 20)
            {
                throw new ArgumentException("Comment should be at least 20 chars!");
            }
            this.comments.AppendLine(comment);
        }

        public void RemoveComments()
        {
            this.comments.Clear();
        }
    }
}
