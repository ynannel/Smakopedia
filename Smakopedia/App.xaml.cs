using System.Configuration;
using System.Data;
using System.Windows;
using Smakopedia.Models;

namespace Smakopedia;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static DataService DataService { get; private set; }
    public static UserSettings Settings { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        
        DataService = new DataService();
        Settings = DataService.LoadSettings();
        
        ApplySettings();
    }

    private void ApplySettings()
    {
        var resources = Application.Current.Resources;
        
        // Apply font settings
        resources["DefaultFontFamily"] = Settings.FontFamily;
        resources["DefaultFontSize"] = Settings.FontSize;

        // Apply colors
        resources["PrimaryColor"] = Settings.PrimaryColor;
        resources["SecondaryColor"] = Settings.SecondaryColor;
        resources["BackgroundColor"] = Settings.BackgroundColor;
        resources["TextColor"] = Settings.TextColor;

        // Apply theme
        if (Settings.DarkMode)
        {
            // You can implement dark mode logic here
        }
    }
}

