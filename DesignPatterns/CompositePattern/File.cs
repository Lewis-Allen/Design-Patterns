using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
