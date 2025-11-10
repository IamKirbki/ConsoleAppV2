using ConsoleApp.Commands;
using ConsoleApp.UI;

namespace ConsoleApp.Core
{
    public class App
    {
        private const string EXIT_COMMAND = "exit";
        private readonly ConsoleUI _ui;

        public App(ConsoleUI consoleUI)
        {
            _ui = consoleUI;
            Run();
        }

        public void Run()
        {
            CommandManager _commandManager = new(_ui);

            _commandManager.RegisterCommand(new ListCommand());
            _commandManager.RegisterCommand(new HelpCommand());
            _commandManager.RegisterCommand(new CreateFileCommand());
            _commandManager.RegisterCommand(new ReverseCommand());
            _commandManager.RegisterCommand(new DateCommand());
            _commandManager.RegisterCommand(new ClearCommand());

            bool isActive = true;

            while (isActive)
            {
                string input = _ui.Read();
                input = input.Trim();
                if (input != EXIT_COMMAND)
                {
                    _commandManager.TryExecute(input);
                }
                else
                {
                    isActive = false;
                }
            }
        }
    }
}
