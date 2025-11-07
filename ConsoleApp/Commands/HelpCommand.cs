using ConsoleApp.Interfaces;
using ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Write("list: Show a list of pokemon");
            _ui.Write("createFile: Create a .txt file");
            _ui.Write("date: Get the current date in format: dd-mm-yyyy");
            _ui.Write("reverse: Reverse an input string");
            _ui.Write("help: This menu :D");

            _ui.Write("");
            _ui.Write("Enter anything to exit");
            _ui.Read();
        }
    }
}
