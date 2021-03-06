﻿using System;
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

            AddEditRecipeViewModel = new AddEditRecipeViewModel();


            BindingContext = AddEditRecipeViewModel;

            // subscribe to message center message sent after recipe add
            MessagingCenter.Subscribe<AddEditCommand, string>(this, "Save", async (sender, message) =>
            {
                await MaterialDialog.Instance.SnackbarAsync(message: $"{message}", msDuration: MaterialSnackbar.DurationLong);

                await Navigation.PopToRootAsync();
            });

        }

        async void MaterialButton_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(animated: true);
        }

    }
}
