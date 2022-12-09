using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    internal class FileData
    {
        //Необходимо реализовать информационную
        //систему «Поиск дубликатов файлов»
        //с учетом одного или нескольких из следующих
        //атрибутов: имя, дата создания/изменения, размер

        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public long Size { get; set; }


        public FileData(string name, DateTime creationTime, long size)
        {
            Name = name;
            CreationTime = creationTime;
            Size = size;
        }

        public FileData(FileInfo info)
        {
            Name = info.Name;
            CreationTime = info.CreationTime;
            Size = info.Length;
        }

        public override string ToString()
        {
            return $"Filename:\t{Name}, Creation time:\t{CreationTime}, File size:\t{Size} bytes ";
        }
    }
}
