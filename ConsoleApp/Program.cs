using ConsoleApp.Core;
using ConsoleApp.UI;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = new App(new ConsoleUI());
        }
    }
}
