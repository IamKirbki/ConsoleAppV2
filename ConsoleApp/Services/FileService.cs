using ConsoleApp.Interfaces;

namespace ConsoleApp.Services
{
    public class FileService : IFileService
    {
        public void Create(string path)
        {
            using (StreamWriter w = File.AppendText(path));
        }

        public void Delete(string path)
        {
            if(Exists(path))
                File.Delete(path);
        }

        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

        public void Write(string path, string content)
        {
            if(Exists(path))
                File.WriteAllText(path, content);
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}
