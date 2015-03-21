using System.Text;

namespace SchoolClasses
{
    interface ICommentable
    {
        StringBuilder Comments { get; set; }

        void AddComment(string comment);

        void RemoveComments();
    }
}
