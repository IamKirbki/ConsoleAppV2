using ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        void Execute(ConsoleUI _ui);
    }
}
