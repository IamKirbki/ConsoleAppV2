using ConsoleApp.Interfaces;
using ConsoleApp.UI;

namespace ConsoleApp.Commands
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Write(
                "list: Show a list of pokemon \n" +
                "createFile: Create a .txt file \n" +
                "date: Get the current date in format: dd-mm-yyyy \n" +
                "reverse: Reverse an input string \n" +
                "help: This menu :D \n" +
            );
        }
    }
}
