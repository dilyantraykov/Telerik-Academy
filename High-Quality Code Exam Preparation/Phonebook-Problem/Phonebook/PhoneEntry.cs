namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhoneEntry : IComparable<PhoneEntry>
    {
        private string name;
        private string nameForComparison;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.nameForComparison = value.ToLowerInvariant();
            }
        }

        public SortedSet<string> PhoneNumbers { get; set; }

        public override string ToString()
        {
            StringBuilder entry = new StringBuilder();
            entry.Append('[');
            entry.Append(this.Name);
            bool isNamePrinted = true;
            foreach (var phone in this.PhoneNumbers)
            {
                if (isNamePrinted)
                {
                    entry.Append(": ");
                    isNamePrinted = false;
                }
                else
                {
                    entry.Append(", ");
                }

                entry.Append(phone);
            }

            entry.Append(']');
            return entry.ToString();
        }

        public int CompareTo(PhoneEntry other)
        {
            return this.nameForComparison.CompareTo(other.nameForComparison);
        }
    }
}
