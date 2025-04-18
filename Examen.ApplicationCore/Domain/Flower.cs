using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Flower
    {
        public string Color { get; set; }
        public int FlowerId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Range(0, 2000)]
        public float Price { get; set; }
    }
}
