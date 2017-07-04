using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UsuarioID { get; set; }

        [Display(Name = "Nome do Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public int FuncionarioID { get; set; }

        [Display(Name = "Nome do Funcionário")]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public virtual Funcionario _Funcionario { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "O login deve conter de 5 a 10 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A senha deve conter de 4 a 10 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Perfil { get; set; }



    }
}