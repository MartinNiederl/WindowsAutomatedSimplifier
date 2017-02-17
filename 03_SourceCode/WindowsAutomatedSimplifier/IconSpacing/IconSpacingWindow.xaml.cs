using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WindowsAutomatedSimplifier.Repository;

namespace WindowsAutomatedSimplifier.IconSpacing
{
    public partial class IconSpacingWindow
    {
        private readonly IconSpacingLogic _isLogic;
        public IconSpacingWindow()
        {
            InitializeComponent();
            _isLogic = new IconSpacingLogic();
            HSlider.Value = _isLogic.GetSpacing() * -1;
            VSlider.Value = _isLogic.GetVerticalSpacing() * -1;

            WindowManager.AddWindow(this);
        }

        private void ApplyChangesBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _isLogic.EditSpacing((int) HSlider.Value * -1, (int) VSlider.Value * -1);
            if (ExpCheckBox.IsChecked == true)  Task.Factory.StartNew(IconSpacingLogic.RestartExplorer);
            Close();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as MenuItem)?.Name == "Default")
            {
                HSlider.Value = 1710;
                VSlider.Value = 1125;
            }
            else if ((sender as MenuItem)?.Name == "Reset")
            {
                HSlider.Value = _isLogic.GetSpacing() * -1;
                VSlider.Value = _isLogic.GetVerticalSpacing() * -1;
            }
        }
    }
}
