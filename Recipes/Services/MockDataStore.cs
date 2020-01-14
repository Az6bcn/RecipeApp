using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;

namespace Recipes.Services
{
    public class MockDataStore : IDataStore<Recipe>
    {
        readonly List<Recipe> Recipes;

        public MockDataStore()
        {
            Recipes = new List<Recipe>()
            {
                new Recipe { Id = Guid.NewGuid(), Name = "First Recipe", Description="This is an Recipe description." },
                new Recipe { Id = Guid.NewGuid(), Name = "Second Recipe", Description="This is an Recipe description." },
                new Recipe { Id = Guid.NewGuid(), Name = "Third Recipe", Description="This is an Recipe description." },
                new Recipe { Id = Guid.NewGuid(), Name = "Fourth Recipe", Description="This is an Recipe description." },
                new Recipe { Id = Guid.NewGuid(), Name = "Fifth Recipe", Description="This is an Recipe description." },
                new Recipe { Id = Guid.NewGuid(), Name = "Sixth Recipe", Description="This is an Recipe description." }
            };
        }

        public async Task<bool> AddRecipeAsync(Recipe Recipe)
        {
            Recipes.Add(Recipe);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateRecipeAsync(Recipe Recipe)
        {
            var oldRecipe = Recipes
                            .Where((Recipe arg) => arg.Id == Recipe.Id)
                            .FirstOrDefault();

            Recipes.Remove(oldRecipe);
            Recipes.Add(Recipe);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteRecipeAsync(Guid id)
        {
            var oldRecipe = Recipes.Where((Recipe arg) => arg.Id == id).FirstOrDefault();
            Recipes.Remove(oldRecipe);

            return await Task.FromResult(true);
        }

        public async Task<Recipe> GetRecipeAsync(Guid id)
        {
            return await Task.FromResult(Recipes.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Recipe>> GetRecipesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Recipes);
        }
    }
}