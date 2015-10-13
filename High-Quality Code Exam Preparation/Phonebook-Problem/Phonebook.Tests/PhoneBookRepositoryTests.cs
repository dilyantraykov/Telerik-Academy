using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PhoneBookRepositoryTests
    {
        [TestMethod]
        public void AddNewPhoneEntryShouldReturnTrue()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456" };
            var result = testRepository.AddPhone("Pesho", numbers);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void AddExistingPhoneEntryShouldReturnFalse()
        {
            IPhonebookRepository repository = new PhonebookRepository();

            repository.AddPhone("Pesho", new List<string>() { });
            var result = repository.AddPhone("Pesho", new List<string>() { });

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AddPhoneShouldMergeWithExistingPhoneNumbers()
        {
            IPhonebookRepository repository = new PhonebookRepository();

            repository.AddPhone("Pesho", new List<string>() { "112", "911" });
            var result = repository.AddPhone("Pesho", new List<string>() { "112" });

            Assert.AreEqual(2, repository.ListEntries(0, 1)[0].PhoneNumbers.Count);
        }

        [TestMethod]
        public void AddPhoneShouldMergeWithNewPhoneNumbers()
        {
            IPhonebookRepository repository = new PhonebookRepository();

            repository.AddPhone("Pesho", new List<string>() { "112", "911" });
            var result = repository.AddPhone("Pesho", new List<string>() { "113" });

            Assert.AreEqual(3, repository.ListEntries(0, 1)[0].PhoneNumbers.Count);
        }

        [TestMethod]
        public void AddExistingPhoneEntryWithDifferentCasingShouldReturnFalse()
        {
            IPhonebookRepository repository = new PhonebookRepository();

            repository.AddPhone("Pesho", new List<string>() { });
            var result = repository.AddPhone("pesho", new List<string>() { });

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ChangePhoneShouldChangeSinglePhoneNumber()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456" };
            testRepository.AddPhone("Pesho", numbers);
            var result = testRepository.ChangePhone("0898123456", "0898123478");
            var phoneCount = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count;

            Assert.AreEqual(1, result);
            Assert.AreEqual(1, phoneCount);
        }

        [TestMethod]
        public void ChangePhoneShouldChangeMultiplePhoneNumbers()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.AddPhone("Gosho", numbers);
            var result = testRepository.ChangePhone("0898123456", "0898123478");
            var phoneCount1 = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count;
            var phoneCount2 = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count;

            Assert.AreEqual(2, result);
            Assert.AreEqual(1, phoneCount1);
            Assert.AreEqual(1, phoneCount2);
        }

        [TestMethod]
        public void ChangePhoneShouldMergePhoneNumbers()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            var result = testRepository.ChangePhone("0898123456", "0898123478");
            var phoneCount = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count;

            Assert.AreEqual(1, result);
            Assert.AreEqual(1, phoneCount);
        }

        [TestMethod]
        public void ChangePhoneShouldReturnZeroWhenNoPhoneNumbersAreFound()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            var result = testRepository.ChangePhone("0898121111", "0898123478");
            var phoneCount = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count;

            Assert.AreEqual(0, result);
            Assert.AreEqual(2, phoneCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ListEntriesShouldThrowWhenNegativeIndexIsGiven()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.ListEntries(-2, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ListEntriesShouldThrowWhenInvalidIndexIsGiven()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.ListEntries(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ListEntriesShouldThrowWhenInvalidCountIsGiven()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.ListEntries(0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ListEntriesShouldThrowWhenThereAreNoEntries()
        {
            var testRepository = new PhonebookRepository();
            var entryCount = testRepository.ListEntries(0, 1).Count();
        }

        [TestMethod]
        public void ListEntriesShouldDisplayCorrectNumberOfEntriesWhenThereAreMultipleEntries()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.AddPhone("Gosho", numbers);
            testRepository.AddPhone("Ivan", numbers);
            var entryCount = testRepository.ListEntries(0, 3).Count();

            Assert.AreEqual(3, entryCount);
        }

        [TestMethod]
        public void RemovePhoneShouldDoNothingIfPhoneIsNotFound()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.Remove("0898123490");
            var phoneCount = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count();

            Assert.AreEqual(2, phoneCount);
        }

        [TestMethod]
        public void RemovePhoneShouldCorrectlyRemovePhone()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.Remove("0898123456");
            var phoneCount = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count();

            Assert.AreEqual(1, phoneCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemovePhoneShouldCorrectlyRemoveEntryIfDeletedPhoneWasLastPhoneOfEntry()
        {
            var testRepository = new PhonebookRepository();
            var numbers = new string[] { "0898123456", "0898123478" };
            testRepository.AddPhone("Pesho", numbers);
            testRepository.Remove("0898123456");
            testRepository.Remove("0898123478");
            var phoneCount = testRepository.ListEntries(0, 1)[0].PhoneNumbers.Count();
        }
    }
}
