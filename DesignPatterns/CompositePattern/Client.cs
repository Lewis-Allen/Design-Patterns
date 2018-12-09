
using System.Collections.Generic;

namespace CompositePattern
{
    public class Client
    {
        public static string fileIndents = "";

        public static void Main()
        {
            Directory topDirectory = new Directory("TopDir");
            IFile middleFile = new File("MiddleFile");
            topDirectory.InsertFile(middleFile);

            Directory middleDirectory1 = new Directory("MiddleDir1");
            topDirectory.InsertFile(middleDirectory1);

            IFile lowerFile1 = new File("LowerFile1");
            IFile lowerFile2 = new File("LowerFile2");
            IFile lowerFile3 = new File("LowerFile3");

            middleDirectory1.InsertFiles(new List<IFile> { lowerFile1, lowerFile2, lowerFile3 });

            Directory middleDirectory2 = new Directory("MiddleDir2");
            topDirectory.InsertFile(middleDirectory2);

            IFile lowerFile4 = new File("LowerFile4");
            middleDirectory2.InsertFile(lowerFile4);

            topDirectory.ListFiles();
        }
    }
}
