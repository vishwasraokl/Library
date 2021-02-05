using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime PublishedDate { get; set; }

        public DateTime LastUpdated { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }

    }
}
