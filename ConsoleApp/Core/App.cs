using ConsoleApp.Commands;
using ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            ListCommand _list = new();
            HelpCommand _help = new();
            CreateFileCommand _file = new();
            ReverseCommand _reverse = new();
            DateCommand _date = new();

            _commandManager.RegisterCommand(_list);
            _commandManager.RegisterCommand(_help);
            _commandManager.RegisterCommand(_file);
            _commandManager.RegisterCommand(_reverse);
            _commandManager.RegisterCommand(_date);

            bool isActive = true;

            while (isActive)
            {
                string Input = _ui.Read();
                if(Input != EXIT_COMMAND)
                {
                    _commandManager.TryExecute(Input);
                } else
                {
                    isActive = false;
                }
            }
        }
    }
}
