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
        [ScaffoldColumn(false)]
        public int AusenciaID { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Tamanho máximo de 25 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Tamanho máximo de 3 caracteres")]
        public string Sigla { get; set; }


    }
}
