using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using SharpCompress.Common;
using static System.IO.File;

namespace WindowsAutomatedSimplifier.DeCompress
{
    public partial class DeCompress
    {
        private List<NamedList> _list = ListManagement.Decompress;
        public DeCompress()
        {
            InitializeComponent();
            WindowManager.AddWindow(this);

            foreach (var item in _list)
                cob_archive.Items.Add(new ComboBoxItem { Content = item.Name });
        }

        private void cb_comp_decomp_Clicked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox?.IsChecked == true)
            {
                _list = ListManagement.Compress;
                checkBox.Content = "Compress";
            }
            else if (checkBox?.IsChecked == false)
            {
                _list = ListManagement.Decompress;
                checkBox.Content = "Decompress";
            }

            cob_archive.Items.Clear();

            foreach (var item in _list)
                cob_archive.Items.Add(new ComboBoxItem { Content = item.Name });

            cob_archive.SelectedIndex = 0;
        }

        private void cob_archive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cob_archive.SelectedIndex;
            cob_compress.Items.Clear();

            foreach (var item in _list[index < 0 ? 0 : index].List)
                cob_compress.Items.Add(new ComboBoxItem { Content = item });

            cob_compress.SelectedIndex = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ArchiveType archiveType;
            if (Enum.TryParse(cob_archive.SelectedItem.ToString(), out archiveType)) return;

            CompressionType compressionType;
            if (Enum.TryParse(cob_compress.SelectedItem.ToString(), out compressionType)) return;

            Button btn = sender as Button;
            if (btn != null && (cb_comp_decomp.IsChecked == true && btn.Name == "Compress"))
            {
                //Archive archive = new Archive();
                //archive.Compress(archiveType, compressionType);
            }
            else if (btn != null && (cb_comp_decomp.IsChecked == false && btn.Name == "Decompress"))
            {
                //Archive c = new Archive();
                //c.Decompress(archiveType, compressionType);
            }
        }

        private void OpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog { Multiselect = true };
            ofDialog.ShowDialog();

            string[] filenames = ofDialog.FileNames;

            if (filenames.Length == 1 && (GetAttributes(filenames[0]) & FileAttributes.Compressed) != 0)
                Console.WriteLine("Decompress");

            //Window.Name = filenames.Length == 1 ? "Decompress" : "Compress";

        }
    }
}
