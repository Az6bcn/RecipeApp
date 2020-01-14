using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Recipes.ViewModels;

namespace Recipes.Commands
{
    public class LoadRecipesCommand: ICommand
    {
        private RecipeViewModel _recipeViewModel;

        public LoadRecipesCommand(RecipeViewModel recipeViewModel)
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
            Task.Run(() => _recipeViewModel.GetRecipes());
        }
    }
}
