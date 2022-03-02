using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To FileIO Program");
            FileExists();
            ReadAllLines();
            ReadAllText();
            FileCopy();
            DeleteFile();
            ReadFromStreamReader();
        }
        public static void FileExists()
        {
            string path = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines()
        {
            string path = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            string path = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\Example.txt";
            string lines;
            lines = File.ReadAllText(path);

            Console.WriteLine(lines);
            Console.ReadKey();
        }
        public static void FileCopy()
        {
            string path = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\Example.txt";
            string copypath = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\TextFile1.txt";
            File.Copy(path, copypath);
            Console.ReadKey();
        }
        public static void DeleteFile()
        {
            string path = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\Example.txt";
            File.Delete(path);
            Console.ReadKey();
        }
        public static void ReadFromStreamReader()
        {
            string path = @"F:\Bridgelabz\FileIODemo\FileDemo\FileDemo\Example.txt";
            using(StreamReader stream = File.OpenText(path))
            {
                string s = "";
                while((s=stream.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
    
}
