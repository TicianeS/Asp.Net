using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Departamento
    {
        [Key]
        [ScaffoldColumn(false)]
        public int DepartamentoID { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression("^([0-1][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "O horário deve ter o formato 00:00")]
        [Display(Name = "Horário de entrada")]
        public string Horario { get; set; }

        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [Display(Name = "Funcionário")]
        public int FuncionarioID { get; set; }


        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [ForeignKey("FuncionarioID")]
        public virtual Funcionario _Funcionario { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [Display(Name = "Supervisor")]
        public int SupervisorID { get; set; }


        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [ForeignKey("SupervisorID")]
        public virtual Funcionario _Supervisor { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [Display(Name = "Cargo")]
        public int CargoID { get; set; }



        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public virtual Cargo _Cargo { get; set; }



    }
}
