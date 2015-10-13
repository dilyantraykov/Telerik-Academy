﻿namespace Phonebook
{
    using System.Collections.Generic;

    public interface IPhonebookRepository
    {
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        int ChangePhone(string oldEntry, string newEntry);

        PhoneEntry[] ListEntries(int startIndex, int count);
    }
}
