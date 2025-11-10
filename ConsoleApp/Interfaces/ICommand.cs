using ConsoleApp.UI;
namespace ConsoleApp.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        void Execute(ConsoleUI _ui);
    }
}
