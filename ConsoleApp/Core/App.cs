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
            _ui.SetupCancelling();
            Run();
        }

        public void Run()
        {
            CommandManager _commandManager = new(_ui);

            _commandManager.RegisterCommands(
                [
                    new ListCommand(),
                    new HelpCommand(),
                    new CreateFileCommand(),
                    new ReverseCommand(),
                    new DateCommand(),
                    new ClearCommand()
                ]
            );

            bool _active = true;

            while (_active)
            {
                string _input = _ui.Read().Trim();
                if (_input != EXIT_COMMAND || _ui.IsCancelling)
                {
                    try
                    {
                        _commandManager.TryExecute(_input);
                        _ui.ResetCancelling();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                     _active = false;
                }
            }
        }
    }
}
