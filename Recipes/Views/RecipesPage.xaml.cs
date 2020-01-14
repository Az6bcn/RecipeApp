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
        }

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var _sender = sender as ListView;

            var selectedItem = (Recipe)_sender.SelectedItem;

            // navigate to next details page
            await Navigation.PushAsync(new NavigationPage(new RecipeDetailPage(new RecipeDetailsViewModel(selectedItem))), true);


        }

        public async void ToolbarItem_Clicked(Object sender, EventArgs e)
        {
            await MaterialDialog.Instance.AlertAsync(message: "This is an alert dialog",
                                    title: "Alert Dialog");
        }
    }
}