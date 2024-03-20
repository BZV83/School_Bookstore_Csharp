namespace Bookstore_Mission_11_Vick.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
