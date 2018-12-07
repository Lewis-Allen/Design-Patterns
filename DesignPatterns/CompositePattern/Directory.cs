using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Directory : IFile
    {
        private string directoryName;
        private List<IFile> includedFiles = new List<IFile>();
        private string indentString = "----";


        public Directory(string directoryName)
        {
            this.directoryName = directoryName;
        }

        public void InsertFile(IFile fileToInsert)
        {
            includedFiles.Add(fileToInsert);
        }

        public void InsertFiles(List<IFile> filesToInsert)
        {
            foreach(IFile file in filesToInsert)
            {
                InsertFile(file);
            }
        }

        public void RemoveFile(IFile fileToRemove)
        {
            includedFiles.Remove(fileToRemove);
        }

        public void ListFiles()
        {
            Console.WriteLine(directoryName);

            Client.fileIndents += indentString;

            foreach (IFile file in includedFiles)
            {
                Console.Write(Client.fileIndents);
                file.ListFiles();
            }

            RemoveIndentString();
        }

        private void RemoveIndentString()
        {
            Client.fileIndents = Client.fileIndents.Remove(Client.fileIndents.Length - indentString.Length);
        }
    }
}
