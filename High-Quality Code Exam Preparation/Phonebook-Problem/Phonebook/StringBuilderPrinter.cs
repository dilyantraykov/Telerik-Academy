namespace Phonebook
{
    using System;
    using System.Text;

    public class StringBuilderPrinter : IPrinter
    {
        private StringBuilder output = new StringBuilder();

        public void AppendLine(string text)
        {
            this.output.AppendLine(text);
        }

        public void Print()
        {
            Console.WriteLine(this.output.ToString());
        }
    }
}
