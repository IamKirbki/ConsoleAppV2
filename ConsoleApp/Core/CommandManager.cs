using ConsoleApp.Interfaces;
using ConsoleApp.UI;

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
                return true;
            }

            _ui.Write("No such command, please write help for help");
            return false;
        }
    }
}
