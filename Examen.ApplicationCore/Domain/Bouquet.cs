using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum BouquetType
    {
        Round, Conical
    }
    public class Bouquet
    {
        public string AccompagningMessage { get; set; }
        [Key]
        public int BouquetCode  { get; set; }
        public BouquetType BouquetType { get; set; }
        public DateTime CreationDate { get; set; }
        public IList<Flower> Flowers { get; set; }
    }
}
