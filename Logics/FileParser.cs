using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_4_FileParser.Logics
{
    class FileParser : IDisposable
    {
        private StreamReader reader;
        private StreamWriter writer;
        private string mainFilePath;
        private string tempFilePath = "Test";
         
        public void Dispose()
        {
            reader.Dispose();
            writer.Dispose();
        }

        public void OpenFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found");
            }
            mainFilePath = filePath;
            reader = new StreamReader(mainFilePath);
            writer = new StreamWriter(tempFilePath, false);
        }

        public string[] FindLines(string target)
        {
            if (reader == null)
            {
                throw new InvalidOperationException("The file is not open. " +
                    "Use OpenFile() first");
            }
            if (reader.EndOfStream)
            {
                throw new InvalidDataException("File already read. " +
                    "Use OpenFile() again");
            }
            
            List<string> matchStrs = new List<string>();
            string temp;
            while (!reader.EndOfStream)
            {
                temp = reader.ReadLine();
                if (temp.Contains(target))
                {
                    matchStrs.Add(temp);
                }
            }

            return matchStrs.ToArray();
        }

        public void ReplaceLines(string target, string newStr)
        {
            if (reader == null || writer == null)
            {
                throw new InvalidOperationException("The file is not open. " +
                    "Use OpenFile() first");
            }
            if (reader.EndOfStream)
            {
                throw new InvalidDataException("File already read. " +
                    "Use OpenFile() again");
            }

            string temp;
            while (!reader.EndOfStream)
            {
                temp = reader.ReadLine();
                temp = temp.Replace(target, newStr);
                writer.WriteLine(temp);
            }

            reader.Close();
            writer.Close();
            File.Copy(tempFilePath, mainFilePath, true);
            File.Delete(tempFilePath);
        }
    }
}
