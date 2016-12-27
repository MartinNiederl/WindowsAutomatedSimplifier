using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using SharpCompress.Archive;
using SharpCompress.Archive.Zip;
using SharpCompress.Common;
using SharpCompress.Compressor.Deflate;
using SharpCompress.Writer;


namespace WindowsAutomatedSimplifier.DeCompress
{
    internal class Archive
    {
        private List<FileInfo> FileList { get; } = new List<FileInfo>();

        public Archive(List<FileInfo> fileList)
        {
            FileList = fileList;
        }

        public Archive(Type type)
        {
            switch (type)
            {
                case Type.Compress:
                    {
                        OpenFileDialog ofDialog = new OpenFileDialog { Multiselect = true };
                        if (ofDialog.ShowDialog() == false) return;

                        foreach (string filename in ofDialog.FileNames)
                            FileList.Add(new FileInfo(filename));
                    }
                    break;
                case Type.Decompress:
                    {
                        OpenFileDialog ofDialog = new OpenFileDialog { Filter = "Archive Files (*.7z;*.rar;*.tar;*.zip;*.gz)|*.7z;*.rar;*.tar;*.zip;*.gz" };
                        if (ofDialog.ShowDialog() == false) return;

                        FileList.Add(new FileInfo(ofDialog.FileName));
                    }
                    break;
            }
            DeCompress dc = new DeCompress();
            dc.Show();
            WindowManager.CloseFirstOpenedWindow();
        }

        public void Compress(ArchiveType archive, CompressionType compression)
        {
            using (FileStream outFile = File.OpenWrite("M:\\Compress"))
            using (IWriter writer = WriterFactory.Open(outFile, archive, compression))
            {
                foreach (var filePath in FileList)
                {
                    //writer.WriteAll(Path.GetFileName(""), "*", SearchOption.AllDirectories);
                }
            }

            using (FileStream outFile = File.OpenWrite("M:\\Compress1.zip"))
            using (var archiver = ZipArchive.Create())
            {
                archiver.AddAllFromDirectory("M:\\Cursor Packs");
                archiver.SaveTo(outFile, new CompressionInfo
                {
                    DeflateCompressionLevel = CompressionLevel.BestCompression,
                    Type = compression
                });
            }
        }

        public void Decompress(ArchiveType archiveType, CompressionType compression)
        {
            IArchive archive = ArchiveFactory.Open(FileList[0].FullName);
            foreach (var entry in archive.Entries)
            {
                if (entry.IsDirectory) continue;
                Console.WriteLine(entry.FilePath);
                entry.WriteToDirectory(@"M:\temp", ExtractOptions.ExtractFullPath | ExtractOptions.Overwrite);
            }
        }

        public enum Type
        {
            Compress, Decompress
        }
    }
}
