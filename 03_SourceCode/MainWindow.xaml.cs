using System.Windows;
using WindowsAutomatedSimplifier.DeCompress;

namespace WindowsAutomatedSimplifier
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowManager.AddWindow(this);
        }

        private void Btn_compress_OnClick(object sender, RoutedEventArgs e)
        {
            new Archive(Archive.Type.Compress);
        }

        private void Btn_decompress_OnClick(object sender, RoutedEventArgs e)
        {
            new Archive(Archive.Type.Decompress);
        }
    }
}
