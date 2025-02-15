﻿using System.Collections.Generic;

namespace Cook_Book_Shared_Code.Models
{
    public class RecipeModel : PaginationModel
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public string Instruction { get; set; }
        public string NameOfImage { get; set; }
        public string ImagePath { get; set; }
        public bool IsPublic { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
