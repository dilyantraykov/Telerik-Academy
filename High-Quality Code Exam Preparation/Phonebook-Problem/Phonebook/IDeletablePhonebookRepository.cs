namespace Phonebook
{
    public interface IDeletablePhonebookRepository : IPhonebookRepository
    {
        bool Remove(string phoneNumber);
    }
}
