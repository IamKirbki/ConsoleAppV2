using ConsoleApp.Interfaces;
using ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    public class CommandManager
    {
        private readonly Dictionary<string, ICommand> _commands = new();
        private readonly ConsoleUI _ui;

        public CommandManager(ConsoleUI consoleUI)
        {
            _ui = consoleUI;
        }

        public void RegisterCommand(ICommand command)
        {
            _commands[command.Name] = command;
        }

        public bool TryExecute(string input)
        {
            if (_commands.TryGetValue(input, out ICommand command))
            {
                command.Execute(_ui);
                _ui.Clear();
                return true;
            }

            _ui.Clear();
            _ui.Write("No such command, please write help for help");
            return false;
        }
    }
}
