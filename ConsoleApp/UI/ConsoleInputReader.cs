using ConsoleApp.Interfaces;

namespace ConsoleApp.UI
{
    public class ConsoleInputReader : IInputReader
    {
        public string ReadInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        private bool _isCancelling = false;
        public bool IsCancelling => _isCancelling;
        public void SetupCancelHandler()
        {
            Console.CancelKeyPress += delegate (object? sender, ConsoleCancelEventArgs e)
            {
                _isCancelling = true;
                e.Cancel = true;
            };
        }

        public void ResetCancelHandler()
        {
            _isCancelling = false;            
        }
    }
}
