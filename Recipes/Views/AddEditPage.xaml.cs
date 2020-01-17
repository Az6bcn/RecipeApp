using System;
using System.Collections.Generic;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class AddEditPage : ContentPage
    {
        public AddEditRecipeViewModel AddEditRecipeViewModel;

        public AddEditPage(AddEditRecipeViewModel recipeViewModel = null)
        {
            //Recipe
            InitializeComponent();

            AddEditRecipeViewModel = new AddEditRecipeViewModel(recipeViewModel.RecipeToEdit);

            BindingContext = AddEditRecipeViewModel;
        }

        async void ToolbarItem_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
