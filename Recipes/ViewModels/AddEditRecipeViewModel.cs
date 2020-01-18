using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Recipes.Commands;
using Recipes.Models;

namespace Recipes.ViewModels
{
    public class AddEditRecipeViewModel: BaseViewModel
    {
        public Recipe RecipeToEdit { get; set; }
        public ICommand AddCommand { get; set; }
        private bool IsSuccess { get; set; }

        public AddEditRecipeViewModel(Recipe recipe = null)
        {
            if(recipe != null) {
                Recipe = recipe;
            }
            else
            {
                Recipe = new Recipe();
            }

            AddCommand = new AddCommand(this);
        }

        public Recipe Recipe
        {
            get{ return RecipeToEdit; }

            set
            {
                if(RecipeToEdit != value)
                {
                    RecipeToEdit = value;
                    OnPropertyChanged(nameof(Recipe));
                }
            }
        }

        public string NewName{
            get { return Recipe.Name; }
            set {
                if (Recipe.Name != value)
                {
                    Recipe.Name = value;
                    OnPropertyChanged(nameof(NewName));
                }
            }
        }
        public string NewIngridents {
            get { return Recipe.Ingrident; }
            set
            {
                if (Recipe.Ingrident != value)
                {
                    Recipe.Ingrident = value;
                    OnPropertyChanged(nameof(NewIngridents));
                }
            }
        }
        public string NewDirection {
            get { return Recipe.Direction; }
            set
            {
                if (Recipe.Direction != value)
                {
                    Recipe.Direction = value;
                    OnPropertyChanged(nameof(NewDirection));
                }
            }
        }
        public string NewDescription {
            get { return Recipe.Description; }
            set
            {
                if (Recipe.Description != value)
                {
                    Recipe.Description = value;
                    OnPropertyChanged(nameof(NewDirection));
                }
            }
        }

        public bool Response
        {
            get { return IsSuccess; }
            set
            {
                if (IsSuccess != value)
                {
                    IsSuccess = value;
                    OnPropertyChanged(nameof(Response));
                }
            }
        }

        public async Task<bool> Save(Recipe recipe)
        {
            var res = await DataStore.AddRecipeAsync(recipe);

            return res;
        }


        public List<Image> Images => new List<Image>
        {
            new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557260183/tnubfv4wbkuvejlvhxms.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557351122/mentmlr0paozcnvw98na.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg" },
                                new Image { Name = "image 01", Title = "My first", Url = "https://res.cloudinary.com/az6bcn/image/upload/v1557259630/fumwapf5ks3brari5qin.jpg"}
        };


    }
}
