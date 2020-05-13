namespace Cook_Book_Shared_Code.Models
{
    public abstract class PaginationModel
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
    }
}
