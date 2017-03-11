using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAndArchive
{
    class FileBrowser
    {
        public static void SearchDirectory(string directory, FileTool fileTool)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);

            if (!directoryInfo.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + directory);
            }

            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (FileInfo file in fileInfo)
                fileTool.SetFile(file);

            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subdir in subDirectories)
            {
                fileTool.SetDirectory(subdir);
                SearchDirectory(subdir.FullName, fileTool);
            }
        }
    }
}
