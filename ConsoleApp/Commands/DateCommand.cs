using ConsoleApp.Interfaces;
using ConsoleApp.UI;

namespace ConsoleApp.Commands
{
    public class DateCommand : ICommand
    {
        public string Name => "date";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Clear();
            _ui.Write("The current date in dd-mm-yyyy format is: " + DateTime.Now.ToString("dd-MM-yyyy"));
        }
    }
}
