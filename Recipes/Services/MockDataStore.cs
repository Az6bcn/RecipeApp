    using System;
    using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
    using System.Threading.Tasks;
    using Recipes.Models;

    namespace Recipes.Services
    {
        public class MockDataStore : IDataStore<Recipe>
        {
            readonly ObservableCollection<Recipe> Recipes;

            public MockDataStore()
            {
                Recipes = new ObservableCollection<Recipe>()
                {
                        new Recipe { Id = Guid.NewGuid(), Name = "First Recipe", Description="This is an Recipe description.", Ingrident = "Love and some secret stuff", Direction ="Giving away my family's kitchen secret in this App, sahk kjkjkjs sKksjs kSS dadkakd  andkand dad kad adnka aka ana anakn a ja dj ana ajdja ja dja d ajdadj knjdk na djad jadj dja dja dja jd ajd aj ak ka dka dka  akda dka dka kda kd akd akd ak dka dka dka dka dka dka dka dka dka kd akd akdka dka dka dk akd akd ak dka dka dka dka kd akd akd ka dka dka ka dka da kd akd akd ak dak dka dka dka dka dkada",
                            Images = new List<Image> {
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"} }
                        },
                        new Recipe { Id = Guid.NewGuid(), Name = "Second Recipe", Description="This is an Recipe description.", Ingrident = "Love and some secret stuff", Direction ="Giving away my family's kitchen secret in this App", Images = new List<Image> {
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"} }
                        },
                        new Recipe { Id = Guid.NewGuid(), Name = "Third Recipe", Description="This is an Recipe description.", Ingrident = "Love and some secret stuff", Direction ="Giving away my family's kitchen secret in this App", Images = new List<Image> {
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"} }
                        },
                        new Recipe { Id = Guid.NewGuid(), Name = "Fourth Recipe", Description="This is an Recipe description.", Ingrident = "Love and some secret stuff", Direction ="Giving away my family's kitchen secret in this App", Images = new List<Image> {
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"} }
                        },
                        new Recipe { Id = Guid.NewGuid(), Name = "Fifth Recipe", Description="This is an Recipe description.", Ingrident = "Love and some secret stuff", Direction ="Giving away my family's kitchen secret in this App", Images = new List<Image> {
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"} }
                        },
                        new Recipe { Id = Guid.NewGuid(), Name = "Sixth Recipe", Description="This is an Recipe description.", Ingrident = "Love and some secret stuff", Direction ="Giving away my family's kitchen secret in this App", Images = new List<Image> {
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"} }
                        }
                };
            }

            public async Task<bool> AddRecipeAsync(Recipe recipe)
            {
                Recipes.Add(recipe);

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
                var oldRecipe = Recipes
                                .Where((Recipe arg) => arg.Id == id).FirstOrDefault();

                Recipes.Remove(oldRecipe);

                return await Task.FromResult(true);
            }

            public async Task<Recipe> GetRecipeAsync(Guid id)
            {
                return await Task.FromResult(Recipes.FirstOrDefault(s => s.Id == id));
            }

            public async Task<ObservableCollection<Recipe>> GetRecipesAsync(bool forceRefresh = false)
            {
                return await Task.FromResult(Recipes);
            }
        }
    }