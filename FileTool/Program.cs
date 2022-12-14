using System;
using System.IO;

namespace FileTool
{
    internal class Program
    {
        private static string path = @"G:\Games\Others\Temp\";
        private static string keyword = "dq";
        private static string replacement = "wa";
        private static DirectoryInfo directory;
        private static FileInfo[] fileInfos;

        public static void Main(string[] args)
        {
            directory = Directory.GetParent(path);
            fileInfos = directory.GetFiles();
            Recount();
            Console.WriteLine();
        }

        /*
         * 替换文件名关键字
         */
        public static void ReplaceKeyword()
        {
            foreach (FileInfo fileInfo in fileInfos)
            {
                fileInfo.MoveTo(fileInfo.DirectoryName + @"\" + fileInfo.Name.Replace(keyword, replacement));
            }
        }

        /*
         * 前缀相同的文件重新计数
         */
        public static void Recount()
        {
            string pre = null;
            short index = 1;
            foreach (FileInfo fileInfo in fileInfos)
            {
                string temp = fileInfo.Name.Substring(0, fileInfo.Name.Replace(fileInfo.Extension, "").Length - 3);
                if (string.IsNullOrEmpty(pre))
                {
                    pre = temp;
                }

                if (!string.Equals(pre, temp))
                {
                    index = 1;
                    pre = temp;
                }

                string suf = index.ToString();
                while (suf.Length < 3)
                {
                    suf = "0" + suf;
                }

                fileInfo.MoveTo(fileInfo.DirectoryName + @"\" + pre + suf + fileInfo.Extension);
                index++;
            }
        }
    }
}