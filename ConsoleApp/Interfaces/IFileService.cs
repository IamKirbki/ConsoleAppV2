using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface IFileService
    {
        string Read(string path);
        void Write(string path, string content);
        void Create(string path);
        bool Exists(string path);
        void Delete(string path);
    }
}
