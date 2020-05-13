using System.Collections.Generic;

namespace Cook_Book_Shared_Code.Models
{
    public class LoggedUser : ILoggedUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public List<string> FavouriteRecipes { get; set; }

        public void LogOffUser()
        {
            Id = "";
            Email = "";
            UserName = "";
            Token = "";
            FavouriteRecipes.Clear();
        }
    }
}
