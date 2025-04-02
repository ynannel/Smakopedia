using System.Windows.Media;

namespace Smakopedia.Models
{
    public class UserSettings
    {
        public string FontFamily { get; set; } = "Segoe UI";
        public double FontSize { get; set; } = 14;
        public string PrimaryColor { get; set; } = "#FF007ACC";
        public string SecondaryColor { get; set; } = "#FF5C2D91";
        public string BackgroundColor { get; set; } = "#FFFFFFFF";
        public string TextColor { get; set; } = "#FF000000";
        public bool DarkMode { get; set; } = false;
    }
} 