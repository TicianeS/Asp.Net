using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("_Funcionario")]
        public int FuncionarioID { get; set; }

        [Display(Name = "Escala")]
        [ForeignKey("_Ausencia")]
        public int AusenciaID { get; set; }

        [Display(Name = "Funcionário")]
        
        public virtual Funcionario _Funcionario { get; set; }

        [Display(Name = "Funcionário")]
        
        public virtual Ausencia _Ausencia { get; set; }


    }
}
