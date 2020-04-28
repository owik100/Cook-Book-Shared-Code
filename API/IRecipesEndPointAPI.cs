using Cook_Book_Shared_Code.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Book_Shared_Code.API
{
    public interface IRecipesEndPointAPI
    {
        Task<List<RecipeModel>> GetRecipesLoggedUser(int PageSize, int PageNumber);
        Task<List<RecipeModel>> GetPublicRecipes(int PageSize, int PageNumber);
        Task<List<RecipeModel>> GetFavouritesRecipes(int PageSize, int PageNumber);
        Task<bool> InsertRecipe(RecipeModel recipeModel);
        Task<bool> DeleteRecipe(string id);
        Task<bool> EditRecipe(RecipeModel recipeModel);
        Task<bool> DownloadImage(string id);
    }
}
