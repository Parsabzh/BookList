using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace BookListRazor.Pages.BookList
{
    public class BookListIndexModel : PageModel
    {
        private ApplicationDbContext _db;

        public BookListIndexModel(ApplicationDbContext db)
        {
            _db = db;

        }

        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books =await _db.Books.ToListAsync();
           
        }
    }
}