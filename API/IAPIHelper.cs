using Cook_Book_Shared_Code.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cook_Book_Shared_Code.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task<LoggedUser> GetLoggedUserData(string token);
        Task<bool> EditUser(LoggedUser recipeModel);
        HttpClient ApiClient { get; }
        Task<bool> Register(RegisterModel registerModel);

        void LogOffUser();
    }
}
