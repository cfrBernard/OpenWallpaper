using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;

namespace OpenWallpaper.Services
{
    public class SystrayService : IDisposable
    {
        private NotifyIcon _notifyIcon;

        public SystrayService()
        {
            _notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Application,
                Visible = true,
                Text = "OpenWallpaper"
            };

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Afficher", null, OnShowClicked);
            contextMenu.Items.Add("Quitter", null, OnExitClicked);

            _notifyIcon.ContextMenuStrip = contextMenu;

            _notifyIcon.DoubleClick += OnShowClicked;
        }

        private void OnShowClicked(object? sender, EventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                var mainWindow = System.Windows.Application.Current.MainWindow;
                if (mainWindow != null)
                {
                    mainWindow.Show();
                    mainWindow.WindowState = System.Windows.WindowState.Normal;
                    mainWindow.Activate();
                }
            });
        }

        private void OnExitClicked(object? sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public void Dispose()
        {
            _notifyIcon.Dispose();
        }
    }
}
