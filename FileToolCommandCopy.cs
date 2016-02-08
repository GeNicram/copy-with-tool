using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAndArchive
{
    class FileToolCommandCopy : FileTool
    {
        public void SetDirectory(DirectoryInfo path)
        {
            // Need to create directory in destination directory
            string a = path.FullName.Substring(source_.FullName.Length);
            DirectoryInfo newDirectory = new DirectoryInfo(
                Path.Combine(destination_.FullName,
                    path.FullName.Substring(source_.FullName.Length + 1))
                );

            if (!newDirectory.Exists)
                newDirectory.Create();
        }

        public void SetFile(FileInfo path)
        {
            string destination;
            if (path.DirectoryName == source_.FullName)
            {
                destination = Path.Combine(destination_.FullName,
                    Path.GetFileNameWithoutExtension(path.Name));
            }
            else
            {
                destination = Path.Combine(destination_.FullName,
                    path.DirectoryName.Substring(source_.FullName.Length + 1),
                    Path.GetFileNameWithoutExtension(path.Name));
            }

            ProcessWorker.Run(command_, tool_,
                path.FullName, destination);
        }

        public void SetDestination(string path)
        {
            destination_ = new DirectoryInfo(path);

            if (!destination_.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Destination directory does not exist or could not be found: "
                    + destination_);
            }
        }

        public void SetSource(string path)
        {
            source_ = new DirectoryInfo(path);

            if (!source_.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + source_);
            }
        }

        public string Command
        {
            get
            {
                return command_;
            }

            set
            {
                command_ = value;
            }
        }

        public string Tool
        {
            get
            {
                return tool_;
            }

            set
            {
                tool_ = value;
            }
        }

        private DirectoryInfo destination_;
        private DirectoryInfo source_;
        private string command_;
        private string tool_;
    }
}
