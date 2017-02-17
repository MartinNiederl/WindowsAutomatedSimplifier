using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using WindowsAutomatedSimplifier.DeCompress;
using WindowsAutomatedSimplifier.IconSpacing;
using WindowsAutomatedSimplifier.PasswordProtectedFolder;
using WindowsAutomatedSimplifier.Repository;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace WindowsAutomatedSimplifier
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowManager.AddWindow(this);
            InitRegistry();
        }

        /// <summary>
        /// Event for decommpressing files
        /// </summary>
        private void Btn_compress_OnClick(object sender, RoutedEventArgs e)
        {
            //Open new window for compress interaction
            new CompressWindow().ShowDialog();
        }

        /// <summary>
        /// Event for decompressing files
        /// </summary>
        private void Btn_decompress_OnClick(object sender, RoutedEventArgs e)
        {
            //Dialog for selecting the file for decompressing
            OpenFileDialog ofDialog = new OpenFileDialog { Filter = "Archive Files (*.7z;*.rar;*.tar;*.zip;*.gz)|*.7z;*.rar;*.tar;*.zip;*.gz" };
            if (ofDialog.ShowDialog() == false) return;

            //Dialog for selecting the folder where the decompressed files should get stored
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if (fbDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            Archive archive = new Archive(new List<FileInfo> { new FileInfo(ofDialog.FileName) });
            archive.Decompress(fbDialog.SelectedPath);

            //MessageBox to confirm the functionality (closes after 1 second)
            AutoClosingMessageBox.Show("Finished Successfully", "Closing...", 1000);
        }

        private void BtnIconSpacing_OnClick(object sender, RoutedEventArgs e)
        {
            new IconSpacingWindow().ShowDialog();
        }

        private void BtnCreateProtectedFolder_Click(object sender, RoutedEventArgs e)
        {
            //FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            //if (fbDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            //new ProtectedFolder(fbDialog.SelectedPath);
            new ProtectedFolder(@"C:\Users\Mani\Documents\Schule\Projektentwicklung\PWF TestOrdner");
        }

        private static void InitRegistry()
        {
            RegistryAPI api = new RegistryAPI();
            api.AddKey(@"HKEY_CURRENT_USER\Software\Classes\directory\shell\", "WAS", "Verschlüsseln");
        }
    }
}
