using ConsoleApp.Core;
using ConsoleApp.UI;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                _ = new App(new ConsoleUI());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
