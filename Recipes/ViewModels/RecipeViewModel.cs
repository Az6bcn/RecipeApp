using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Recipes.Commands;
using Recipes.Models;

namespace Recipes.ViewModels
{
    public class RecipeViewModel: BaseViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }
        public LoadRecipesCommand LoadRecipesCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public RecipeViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();
            // fire and forget
            Task.Run(async () => await GetRecipes());

            LoadRecipesCommand = new LoadRecipesCommand(this);

            DeleteCommand = new DeleteCommand(this);
        }

        public async Task GetRecipes()
        {
            IsBusy = true;

            if (Recipes.Count > 0)
            {
                Recipes.Clear();
            }

            Recipes = await DataStore.GetRecipesAsync();

            IsBusy = false;
        }

        public async Task<int> ReloadRecipes()
        {
            Recipes = await DataStore.GetRecipesAsync();

            return Recipes.Count;
        }

        public async Task<bool> DeleteRecipe(Guid Id)
        {
            var response = await DataStore.DeleteRecipeAsync(Id);
            return response;
        }
    }
}
