using ConsoleApp.Interfaces;

namespace ConsoleApp.Services
{
    public class FileService : IFileService
    {
        public void Create(string path)
        {
            File.AppendText(path);
        }

        public void Delete(string path)
        {
            if (Exists(path))
                File.Delete(path);
            else
                throw new FileNotFoundException("File not found", path);
        }

        public string Read(string path)
        {
            if (Exists(path))
                return File.ReadAllText(path);
            else
                throw new FileNotFoundException("File not found", path);
        }

        public void Write(string path, string content)
        {
            if (Exists(path))
                File.WriteAllText(path, content);
            else 
                throw new FileNotFoundException("File not found", path);
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}
