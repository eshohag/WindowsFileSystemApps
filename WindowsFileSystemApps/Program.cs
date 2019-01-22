using System;
using System.IO;

namespace WindowsFileSystemApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a DirectoryInfo object
            DirectoryInfo aDirectoryInfo = new DirectoryInfo(@"C:\Windows");

            // getting the files in the directory, their names and size
            FileInfo[] f = aDirectoryInfo.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine($"File Name: {file.Name} Size: {file.Length} kb");
            }

            Console.ReadKey();
        }
    }
}
