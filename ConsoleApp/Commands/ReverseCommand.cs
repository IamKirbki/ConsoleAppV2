using ConsoleApp.Interfaces;
using ConsoleApp.UI;

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
        }
        public static string Reverse(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
