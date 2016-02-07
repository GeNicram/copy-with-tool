using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyAndArchive
{
    class FileToolPreview : FileTool
    {
        public void SetListBox(ListBox ui)
        {
            listBox_ = ui;
        }

        public void SetDirectory(DirectoryInfo path)
        {
            AddItem("Directory: " + path.Name);
        }

        public void SetFile(FileInfo path)
        {
            AddItem(path.Name);
        }

        private void AddItem(string item)
        {
            if (listBox_ == null)
            {
                throw new NullReferenceException(
                    "list Box is not set.");
            }

            listBox_.Items.Add(item);
        }

        private ListBox listBox_ = null;
    }
}
