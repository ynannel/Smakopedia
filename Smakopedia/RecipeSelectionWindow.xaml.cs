using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Smakopedia.Models;

namespace Smakopedia
{
    /// <summary>
    /// Logika interakcji dla klasy RecipeSelectionWindow.xaml
    /// </summary>
    public partial class RecipeSelectionWindow : Window
    {
        private List<Recipe> recipes;
        private Recipe selectedRecipe;

        public RecipeSelectionWindow()
        {
            InitializeComponent();
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            recipes = App.DataService.LoadRecipes();
            RecipesListBox.ItemsSource = recipes;
        }

        private void RecipesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedRecipe = RecipesListBox.SelectedItem as Recipe;
            if (selectedRecipe != null)
            {
                UpdateRecipeDetails();
            }
        }

        private void UpdateRecipeDetails()
        {
            // Set basic information
            RecipeTitleTextBlock.Text = selectedRecipe.Title;
            RecipeDescriptionTextBlock.Text = selectedRecipe.Description;
            
            // Load image
            if (!string.IsNullOrEmpty(selectedRecipe.ImagePath))
            {
                RecipeImage.Source = new BitmapImage(new Uri(selectedRecipe.ImagePath));
            }

            // Load ingredients
            IngredientsListBox.Items.Clear();
            foreach (var ingredient in selectedRecipe.Ingredients)
            {
                IngredientsListBox.Items.Add(ingredient);
            }

            // Load instructions
            InstructionsListBox.Items.Clear();
            foreach (var instruction in selectedRecipe.Instructions)
            {
                InstructionsListBox.Items.Add(instruction);
            }

            // Set additional information
            RecipeDetailsTextBlock.Text = $"Preparation Time: {selectedRecipe.PreparationTime} min\n" +
                                       $"Cooking Time: {selectedRecipe.CookingTime} min\n" +
                                       $"Servings: {selectedRecipe.Servings}\n" +
                                       $"Difficulty: {selectedRecipe.Difficulty}\n" +
                                       $"Category: {selectedRecipe.Category}";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRecipe == null)
            {
                MessageBox.Show("Please select a recipe to delete.", "No Recipe Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this recipe?", "Confirm Delete", 
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                recipes.Remove(selectedRecipe);
                App.DataService.SaveRecipes(recipes);
                LoadRecipes();
                selectedRecipe = null;
                UpdateRecipeDetails();
            }
        }

        private void StartCookingButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRecipe == null)
            {
                MessageBox.Show("Please select a recipe to start cooking.", "No Recipe Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var cookingWindow = new CookingWindow(selectedRecipe);
            cookingWindow.Show();
            this.Close();
        }
    }
}
