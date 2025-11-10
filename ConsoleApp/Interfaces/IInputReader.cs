namespace ConsoleApp.Interfaces
{
    public interface IInputReader
    {
        string ReadInput();
        void SetupCancelHandler();
        void ResetCancelHandler();
        bool IsCancelling {  get; }
    }
}
