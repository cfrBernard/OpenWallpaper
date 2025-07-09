using System.Configuration;
using System.Data;
using System.Windows;
using OpenWallpaper.Services;

namespace OpenWallpaper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private SystrayService? _systrayService;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _systrayService = new SystrayService();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _systrayService?.Dispose();
            base.OnExit(e);
        }
    }

}
