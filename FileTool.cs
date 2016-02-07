using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAndArchive
{
    interface FileTool
    {
        void SetFile(FileInfo path);
        void SetDirectory(DirectoryInfo path);
    }
}
