using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class NaturalFlower
    {
        public string Origine { get; set; }
        public bool Savage { get; set; }
        [Range(1,4)]
        public int Season { get; set; }
    }
}
