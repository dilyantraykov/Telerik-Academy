namespace Phonebook
{
    using System;
    using Phonebook.Commands;

    public class PhonebookEntryPoint
    {
        public static void Main()
        {
            Sanitizer sanitizer = new Sanitizer();
            IPrinter printer = new StringBuilderPrinter();
            IDeletablePhonebookRepository data = new PhonebookRepository();
            CommandFactory commandFactory = new CommandFactory(sanitizer, data, printer);

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "End" || inputLine == null)
                {
                    // Error reading from console 
                    break;
                }

                var commandParser = new CommandParser();
                var commandInfo = commandParser.Parse(inputLine);
                IPhoneCommand currentCommand = commandFactory.GetCommand(commandInfo.Command, commandInfo.Arguments);
                currentCommand.ExecuteCommand(commandInfo.Arguments);
            }

            printer.Print();
        }
    }
}
