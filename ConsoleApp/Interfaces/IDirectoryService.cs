namespace ConsoleApp.Interfaces
{
    public interface IDirectoryService
    {
        string CurrPath { get; }
        void GoUp();
        void GoInto(string folder);
        IEnumerable<string> GetFiles();
        bool Exists(string path);
    }
}
