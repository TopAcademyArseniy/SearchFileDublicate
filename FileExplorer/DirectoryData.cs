using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;



namespace FileExplorer
{

    internal class DirectoryData
    {
        private List<FileData> fileDatas;
        private string directory;

        public DirectoryData(string dir)
        {
            directory = dir;
            fileDatas = new List<FileData>();

            string[] files = Directory.GetFiles(dir);
            foreach(string file in files)
            {
                FileInfo fileInf = new FileInfo(file);
                fileDatas.Add(new FileData(fileInf));
            }

        }

        public List<FileData> getFileDatas()
        {
            return new List<FileData>(fileDatas);
        }

    }
}
