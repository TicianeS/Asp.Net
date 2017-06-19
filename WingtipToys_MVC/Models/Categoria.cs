using System.ComponentModel.DataAnnotations;

//class library representa as classes models que são relativas as tabelas
//também pode ser criado para o pacote útil
namespace BaseModels
{
    public class Categoria
    {

        [Key]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(10, ErrorMessage ="Tamanho máximo é 10 caracteres")]
        public string Nome { get; set; }

        [Display(Name ="Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}
