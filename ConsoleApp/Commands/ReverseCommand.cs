using ConsoleApp.Interfaces;
using ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Commands
{
    public class ReverseCommand : ICommand
    {
        public string Name => "reverse";

        public void Execute(ConsoleUI _ui)
        {
            _ui.Clear();
            _ui.Write("Input a string to reverse");
            string str = _ui.Read();
            _ui.Write("Your string reversed is: ");
            _ui.Write(Reverse(str));

            _ui.Write("");
            _ui.Write("Enter anything to exit");
            _ui.Read();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
