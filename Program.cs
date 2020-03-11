using ET_4_FileParser.Logics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_4_FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu.ShowConsoleMenu(args);
            //using(FileParser fileParser = new FileParser())
            //{
            //    fileParser.OpenFile("Test.txt");
            //    foreach(string str in fileParser.FindLines("search string"))
            //    {
            //        Console.WriteLine(str);
            //    }
            //}
            //Console.ReadLine();
            //FileParser fileParser = new FileParser();
            //fileParser.
            //string target = "search string";
            //string replace = "SimpleString";
            ////var file = new StreamReader("Test.txt");
            ////FileStream file = new FileStream("Test.txt", FileMode.OpenOrCreate);
            //File.Create("TestTemp.txt").Close();
            
            ////file.
            //using (var reader = new StreamReader("Test.txt", Encoding.UTF8))
            //{
            //    using (var writer = new StreamWriter("TestTemp.txt", false))
            //    {
            //        string str;
            //        while (!reader.EndOfStream)
            //        {
            //            str = reader.ReadLine();
            //            //if (str.Contains(target))
            //            //{
            //            str = str.Replace(target, replace);
            //            writer.WriteLine(str);
            //            //}
            //        }
            //    }
            //}
            ////File.Copy("TestTemp.txt", "Test.txt", true);
            ////Console.ReadLine();
            ////StreamWriter streamWriter = new StreamWriter("das");
            ////streamWriter.
            ////foreach(string str in file)
            ////{

            ////}
            ////file.ReadLine
        }
    }
}
