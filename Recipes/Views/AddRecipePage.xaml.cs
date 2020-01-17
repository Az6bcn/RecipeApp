using System;
using System.Collections.Generic;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class AddRecipePage : ContentPage
    {
        private AddEditRecipeViewModel AddEditRecipeViewModel;

        public AddRecipePage()
        {
            InitializeComponent();

            BindingContext = AddEditRecipeViewModel = new AddEditRecipeViewModel();
        }
    }
}
