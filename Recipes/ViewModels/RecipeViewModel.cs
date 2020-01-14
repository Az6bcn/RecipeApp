﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Recipes.Commands;
using Recipes.Models;

namespace Recipes.ViewModels
{
    public class RecipeViewModel: BaseViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }
        public LoadRecipesCommand LoadRecipesCommand { get; set; }

        public RecipeViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();
            // fire and forget
            Task.Run(async () => await GetRecipes());

            LoadRecipesCommand = new LoadRecipesCommand(this);
        }

        public async Task GetRecipes()
        {
            IsBusy = true;

            if (Recipes.Count > 0)
            {
                Recipes.Clear();
            }

            var recipes = await DataStore.GetRecipesAsync();

            foreach (var recipe in recipes)
            {
                Recipes.Add(recipe);
            }

            IsBusy = false;
        }
    }
}