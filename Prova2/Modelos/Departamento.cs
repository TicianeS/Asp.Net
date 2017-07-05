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

       
        [ForeignKey("_Funcionario")]
        public int FuncionarioID { get; set; }

       
        public virtual Funcionario _Funcionario { get; set; }


        public int SupervisorID { get; set; }

        [ForeignKey("SupervisorID")]
        public virtual Funcionario _Supervisor { get; set; }


        [ForeignKey("_Cargo")]
        public int CargoID { get; set; }

        

        public virtual Cargo _Cargo { get; set; }



    }
}