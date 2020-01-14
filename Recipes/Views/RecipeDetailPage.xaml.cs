﻿using System;
using System.Collections.Generic;
using Recipes.Models;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class RecipeDetailPage : ContentPage
    {
        private RecipeDetailsViewModel _recipeDetailsViewModel;

        public RecipeDetailPage(RecipeDetailsViewModel recipe = null)
        {
            InitializeComponent();

            _recipeDetailsViewModel = recipe ?? new RecipeDetailsViewModel(new Recipe());
        }


    }
}