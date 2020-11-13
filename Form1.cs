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
            //Проверка введен ли путь
            if (!String.IsNullOrWhiteSpace(pathTextBox.Text))
            {
                progressBar.Value = progressBar.Minimum;
                progressBar.Maximum = FileSystem.GetNumberOfFiles(pathTextBox.Text, true);

                //Проверка является ли путь указанием на папку или файл
                if (File.Exists(pathTextBox.Text))
                {
                    FileSystem.ReplaceText(pathTextBox.Text, replaceableTextBox.Text, replacementTextBox.Text);
                    progressBar.Value++;
                    processLabel.Text = "готово";
                }
                else if (Directory.Exists(pathTextBox.Text))
                {
                    foreach (string file in Directory.EnumerateFiles(pathTextBox.Text, "*",
                    replaceTextInSubDirectoryCheckBox.Checked == true ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
                    {
                        processLabel.Text = file;
                        FileSystem.ReplaceText(file, replaceableTextBox.Text, replacementTextBox.Text);
                        progressBar.Value++;
                    }
                    processLabel.Text = "готово";
                }
                processLabel.Text = "Файл не найден или директория не найдены";
            }
        }

        private void directoryPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(pathTextBox.Text))
            {
                replaceTextInSubDirectoryLabel.Visible = false;
                replaceTextInSubDirectoryCheckBox.Visible = false;
            }
            else if (Directory.Exists(pathTextBox.Text))
            {
                replaceTextInSubDirectoryLabel.Visible = true;
                replaceTextInSubDirectoryCheckBox.Visible = true;
            }
        }
    }
}