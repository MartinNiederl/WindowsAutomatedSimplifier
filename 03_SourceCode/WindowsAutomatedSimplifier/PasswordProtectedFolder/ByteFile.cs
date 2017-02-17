using System;
using System.IO;

namespace WindowsAutomatedSimplifier.PasswordProtectedFolder
{
    internal class ByteFile
    {
        public string Name { get; }
        public string Path { get; }
        public string RelativePath { get; }
        public byte[] Content { get; }
        public int Length { get; }

        public ByteFile(string path, string root)
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists) return;
            Content = File.ReadAllBytes(path);
            Length = Content.Length;
            if (file.Length != Length) throw new Exception("Error when reading the file! File sizes are not same!");
            Path = path;
            RelativePath = GetRelativePath(path, root);
            Name = path.Substring(path.LastIndexOf(@"\", StringComparison.Ordinal));
        }
        public static string GetRelativePath(string path, string root) => path.Substring(root.Length);

        public override string ToString() => RelativePath + "?" + Length;
    }
}
