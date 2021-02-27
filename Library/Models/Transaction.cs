using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set;}

        public User user { get; set; }

        [ForeignKey("user")]
        public int BarrowerId { get; set; }

        public Book Book { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public DateTime BarrowedDateTime { get; set; }
        public DateTime ? ReturnDate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
