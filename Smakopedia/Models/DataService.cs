using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace Smakopedia.Models
{
    public class DataService
    {
        private readonly string _settingsPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Smakopedia",
            "settings.json"
        );
        private readonly string _recipesPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Smakopedia",
            "recipes.json"
        );

        public DataService()
        {
            var directory = Path.GetDirectoryName(_settingsPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public void SaveSettings(UserSettings settings)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(settings, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(_settingsPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public UserSettings LoadSettings()
        {
            try
            {
                if (File.Exists(_settingsPath))
                {
                    var jsonString = File.ReadAllText(_settingsPath);
                    return JsonSerializer.Deserialize<UserSettings>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return new UserSettings();
        }

        public void SaveRecipes(List<Recipe> recipes)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(recipes, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(_recipesPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving recipes: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public List<Recipe> LoadRecipes()
        {
            try
            {
                if (File.Exists(_recipesPath))
                {
                    var jsonString = File.ReadAllText(_recipesPath);
                    return JsonSerializer.Deserialize<List<Recipe>>(jsonString) ?? new List<Recipe>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recipes: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return new List<Recipe>();
        }
    }
} 