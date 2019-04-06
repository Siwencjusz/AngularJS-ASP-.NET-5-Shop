namespace Shop.Services
{
    public class GetBooksInput
    {
        public string BookType { get; set; }
        public bool IsNew { get; set; }
        public bool IsUpcoming { get; set; }
        public bool IsSuperOpportunity { get; set; }
        public string SearchTerm { get; set; }
    }
}