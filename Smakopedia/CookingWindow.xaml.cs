using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Smakopedia.Models;

namespace Smakopedia
{
    public partial class CookingWindow : Window
    {
        private Recipe currentRecipe;

        public CookingWindow(Recipe recipe)
        {
            InitializeComponent();
            currentRecipe = recipe;
            LoadRecipe();
        }

        private void LoadRecipe()
        {
            // Set basic information
            RecipeTitleTextBlock.Text = currentRecipe.Title;
            RecipeDescriptionTextBlock.Text = currentRecipe.Description;
            
            // Load image
            if (!string.IsNullOrEmpty(currentRecipe.ImagePath))
            {
                RecipeImage.Source = new BitmapImage(new Uri(currentRecipe.ImagePath));
            }

            // Load ingredients
            foreach (var ingredient in currentRecipe.Ingredients)
            {
                IngredientsListBox.Items.Add(ingredient);
            }

            // Load instructions
            foreach (var instruction in currentRecipe.Instructions)
            {
                InstructionsListBox.Items.Add(instruction);
            }

            // Set additional information
            RecipeDetailsTextBlock.Text = $"Preparation Time: {currentRecipe.PreparationTime} min\n" +
                                       $"Cooking Time: {currentRecipe.CookingTime} min\n" +
                                       $"Servings: {currentRecipe.Servings}\n" +
                                       $"Difficulty: {currentRecipe.Difficulty}\n" +
                                       $"Category: {currentRecipe.Category}";
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enjoy your meal!", "Cooking Complete", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
} 