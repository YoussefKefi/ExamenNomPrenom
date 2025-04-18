using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Customer
    {
        [Key]
        public string CIN { get; set; }
        public string EmailAddress { get; set; }
        public string FirstNamer { get; set; }
        public string LastNamer { get; set; }
        [StringLength(8, MinimumLength = 8)]
        public string PhoneNumber { get; set; }
        public IList<Bouquet> bouquets { get; set; }
    }
}
