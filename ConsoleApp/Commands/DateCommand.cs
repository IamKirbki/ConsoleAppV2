using ConsoleApp.Interfaces;
using ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
    public class DateCommand : ICommand
    {
        public string Name => "date";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Clear();
            _ui.Write("The current date in dd-mm-yyyy format is: ");
            _ui.Write(DateTime.Now.ToString("dd-MM-yyyy"));

            _ui.Write("");
            _ui.Write("Enter anything to exit");
            _ui.Read();
        }
    }
}
