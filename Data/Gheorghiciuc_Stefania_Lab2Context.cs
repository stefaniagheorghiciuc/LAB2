using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gheorghiciuc_Stefania_Lab2.Models;

namespace Gheorghiciuc_Stefania_Lab2.Data
{
    public class Gheorghiciuc_Stefania_Lab2Context : DbContext
    {
        public Gheorghiciuc_Stefania_Lab2Context (DbContextOptions<Gheorghiciuc_Stefania_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gheorghiciuc_Stefania_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Gheorghiciuc_Stefania_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Gheorghiciuc_Stefania_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Gheorghiciuc_Stefania_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;  

    }
}
