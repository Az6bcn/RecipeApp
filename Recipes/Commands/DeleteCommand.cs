using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Commands
{
    public class DeleteCommand: ICommand
    {
        private RecipeViewModel _recipeViewModel;

        public DeleteCommand(RecipeViewModel recipeViewModel)
        {
            _recipeViewModel = recipeViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var recipe = (Recipe)parameter;
            Task.Run(() => _recipeViewModel.DeleteRecipe(recipe.Id))
                .ContinueWith(x =>
               {
                   Device.BeginInvokeOnMainThread(() =>
                   {
                       _recipeViewModel.ReloadRecipes();
                          MessagingCenter.Send<DeleteCommand, string>(this, "Deleted", "Deleted Successfully");
                   });
               });
        }
    }
}
