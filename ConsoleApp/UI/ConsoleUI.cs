using ConsoleApp.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.UI
{
    public class ConsoleUI
    {
        private readonly ConsoleInputReader _inputReader = new();
        private readonly ConsoleOutputWriter _outputWriter = new();

        public string Read() => _inputReader.ReadInput();
        public void Write(string str) => _outputWriter.WriteOutput(str);
        public void Clear() => Console.Clear();

        public void SetupCancelling() => _inputReader.SetupCancelHandler();
        public void ResetCancelling() => _inputReader.ResetCancelHandler();
        public bool IsCancelling => _inputReader.IsCancelling;
    }
}
