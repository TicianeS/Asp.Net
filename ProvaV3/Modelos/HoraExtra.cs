using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class HoraExtra
    {
        [Key]
        [ScaffoldColumn(false)]
        public int HoraExtraID { get; set; }

        [Display(Name = "Matrícula do Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression("^([0-2][0-9]|3[0-1])/(0[1-9]|1[0-2])/(201[7-9])$", ErrorMessage = "A data deve ser preenchida como dd/mm/aaaa")]
        public string Data { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression("^([0-1][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "O horário deve ter o formato 00:00")]


        public string Horas { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression("^([0-1][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "O horário deve ter o formato 00:00")]

        public string Inicio { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression("^([0-1][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "O horário deve ter o formato 00:00")]

        public string Fim { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public virtual Funcionario _Funcionario { get; set; }

    }
}