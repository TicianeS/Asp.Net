using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioID { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
