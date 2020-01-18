using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Commands
{
    public class AddCommand: ICommand
    {
        private AddEditRecipeViewModel _addEditRecipeViewModel;
        private RecipeViewModel _recipeViewModel;

        public AddCommand(AddEditRecipeViewModel addEditRecipeViewModel)
        {
            _addEditRecipeViewModel = addEditRecipeViewModel;
            _recipeViewModel = new RecipeViewModel();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //var param = (AddEditRecipeViewModel)parameter;
            
            var recipe = new Recipe
            {
                Name = _addEditRecipeViewModel.NewName,
                Description = _addEditRecipeViewModel.NewDescription,
                Direction = _addEditRecipeViewModel.NewDirection,
                Ingrident = _addEditRecipeViewModel.NewIngridents,
                Images = _addEditRecipeViewModel.Images
            };

            Task.Run(async () => await _addEditRecipeViewModel.Save(recipe))
                .ContinueWith(
                    x =>
                    {
                        if (x.Result)
                        {
                            // reload
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                _recipeViewModel.ReloadRecipes();
                                MessagingCenter.Send<AddCommand, string>(this, "Save", "Saved Successfully");
                            });
                             
                        }
                    }
                );
            
        }
    }
}
