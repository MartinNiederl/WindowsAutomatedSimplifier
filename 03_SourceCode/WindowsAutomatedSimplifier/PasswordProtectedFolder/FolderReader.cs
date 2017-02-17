using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsAutomatedSimplifier.PasswordProtectedFolder
{
    internal class FolderReader
    {
        private readonly string _path;
        private readonly List<Header> _header = new List<Header>();
        private readonly int _headerlength = 14 + Environment.NewLine.Length;
        public FolderReader(string path)
        {
            _path = path;
            foreach (string line in File.ReadLines(_path))
            {
                if (line.StartsWith("--header_end--")) break;
                _headerlength += line.Length + Environment.NewLine.Length;
                string[] buf = line.Split('?');
                _header.Add(new Header(buf[0], buf[1], buf[2]));
            }
        }

        public byte[] ReadFileByIndex(int index) => ReadFromPosition(_header[index].Position, _header[index].Length);

        private byte[] ReadFromPosition(int position, int length)
        {
            byte[] data = new byte[length];
            using (FileStream fs = new FileStream(_path, FileMode.Open))
            {
                fs.Position = position + _headerlength;
                int actualRead = 0;
                do {
                    actualRead += fs.Read(data, actualRead, length - actualRead);
                } while (actualRead != length && fs.Position < fs.Length);
            }
            return data;
        }

        public bool SaveFileByIndex(int index)
        {
            try {
                File.WriteAllBytes(@"C:\Users\Mani\Documents\Schule\Projektentwicklung" + _header[index].Filename, ReadFileByIndex(index));
            }
            catch (ArgumentOutOfRangeException) {
                return false;
            }
            return true;
        }
    }

    public struct Header
    {
        public Header(string path, string length, string position)
        {
            Path = path;
            Filename = path.Substring(path.LastIndexOf(@"\", StringComparison.Ordinal));
            Length = int.Parse(length);
            Position = int.Parse(position);
        }

        public string Path { get;}
        public string Filename { get; }
        public int Position { get; }
        public int Length { get; }
    }
}
