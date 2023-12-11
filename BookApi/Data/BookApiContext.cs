using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookApi.Models;

namespace BookApi.Data
{
    public class BookApiContext : DbContext
    {
        public BookApiContext (DbContextOptions<BookApiContext> options)
            : base(options)
        {
        }

        public DbSet<BookApi.Models.Book> Book { get; set; } = default!;
    }
}
