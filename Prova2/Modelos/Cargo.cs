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
        [ScaffoldColumn(false)]
        public int CargoID { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(30, ErrorMessage = "Tamanho máximo de 30 caracteres")]
        public string Nome { get; set; }
    }
}
