using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Smakopedia.Models;

namespace Smakopedia
{
    public partial class CreateRecipeWindow : Window
    {
        private string imagePath = string.Empty;
        private List<string> ingredients = new List<string>();
        private List<string> instructions = new List<string>();

        public CreateRecipeWindow()
        {
            InitializeComponent();
        }

        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
                RecipeImage.Source = new BitmapImage(new Uri(imagePath));
            }
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewIngredientTextBox.Text))
            {
                ingredients.Add(NewIngredientTextBox.Text);
                IngredientsListBox.Items.Add(NewIngredientTextBox.Text);
                NewIngredientTextBox.Clear();
            }
        }

        private void AddInstruction_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewInstructionTextBox.Text))
            {
                instructions.Add(NewInstructionTextBox.Text);
                InstructionsListBox.Items.Add(NewInstructionTextBox.Text);
                NewInstructionTextBox.Clear();
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(RecipeNameTextBox.Text) || 
                string.IsNullOrWhiteSpace(RecipeDescriptionTextBox.Text) || 
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill in the recipe name, description and choose an image.", 
                              "Missing Information", 
                              MessageBoxButton.OK, 
                              MessageBoxImage.Warning);
                return;
            }

            // Validate numeric fields
            if (!int.TryParse(PreparationTimeTextBox.Text, out int prepTime) ||
                !int.TryParse(CookingTimeTextBox.Text, out int cookTime) ||
                !int.TryParse(ServingsTextBox.Text, out int servings))
            {
                MessageBox.Show("Please enter valid numbers for preparation time, cooking time, and servings.", 
                              "Invalid Input", 
                              MessageBoxButton.OK, 
                              MessageBoxImage.Warning);
                return;
            }

            // Get selected difficulty and category
            if (DifficultyComboBox.SelectedItem == null || CategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select difficulty and category.", 
                              "Missing Information", 
                              MessageBoxButton.OK, 
                              MessageBoxImage.Warning);
                return;
            }

            string difficulty = (DifficultyComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string category = (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(difficulty) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select difficulty and category.", 
                              "Missing Information", 
                              MessageBoxButton.OK, 
                              MessageBoxImage.Warning);
                return;
            }

            // Create new recipe
            var newRecipe = new Recipe
            {
                Title = RecipeNameTextBox.Text,
                Description = RecipeDescriptionTextBox.Text,
                ImagePath = imagePath,
                Ingredients = ingredients,
                Instructions = instructions,
                PreparationTime = prepTime,
                CookingTime = cookTime,
                Servings = servings,
                Difficulty = difficulty,
                Category = category
            };

            // Get current recipes list
            var recipes = App.DataService.LoadRecipes();
            // Add new recipe
            recipes.Add(newRecipe);
            // Save updated list
            App.DataService.SaveRecipes(recipes);

            MessageBox.Show("Recipe has been saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear all fields
            RecipeNameTextBox.Clear();
            RecipeDescriptionTextBox.Clear();
            RecipeImage.Source = null;
            imagePath = string.Empty;
            ingredients.Clear();
            instructions.Clear();
            IngredientsListBox.Items.Clear();
            InstructionsListBox.Items.Clear();
            NewIngredientTextBox.Clear();
            NewInstructionTextBox.Clear();
            PreparationTimeTextBox.Clear();
            CookingTimeTextBox.Clear();
            ServingsTextBox.Clear();
            DifficultyComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;

            // Close window
            this.Close();
        }
    }
}
