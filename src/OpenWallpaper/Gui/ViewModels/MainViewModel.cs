using System.Collections.ObjectModel;
using System.ComponentModel;
using OpenWallpaper.Models;

namespace OpenWallpaper.Gui.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<WallpaperEntry> Wallpapers { get; set; }

        public MainViewModel()
        {
            Wallpapers = new ObservableCollection<WallpaperEntry>
            {
                new WallpaperEntry { VideoPath = "Assets/DefaultMp4/video1.mp4", Artist = "Jane Doe", Name = "Sunset Chill" },
                new WallpaperEntry { VideoPath = "Assets/DefaultMp4/video2.mp4", Artist = "John Smith", Name = "Neon City" },
                new WallpaperEntry { VideoPath = "Assets/DefaultMp4/video3.mp4", Artist = "Unknown", Name = "Ocean Calm" },
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
