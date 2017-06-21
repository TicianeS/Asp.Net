using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
   public class Ausencia
    {
        [Key]
        public int AusenciaID { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
