using System;
using System.Collections.Generic;
using System.Linq;
using Recipes.Models;

namespace Recipes.ViewModels
{
    public class RecipeDetailsViewModel: BaseViewModel
    {
        public Recipe RecipeReceived { get; set; }
        
        public RecipeDetailsViewModel(Recipe recipe)
        {
            RecipeReceived = recipe;

            if(RecipeReceived != null)
            {
                Ingridents = RecipeReceived.Ingrident;
            }
        }

        public string Ingridents
        {
            get { return RecipeReceived.Ingrident; }
            set
            {
                if(RecipeReceived.Ingrident != value)
                {
                    RecipeReceived.Ingrident = value;
                    OnPropertyChanged(nameof(Ingridents));
                }
            }
        }

        public string Directions
        {
            get { return RecipeReceived.Direction; }
            set
            {
                if (RecipeReceived.Direction != value)
                {
                    RecipeReceived.Direction = value;
                    OnPropertyChanged(nameof(Directions));
                }
            }
        }

        public List<Image> Images
        {
            get { return RecipeReceived.Images; }
            set
            {
                if (RecipeReceived.Images.Count() != value.Count())
                {
                    RecipeReceived.Images = value;
                    OnPropertyChanged(nameof(Images));
                }
            }
        }
    }
}
