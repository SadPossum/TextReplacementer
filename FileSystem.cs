using System.IO;
using System.Text;

namespace TextReplacementer
{
    class FileSystem
    {
        public static int GetNumberOfFiles(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
                return directoryInfo.GetFiles("*", SearchOption.AllDirectories).Length;
            else if (File.Exists(path))
                return 1;
            else
                return 0;
        }

        public static int GetNumberOfFiles(string path, bool checkAllDirectories)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                if (checkAllDirectories == false)
                    return directoryInfo.GetFiles("*", SearchOption.AllDirectories).Length;
                else
                    return directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly).Length;
            }
            else if (File.Exists(path))
                return 1;
            else
                return 0;
        }

        public static void ReplaceText(string filePath, string replaceableText, string replacementText)
        {
            string tempFilePath = "temp";

            using (StreamReader sourceFileReader = new StreamReader(filePath))
            {
                using (StreamWriter tempFileWriter = new StreamWriter(tempFilePath))
                {
                    string tempStr = null;
                    char currentChar;
                    for (int i = 0; i < replaceableText.Length && !sourceFileReader.EndOfStream; i++)
                    {
                        currentChar = (char)sourceFileReader.Read();
                        tempStr += currentChar;
                    
                        if (tempStr == replaceableText)
                        {
                            tempFileWriter.Write(replacementText);
                            tempStr = null;
                            i = -1;
                        }
                        else if (replaceableText[i] != currentChar)
                        {
                            tempFileWriter.Write(tempStr);
                            tempStr = null;
                            i = -1;
                        }
                    }
                }
            }

            File.Delete(filePath);
            File.Move(tempFilePath, filePath);
        }
    }
}
