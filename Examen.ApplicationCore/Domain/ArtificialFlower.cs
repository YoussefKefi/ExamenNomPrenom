using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace Examen.ApplicationCore.Domain
{
    public class ArtificialFlower
    {
        public DateTime ManufactureDate { get; set; }
        public string Material {  get; set; }
    }
}
