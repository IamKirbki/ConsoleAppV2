using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
