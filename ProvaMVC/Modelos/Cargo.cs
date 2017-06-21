using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Cargo
    {
        [Key]
        public int CargoID { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
