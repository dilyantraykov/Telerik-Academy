using System;
using System.Text;

namespace SchoolClasses
{
    class Person : ICommentable
    {
        private string firstName;

        private string lastName;

        private StringBuilder comments;

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name should not be empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name should not be empty!");
                }
                this.lastName = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
