using System;
using System.Collections.Generic;
using Recipes.Commands;
using Recipes.ViewModels;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;

namespace Recipes.Views
{
    public partial class AddRecipePage : ContentPage
    {
        private AddEditRecipeViewModel AddEditRecipeViewModel;

        public AddRecipePage()
        {
            InitializeComponent();

            BindingContext = AddEditRecipeViewModel = new AddEditRecipeViewModel();

            // subscribe to message center message sent after recipe add
            MessagingCenter.Subscribe<AddCommand, string>(this, "Save", async (sender, message) =>
            {
                await MaterialDialog.Instance.AlertAsync(message: $"{message}", title: "Recipe");

                await Navigation.PopToRootAsync();
            });

        }

        async void MaterialButton_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(animated: true);
        }
    }
}
