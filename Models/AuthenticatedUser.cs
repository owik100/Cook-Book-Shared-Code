using System;
using System.Collections.Generic;
using System.Text;

namespace Cook_Book_Shared_Code.Models
{
    public class AuthenticatedUser
    {
        public string Access_Token { get; set; }
        public string UserName { get; set; }
    }
}
