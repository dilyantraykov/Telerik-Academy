using System;
using System.Text;

namespace SchoolClasses
{
    class Discipline : ICommentable
    {
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

        public byte NumberOfLectures { get; set; }

        public uint NumberOfExercises { get; set; }

        public Discipline(string name, byte numberOfLectures, uint numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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
