using System.Diagnostics;
using System.Net;

using Dublicates = System.Collections.Generic.List<FileExplorer.FileData>;


namespace FileExplorer
{
    internal class Program
    {
        static void printFileDublicates(List<Dublicates> fileDatas, DublicateDetect.SortBy sortBy)
        {
            ConsoleColor clr = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"GROUPED BY: {sortBy.ToString()}"); 
            foreach (List<FileData> fileData in fileDatas)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tNEW GROUP OF DUBLICATES");
                Console.ForegroundColor = clr;
                foreach (FileData file in fileData)
                {
                    foreach(string param in file.ToString().Split(", "))
                    {
                        Console.WriteLine("\t\t>" + param);
                    }
                    Console.WriteLine();                    
                }
                
            }

        }


        static void Main(string[] args)
        {
            DirectoryData dirData = new DirectoryData("D:\\Users\\winpx\\downloads\\TestData");
            foreach (var data in dirData.getFileDatas())
            {
                //Console.WriteLine(data);
            }

            printFileDublicates(DublicateDetect.getDublicates(dirData.getFileDatas(), DublicateDetect.SortBy.TIME),
                DublicateDetect.SortBy.TIME);
            printFileDublicates(DublicateDetect.getDublicates(dirData.getFileDatas(), DublicateDetect.SortBy.NAME),
                DublicateDetect.SortBy.NAME);
            printFileDublicates(DublicateDetect.getDublicates(dirData.getFileDatas(), DublicateDetect.SortBy.LENGTH),
                DublicateDetect.SortBy.LENGTH);
            
        }
    }
}