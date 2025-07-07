using System.Windows;
using OpenWallpaper.Gui.ViewModels;

namespace OpenWallpaper.Gui.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
