namespace Phonebook
{
    using System;
    using Phonebook.Commands;

    public class CommandFactory
    {
        private Sanitizer sanitizer;
        private IDeletablePhonebookRepository data = new PhonebookRepository();
        private IPrinter printer;

        public CommandFactory(Sanitizer sanitizer, IDeletablePhonebookRepository data, IPrinter printer)
        {
            this.sanitizer = sanitizer;
            this.data = data;
            this.printer = printer;
        }

        public IPhoneCommand GetCommand(string command, string[] arguments)
        {
            if (command.StartsWith("AddPhone") && arguments.Length >= 2)
            {
                return new AddPhoneCommand(this.sanitizer, this.data, this.printer);
            }
            else if (command == "ChangePhone" && arguments.Length > 1)
            {
                return new ChangePhoneCommand(this.sanitizer, this.data, this.printer);
            }
            else if (command == "List" && arguments.Length == 2)
            {
                return new ListPhonesCommand(this.sanitizer, this.data, this.printer);
            }
            else if (command == "Remove" && arguments.Length == 1)
            {
                return new RemovePhoneCommand(this.sanitizer, this.data, this.printer);
            }
            else
            {
                throw new ArgumentException("Invalid command!");
            }
        }
    }
}
