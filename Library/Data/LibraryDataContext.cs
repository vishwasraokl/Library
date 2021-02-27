using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class LibraryDataContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public LibraryDataContext(DbContextOptions<LibraryDataContext> options) : base(options)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
       .ToTable("tblBarrower");
            modelBuilder.Entity<Book>()
       .ToTable("tblBook");
            modelBuilder.Entity<Transaction>()
       .ToTable("tblTransaction");
        }


        public DbSet<Library.Models.Book> Book { get; set; }


        public DbSet<Library.Models.Transaction> Transaction { get; set; }

    }
}
