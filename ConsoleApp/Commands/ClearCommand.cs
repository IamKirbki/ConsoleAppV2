using ConsoleApp.Interfaces;
using ConsoleApp.UI;

namespace ConsoleApp.Commands
{
    public class ClearCommand : ICommand
    {
        public string Name => "clear";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Clear();
        }
    }
}
