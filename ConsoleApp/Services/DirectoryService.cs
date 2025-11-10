using ConsoleApp.Interfaces;

namespace ConsoleApp.Services
{
    public class DirectoryService : IDirectoryService
    {
        public string CurrPath { get; private set; }

        public DirectoryService(string startPath)
        {
            if(!Directory.Exists(startPath))
                throw new Exception("Directory not found: " + startPath);
            else
                CurrPath = Path.GetFullPath(startPath);
        }

        public IEnumerable<string> GetFiles() =>
            Directory.GetFiles(CurrPath).Select(Path.GetFileName)!;

        public void GoInto(string folder)
        {
            var newPath = Path.Combine(CurrPath, folder);
            if(!Directory.Exists(newPath))
                throw new Exception("Directory not found: " + newPath);
            else
                CurrPath = newPath;
        }

        public void GoUp()
        {
            var parent = Directory.GetParent(CurrPath);
            if (parent != null)
                CurrPath = parent.FullName;
            else
                throw new Exception("No parent directory.");
        }

        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }
    }
}
