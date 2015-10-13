namespace Phonebook.Commands
{
    public interface IPhoneCommand
    {
        void ExecuteCommand(string[] arguments);
    }
}
