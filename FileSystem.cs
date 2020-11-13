using System.IO;
using System.Text;

namespace TextReplacementer
{
    class FileSystem
    {
        //Алгоритм подсчета файлов в директории
        public static int GetNumberOfFiles(string path, bool checkAllDirectories = false)
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

        //Алгоритм поиска и замены текста в файле
        public static void ReplaceText(string filePath, string replaceableText, string replacementText)
        {
            string tempFilePath = "temp";

            //Поток для чтения исходного файла
            using (StreamReader sourceFileReader = new StreamReader(filePath))
            {
                //Поток для записи во временный файл отредактированного текста
                using (StreamWriter tempFileWriter = new StreamWriter(tempFilePath))
                {
                    string tempStr = null;
                    char currentChar;

                    //Посимвольное чтение и сравнения содержимого файла с заменяемым текстом
                    for (int i = 0; i < replaceableText.Length && !sourceFileReader.EndOfStream; i++)
                    {
                        currentChar = (char)sourceFileReader.Read();
                        tempStr += currentChar;

                        if (tempStr == replaceableText)
                        {
                            tempFileWriter.Write(replacementText);
                            tempFileWriter.Flush();
                            tempStr = null;
                            i = -1;
                        }
                        else if (replaceableText[i] != currentChar)
                        {
                            tempFileWriter.Write(tempStr);
                            tempFileWriter.Flush();
                            tempStr = null;
                            i = -1;
                        }
                    }
                }
            }

            //Замена исходного файла отредактированным
            File.Delete(filePath);
            File.Move(tempFilePath, filePath);
        }

        //Алгоритм получения кодировки файла.
        //Не реализован в текущей версии
        public static Encoding GetFileEncoding(string filePath)
        {
            return Encoding.Default;
        }
    }
}
