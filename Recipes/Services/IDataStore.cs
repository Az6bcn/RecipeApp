﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Recipes.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddRecipeAsync(T Recipe);
        Task<bool> UpdateRecipeAsync(T Recipe);
        Task<bool> DeleteRecipeAsync(Guid id);
        Task<T> GetRecipeAsync(Guid id);
        Task<ObservableCollection<T>> GetRecipesAsync(bool forceRefresh = false);
    }
}
