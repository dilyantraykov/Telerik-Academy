namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using Phonebook.Commands;

    public class ListPhonesCommand : IPhoneCommand
    {
        private Sanitizer sanitizer;
        private IPhonebookRepository data = new PhonebookRepository();
        private IPrinter printer;

        public ListPhonesCommand(Sanitizer sanitizer, IPhonebookRepository data, IPrinter printer)
        {
            this.sanitizer = sanitizer;
            this.data = data;
            this.printer = printer;
        }

        public void ExecuteCommand(string[] arguments)
        {
            try
            {
                IEnumerable<PhoneEntry> entries = this.data.ListEntries(int.Parse(arguments[0]), int.Parse(arguments[1]));
                foreach (var entry in entries)
                {
                    this.printer.AppendLine(entry.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                this.printer.AppendLine("Invalid range");
            }
        }
    }
}
