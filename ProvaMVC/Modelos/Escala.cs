using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Escala
    {
        [Key]
        [ScaffoldColumn(false)]
        public int EscalaID { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression("^(0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012])[-/.](19|20)[00-99]$",
            ErrorMessage ="A data deve ser preenchida como dd/mm/aaaa")]
        public DateTime Data { get; set; }

        [Display(Name = "Matrícula do Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public int FuncionarioID { get; set; }

        [Display(Name = "Escala")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public int AusenciaID { get; set; }

        
        public virtual Funcionario _Funcionario { get; set; }

        public virtual Ausencia _Ausencia { get; set; }


    }
}
