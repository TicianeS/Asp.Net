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
        [Display(Name ="Matrícula do funcionário")]
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(80, ErrorMessage = "Tamanho máximo de 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(80, ErrorMessage = "Tamanho máximo de 80 caracteres")]
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(30, ErrorMessage = "Tamanho máximo de 30 caracteres")]
        public string Cidade { get; set; }

        [RegularExpression("^[0-9]{2}\\s[0-9]{4}-[0-9]{4}$", ErrorMessage ="O telefone deve ser do seguinte formato: 00 0000-0000")]
        public string Telefone { get; set; }

    }
}
