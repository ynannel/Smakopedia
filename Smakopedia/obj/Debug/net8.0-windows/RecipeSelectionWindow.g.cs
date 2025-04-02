﻿#pragma checksum "..\..\..\RecipeSelectionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2E68F8FB2C7A396887E7D047CF9A7EF3B11F93E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Smakopedia;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Smakopedia {
    
    
    /// <summary>
    /// RecipeSelectionWindow
    /// </summary>
    public partial class RecipeSelectionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecipesListBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RecipeTitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RecipeImage;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RecipeDescriptionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox IngredientsListBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox InstructionsListBox;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\RecipeSelectionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RecipeDetailsTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Smakopedia;component/recipeselectionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RecipeSelectionWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RecipesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 26 "..\..\..\RecipeSelectionWindow.xaml"
            this.RecipesListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipesListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RecipeTitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.RecipeImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.RecipeDescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.IngredientsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.InstructionsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.RecipeDetailsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 118 "..\..\..\RecipeSelectionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartCookingButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 149 "..\..\..\RecipeSelectionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

