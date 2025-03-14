using System;
using System.Windows;
using System.Windows.Input;

namespace Smakopedia;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }

    private void OpenRecipeSelection_Click(object sender, RoutedEventArgs e)
    {
        RecipeSelectionWindow recipeWindow = new RecipeSelectionWindow();
        recipeWindow.Show();
    }

    private void CreateRecipeWindow_Click(object sender, RoutedEventArgs e)
    {
        CreateRecipeWindow recipeWindow = new CreateRecipeWindow();
        recipeWindow.Show();
    }

}