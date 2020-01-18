using System;
using System.Collections.Generic;
using Recipes.Commands;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;

namespace Recipes.Views
{
    public partial class EditPage : ContentPage
    {
        public AddEditRecipeViewModel AddEditRecipeViewModel;

        public EditPage(AddEditRecipeViewModel recipeViewModel = null)
        {
            //Recipe
            InitializeComponent();

            AddEditRecipeViewModel = new AddEditRecipeViewModel(recipeViewModel.RecipeToEdit);

            BindingContext = AddEditRecipeViewModel;

            // subscribe to message center message sent after recipe add
            MessagingCenter.Subscribe<AddEditCommand, string>(this, "Updated", async (sender, message) =>
            {
                await MaterialDialog.Instance.SnackbarAsync(message: $"{message}", msDuration: MaterialSnackbar.DurationLong);
                await Navigation.PopToRootAsync();
            });
        }

        async void ToolbarItem_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void MaterialButton_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
