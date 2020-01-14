using System;
using Recipes.Models;

namespace Recipes.ViewModels
{
    public class RecipeDetailsViewModel
    {
        public Recipe RecipeReceived { get; set; }
        
        public RecipeDetailsViewModel(Recipe recipe)
        {
            RecipeReceived = recipe;
        }
    }
}
