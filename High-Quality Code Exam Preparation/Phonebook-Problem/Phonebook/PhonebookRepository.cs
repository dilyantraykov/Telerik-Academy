namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    /// <summary>
    /// A repository to keep and manage all the phone entries
    /// </summary>
    public class PhonebookRepository : IPhonebookRepository, IDeletablePhonebookRepository
    {
        private OrderedSet<PhoneEntry> sorted = new OrderedSet<PhoneEntry>();
        private Dictionary<string, PhoneEntry> dict = new Dictionary<string, PhoneEntry>();
        private MultiDictionary<string, PhoneEntry> multidict = new MultiDictionary<string, PhoneEntry>(false);

        /// <summary>
        /// Adds a new entry to the phone book with the specified name and phonenumbers.
        /// </summary>
        /// <param name="name">The name of the entry</param>
        /// <param name="phoneNumbers">The phonenumber(s) to add</param>
        /// <returns>True if the entry already exists and false otherwise</returns>
        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            string nameToLower = name.ToLowerInvariant();
            PhoneEntry phoneEntry;
            bool entryExists = !this.dict.TryGetValue(nameToLower, out phoneEntry);
            if (entryExists)
            {
                phoneEntry = new PhoneEntry();
                phoneEntry.Name = name;
                phoneEntry.PhoneNumbers = new SortedSet<string>();
                this.dict.Add(nameToLower, phoneEntry);
                this.sorted.Add(phoneEntry);
            }

            foreach (var phoneNumber in phoneNumbers)
            {
                this.multidict.Add(phoneNumber, phoneEntry);
            }

            phoneEntry.PhoneNumbers.UnionWith(phoneNumbers);
            return entryExists;
        }

        /// <summary>
        /// Changes the specified old phone number in all phonebook entries with a new one.
        /// </summary>
        /// <param name="oldEntry">The old phone number</param>
        /// <param name="newEntry">The new phone number</param>
        /// <returns>The number of the changed old phone numbers in the system</returns>
        public int ChangePhone(string oldEntry, string newEntry)
        {
            var found = this.multidict[oldEntry].ToList();
            foreach (var entry in found)
            {
                entry.PhoneNumbers.Remove(oldEntry);
                this.multidict.Remove(oldEntry, entry);
                entry.PhoneNumbers.Add(newEntry);
                this.multidict.Add(newEntry, entry);
            }

            return found.Count;
        }

        /// <summary>
        /// Lists the first 'count' phonebook entries starting from 'indexOfFirstEntry'. Throws when index is not valid.
        /// </summary>
        /// <param name="indexOfFirstEntry">The index of the first entry to list</param>
        /// <param name="count">The number of entries to list</param>
        /// <returns>A PhoneEntry array with the chosen entries</returns>
        public PhoneEntry[] ListEntries(int indexOfFirstEntry, int count)
        {
            if (indexOfFirstEntry < 0 || indexOfFirstEntry + count > this.dict.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or count.");
            }

            PhoneEntry[] list = new PhoneEntry[count];

            for (int i = indexOfFirstEntry; i <= indexOfFirstEntry + count - 1; i++)
            {
                PhoneEntry entry = this.sorted[i];
                list[i - indexOfFirstEntry] = entry;
            }

            return list;
        }

        /// <summary>
        /// Removes 
        /// </summary>
        /// <param name="phoneNumber">The phonenumber to remove</param>
        /// <returns>True if the entry already exists and false otherwise</returns>
        public bool Remove(string phoneNumber)
        {
            var found = this.multidict[phoneNumber].ToList();
            foreach (var entry in found)
            {
                entry.PhoneNumbers.Remove(phoneNumber);
                this.multidict.Remove(phoneNumber, entry);
                if (!entry.PhoneNumbers.Any())
                {
                    this.sorted.Remove(entry);
                }
            }

            return found.Count > 0;
        }
    }
}