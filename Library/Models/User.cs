using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        [Column("StateName")]
        public string State { get; set; }

        public string Country { get; set; }
        public string Postcode { get; set; }

        [Column("CountryCode")]
        public string MobileNumberCountryCode { get; set; }
        public string MobileNumber { get; set; }

        public string EmailId { get; set; }
        public string BarrowerType { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }

    }
}
