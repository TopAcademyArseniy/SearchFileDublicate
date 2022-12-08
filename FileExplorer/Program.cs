namespace FileExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryData dirData = new DirectoryData("D:\\Users\\winpx\\downloads");
            foreach (var data in dirData.getFileDatas())
            {
                Console.WriteLine(data);
            }
        }
    }
}