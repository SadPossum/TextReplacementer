using System;
using System.IO;
using System.Windows.Forms;

namespace TextReplacementer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Minimum;

            if (directoryPathTextBox.Text != "" && 
                (File.Exists(directoryPathTextBox.Text) || Directory.Exists(directoryPathTextBox.Text)))
            {
                progressBar.Maximum = FileSystem.GetNumberOfFiles(directoryPathTextBox.Text, true);

                foreach (string file in Directory.EnumerateFiles(directoryPathTextBox.Text, "*",
                    replsceTextInSubDirectoryCheckBox.Checked == true ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
                {
                    currentFileLabel.Text = file;
                    FileSystem.ReplaceText(file, replaceableTextBox.Text, replacementTextBox.Text);
                    progressBar.Value++;
                }

                currentFileLabel.Text = "готово";
            }
        }

        private void directoryPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(directoryPathTextBox.Text))
            {
                replsceTextInSubDirectoryLabel.Visible = false;
                replsceTextInSubDirectoryCheckBox.Visible = false;
            }
            else if (Directory.Exists(directoryPathTextBox.Text))
            {
                replsceTextInSubDirectoryLabel.Visible = true;
                replsceTextInSubDirectoryCheckBox.Visible = true;
            }
        }
    }
}