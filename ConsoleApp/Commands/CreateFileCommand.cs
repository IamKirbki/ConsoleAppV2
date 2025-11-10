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

            PrepareDirectory(_dirService, _ui);
            PromptAndCreateFile(_dirService, _ui);

            _ui.Write("\n Exited! \n");
        }

        private void PrepareDirectory(DirectoryService dirService, ConsoleUI ui)
        {
            ui.Write(dirService.CurrPath);
            dirService.GoUp();
            dirService.GoUp();
            dirService.GoUp();
            dirService.GoInto("data");
        }

        private void PromptAndCreateFile(DirectoryService dirService, ConsoleUI ui)
        {
            bool isNameValid = false;
            while (!isNameValid)
            {
                ui.Write("Please insert a file name:");

                string fileName = ui.Read();
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    ui.Write("A file name must be given");
                    continue;
                }
                else if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    ui.Write("The file name contains invalid characters");
                    continue;
                }

                FileService _fileService = new();

                string filePath = Path.Combine(dirService.CurrPath, fileName + ".txt");
                _fileService.Create(filePath);

                if (_fileService.Exists(filePath))
                {
                    ui.Write("File '" + fileName + "' created succesfully \n Press ctrl + c twice to save and exit \n \n Contents: ");

                    EnterWriteLoop(_fileService, filePath, ui);

                    isNameValid = true;
                }
            }
        }

        private void EnterWriteLoop(FileService fileService, string filePath, ConsoleUI ui)
        {
            bool isWriting = true;
            ui.ResetCancelling();

            while (isWriting)
            {
                string oldContent = fileService.Read(filePath);
                string content = ui.Read();

                if (!ui.IsCancelling)
                    fileService.Write(filePath, oldContent + "\n" + content);
                else
                    isWriting = false;
            }
        }
    }
}