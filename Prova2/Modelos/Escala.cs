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
        [RegularExpression("^([0-2][0-9]|3[0-1])/(0[1-9]|1[0-2])/(201[7-9])$",
            ErrorMessage = "A data deve ser preenchida como dd/mm/aaaa")]
        public string Data { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public int FuncionarioID { get; set; }

        [Display(Name = "Escala")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public int AusenciaID { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public virtual Funcionario _Funcionario { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public virtual Ausencia _Ausencia { get; set; }


    }
}
