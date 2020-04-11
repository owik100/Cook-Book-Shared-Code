using System;
using System.Collections.Generic;
using System.Text;

namespace Cook_Book_Shared_Code.Models
{
    public interface ILoggedUser
    {
        string Email { get; set; }
        string Id { get; set; }
        string Token { get; set; }
        string UserName { get; set; }

        void LogOffUser();
    }
}
