using ConsoleApp.Interfaces;
using ConsoleApp.Services;
using ConsoleApp.UI;

namespace ConsoleApp.Commands
{
    public class CreateFileCommand : ICommand
    {
        public string Name => "createFile";

        public void Execute(ConsoleUI _ui)
        {
            DirectoryService _dirService = new(Directory.GetCurrentDirectory());
            _ui.Write(_dirService.CurrPath);
            _dirService.GoUp();
            _dirService.GoUp();
            _dirService.GoUp();
            _dirService.GoInto("data");

            bool isNameValid = false;
            while (!isNameValid)
            {
                _ui.Write("Please insert a file name:");

                string FileName = _ui.Read();
                if (FileName == "")
                {
                    _ui.Write("A file name must be given");
                }
                else
                {
                    FileService _fileService = new();

                    string FilePath = _dirService.CurrPath + "/" + FileName + ".txt";
                    _fileService.Create(FilePath);

                    if (_fileService.Exists(FilePath))
                    {
                        _ui.Clear();
                        _ui.Write("File '" + FileName + "' created succesfully \n Press ctrl + c twice to save and exit \n \n Contents: ");

                        bool isWriting = true;
                        _ui.SetupCancelling();

                        while (isWriting) {
                            string oldContent = _fileService.Read(FilePath);
                            string content = _ui.Read();

                            if (!_ui.IsCancelling)
                                _fileService.Write(FilePath, oldContent + "\n" + content);
                            else
                                isWriting = false;
                        }

                        _ui.ResetCancelling();
                        isNameValid = true;
                    }
                }
            }
        }
    }
}
