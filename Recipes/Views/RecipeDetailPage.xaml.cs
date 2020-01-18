using System;
using System.Collections.Generic;
using System.Data;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class RecipeDetailPage : ContentPage
    {
        private RecipeDetailsViewModel _recipeDetailsViewModel;
        public List<string> test { get; set; }

        public RecipeDetailPage(RecipeDetailsViewModel recipe = null)
        {
            InitializeComponent();

            _recipeDetailsViewModel = recipe ?? new RecipeDetailsViewModel(new Recipe());

            Title = _recipeDetailsViewModel.RecipeReceived.Name;

            BindingContext = _recipeDetailsViewModel;
        }

        public async void ToolbarItem_Clicked(Object sender, EventArgs e)
        {
            if (_recipeDetailsViewModel.RecipeReceived == null) return;

            _recipeDetailsViewModel.RecipeReceived.IsNew = false;

            await Navigation.PushAsync(new
                EditPage(new AddEditRecipeViewModel
                {
                  
                    RecipeToEdit = _recipeDetailsViewModel.RecipeReceived
                })
            );
        }

    }
}
