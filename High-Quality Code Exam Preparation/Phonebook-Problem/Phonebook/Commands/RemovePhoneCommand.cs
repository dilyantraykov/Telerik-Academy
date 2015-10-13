namespace Phonebook.Commands
{
    public class RemovePhoneCommand : IPhoneCommand
    {
        private Sanitizer sanitizer;
        private IDeletablePhonebookRepository data;
        private IPrinter printer;

        public RemovePhoneCommand(Sanitizer sanitizer, IDeletablePhonebookRepository data, IPrinter printer)
        {
            this.sanitizer = sanitizer;
            this.data = data;
            this.printer = printer;
        }

        public void ExecuteCommand(string[] arguments)
        {
            var number = this.sanitizer.ConvertToCanonicalPhoneNumberFormat(arguments[0]);
            if (arguments[0] != number)
            {
                this.printer.AppendLine("Invalid phone number");
                return;
            }

            bool deleted = this.data.Remove(number);

            if (deleted)
            {
                this.printer.AppendLine(string.Format("Number {0} successfully deleted", number));
            }
            else
            {
                this.printer.AppendLine("Phone number could not be found");
            }
        }
    }
}
