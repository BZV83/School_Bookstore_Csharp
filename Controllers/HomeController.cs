using Bookstore_Mission_11_Vick.Models;
using Bookstore_Mission_11_Vick.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Bookstore_Mission_11_Vick.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;
        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var books = new BookListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    currentPage = pageNum,
                    itemsPerPage = pageSize,
                    totalItems = _repo.Books.Count()
                }
            };

            return View(books);
        }
    }
}
