namespace BestStore.Web.Models.ViewModels.User
{
    public class UserQueryParams
    {
        public string Search { get; set; } = string.Empty;
        public string SortBy { get; set; } = "CreatedAt";
        public bool Ascending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

}
