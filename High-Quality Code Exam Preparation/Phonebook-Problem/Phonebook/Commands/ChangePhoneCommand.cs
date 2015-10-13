namespace Phonebook
{
    using Phonebook.Commands;

    public class ChangePhoneCommand : IPhoneCommand
    {
        private Sanitizer sanitizer;
        private IPhonebookRepository data = new PhonebookRepository();
        private IPrinter printer;

        public ChangePhoneCommand(Sanitizer sanitizer, IPhonebookRepository data, IPrinter printer)
        {
            this.sanitizer = sanitizer;
            this.data = data;
            this.printer = printer;
        }

        public void ExecuteCommand(string[] arguments)
        {
            this.printer.AppendLine(string.Empty + this.data.ChangePhone(
                this.sanitizer.ConvertToCanonicalPhoneNumberFormat(arguments[0]),
                this.sanitizer.ConvertToCanonicalPhoneNumberFormat(arguments[1])) + " numbers changed");
        }
    }
}
