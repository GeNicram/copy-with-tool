﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyAndArchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            filePreview = new FileToolPreview();
            filePreview.SetListBox(listBox);
        }

        private void buttonSelectFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxTool.Text = ofd.FileName;
            }
        }

        private void buttonSelectDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (sender == buttonSource)
                    textBoxSource.Text = fbd.SelectedPath;
                else if (sender == buttonDestination)
                    textBoxDestination.Text = fbd.SelectedPath;
            }
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FileBrowser.SearchDirectory(textBoxSource.Text, filePreview);
            } catch
            {
            }
        }

        private FileToolPreview filePreview = null;

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            buttonCopy.Text = "Working...";
            buttonCopy.Update();

            FileToolCommandCopy tool = new FileToolCommandCopy();
            tool.SetSource(textBoxSource.Text);
            tool.SetDestination(textBoxDestination.Text);
            tool.Command = textBoxCommand.Text;
            tool.Tool = textBoxTool.Text;

            FileBrowser.SearchDirectory(textBoxSource.Text, tool);

            buttonCopy.Text = "Copy";
        }
    }
}
