using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bookstore_Mission_11_Vick.Models;

public partial class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Book> Books { get; set; }
}
