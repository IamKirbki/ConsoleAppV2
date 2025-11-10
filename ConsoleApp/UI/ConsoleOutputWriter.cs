using ConsoleApp.Interfaces;

namespace ConsoleApp.UI
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}
