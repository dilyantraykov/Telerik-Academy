namespace Phonebook
{
    using System;

    public class CommandParser
    {
        public CommandInfo Parse(string inputLine)
        {
            int indexOfOpeningBracket = inputLine.IndexOf('(');
            if (indexOfOpeningBracket == -1)
            {
                throw new ArgumentException("Invalid command!");
            }

            string command = inputLine.Substring(0, indexOfOpeningBracket);
            if (!inputLine.EndsWith(")"))
            {
                throw new ArgumentException("Invalid command!");
            }

            string argumentsAsString = inputLine.Substring(indexOfOpeningBracket + 1, inputLine.Length - indexOfOpeningBracket - 2);
            var arguments = argumentsAsString.Split(',');

            for (int j = 0; j < arguments.Length; j++)
            {
                arguments[j] = arguments[j].Trim();
            }

            return new CommandInfo()
            {
                Command = command,
                Arguments = arguments
            };
        }
    }
}
