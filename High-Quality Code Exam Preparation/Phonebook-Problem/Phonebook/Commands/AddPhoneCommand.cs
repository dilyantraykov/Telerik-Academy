namespace Phonebook.Commands
{
    using System.Linq;

    public class AddPhoneCommand : IPhoneCommand
    {
        private Sanitizer sanitizer;
        private IPhonebookRepository data = new PhonebookRepository();
        private IPrinter printer;

        public AddPhoneCommand(Sanitizer sanitizer, IPhonebookRepository data, IPrinter printer)
        {
            this.sanitizer = sanitizer;
            this.data = data;
            this.printer = printer;
        }

        public void ExecuteCommand(string[] arguments)
        {
            string entryName = arguments[0];
            var phoneNumbers = arguments.Skip(1).ToList();
            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                phoneNumbers[i] = this.sanitizer.ConvertToCanonicalPhoneNumberFormat(phoneNumbers[i]);
            }

            bool flag = this.data.AddPhone(entryName, phoneNumbers);

            if (flag)
            {
                this.printer.AppendLine("Phone entry created");
            }
            else
            {
                this.printer.AppendLine("Phone entry merged");
            }
        }
    }
}
