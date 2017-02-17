using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsAutomatedSimplifier.PasswordProtectedFolder
{
    internal class ProtectedFolder
    {
        private readonly List<ByteFile> _files = new List<ByteFile>();
        public ProtectedFolder(string directory)
        {
            DirectoryInfo di = new DirectoryInfo(directory);

            foreach (FileInfo fileInfo in di.GetFiles("*", SearchOption.AllDirectories))
                try { _files.Add(new ByteFile(fileInfo.FullName, directory)); }
                catch { }

            CreateFile(@"C:\Users\Mani\Documents\Schule\Projektentwicklung\Comp.pwf");
            FolderReader folderReader = new FolderReader(@"C:\Users\Mani\Documents\Schule\Projektentwicklung\Comp.pwf");
        }
        public void CreateFile(string path)
        {
            byte[] bytes = Combine(Encoding.UTF8.GetBytes(CreateHeader()));
            //TODO add encryption function
            File.WriteAllBytes(path, bytes);
        }
        private string CreateHeader()
        {
            StringBuilder sb = new StringBuilder();
            int position = 0 ;
            foreach (ByteFile file in _files)
            {
                sb.Append(file + "?" + position + Environment.NewLine);
                position += file.Length;
            }
            return sb + "--header_end--" + Environment.NewLine;
        }
        private byte[] Combine(byte[] header)
        {
            ByteFile[] arrays = _files.ToArray();
            
            byte[] rv = new byte[arrays.Sum(a => a.Length) + header.Length];
            Buffer.BlockCopy(header, 0, rv, 0, header.Length);
            int offset = header.Length;
            foreach (ByteFile t in arrays)
            {
                var array = t.Content;
                Buffer.BlockCopy(array, 0, rv, offset, array.Length);
                offset += array.Length;
            }
            return rv;
        }
        public void Print()
        {
            foreach (ByteFile file in _files)
                Console.WriteLine(@"RelPath: " + file.RelativePath + @" Length: " + file.Length);
        }
    }
}
