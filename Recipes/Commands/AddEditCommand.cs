using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Commands
{
    public class AddEditCommand : ICommand
    {
        private AddEditRecipeViewModel _addEditRecipeViewModel;
        private RecipeViewModel _recipeViewModel;

        public AddEditCommand(AddEditRecipeViewModel addEditRecipeViewModel)
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
            var param = (AddEditRecipeViewModel)parameter;

            var recipe = GetRecipe(param);

            Task.Run(async () =>
            {
                if (recipe.IsNew)
                {
                    await _addEditRecipeViewModel.Save(recipe)
                      .ContinueWith(x => ContinueFunction(x.Result, IsNew: true));
                    
                }
                else
                {
                    await _addEditRecipeViewModel.Update(recipe)
                        .ContinueWith(x => ContinueFunction(x.Result, IsNew: false));
                }
            });
        }


        private Recipe GetRecipe(AddEditRecipeViewModel addEditRecipeViewModel)
        {

            Recipe recipe;

            if (_addEditRecipeViewModel.RecipeToEdit.IsNew)
            {
                recipe = new Recipe
                {
                    Name = _addEditRecipeViewModel.NewName,
                    Description = _addEditRecipeViewModel.NewDescription,
                    Direction = _addEditRecipeViewModel.NewDirection,
                    Ingrident = _addEditRecipeViewModel.NewIngrident,
                    Images = _addEditRecipeViewModel.Images,
                    Id = Guid.NewGuid(),
                    IsNew = true
                };
               
            }
            else
            {
                recipe = _addEditRecipeViewModel.RecipeToEdit;
            }

            return recipe;
        }

        private void ContinueFunction(bool result, bool IsNew)
        {
            if (result)
            {
                // reload
                Device.BeginInvokeOnMainThread(() =>
                {
                    _recipeViewModel.ReloadRecipes();

                    if (!IsNew)
                    {
                        MessagingCenter.Send<AddEditCommand, string>(this, "Updated", "Updated Successfully");
                    }
                    else
                    {
                        MessagingCenter.Send<AddEditCommand, string>(this, "Save", "Saved Successfully");
                    }
                  
                });

            }
        }
    }
}
