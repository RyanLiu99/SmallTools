using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SmallTools2.Util
{
    public class FileUtility
    {

        public static void ChangeFileEncoding(string folder, string from, string to, string  searchPattern, 
            Action<object> log)
        {
            var files = Directory.EnumerateFiles(folder, searchPattern, SearchOption.AllDirectories);

           Encoding readEncoding = System.Text.Encoding.GetEncoding(from);
           Encoding writeEncoding = System.Text.Encoding.GetEncoding(to);

 
            foreach(var filePath in files.AsParallel())
            {
                var content = File.ReadAllText(filePath, readEncoding);
                File.WriteAllText(filePath, content, writeEncoding);
                log(filePath);
            }
        }
    }
}
