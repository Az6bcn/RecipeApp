using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Recipes.Models;
using Recipes.Views;
using Recipes.ViewModels;
using XF.Material.Forms.UI.Dialogs;
using Recipes.Commands;

namespace Recipes.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class RecipesPage : ContentPage
    {
        public RecipeViewModel _recipeViewModel { get; set; }

        public RecipesPage()
        {
            _recipeViewModel = new RecipeViewModel();
            InitializeComponent();


            BindingContext = _recipeViewModel;

            // subscribe to message center message sent after recipe add
            MessagingCenter.Subscribe<DeleteCommand, string>(this, "Deleted", async (sender, message) =>
            {
                await MaterialDialog.Instance.SnackbarAsync(message: $"{message}", msDuration: MaterialSnackbar.DurationLong);
            });
        }

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var _sender = sender as ListView;

            var selectedItem = (Recipe)_sender.SelectedItem;

            // navigate to next details page
            await Navigation.PushAsync((new RecipeDetailPage(new RecipeDetailsViewModel(selectedItem))), true);

        }

        public async void ToolbarItem_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipePage());
        }


    }
}