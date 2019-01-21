using System;

namespace CompositePattern
{
    class File : IFile
    {
        private string fileName;

        public File(string fileName)
        {
            this.fileName = fileName;
        }

        public void ListFiles()
        {
            Console.WriteLine(fileName);
        }
    }
}
