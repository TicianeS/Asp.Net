
using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
   public  class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Display (Name ="Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        [Display(Name ="Preço")]
        [DataType(DataType.Currency)] //valor moeda
        public decimal Preco { get; set; }

        [Required]
        public bool Ativo { get; set; }

        public int CategoriaID { get; set; }


        [Display(Name ="Categoria")]
        public virtual Categoria _Categoria { get; set; }//lazy load não precisa fazer a busca, carrega todos os dados deste objeto direto
        //não precisa usar uma classe controller buscar por algo e retornar o objeto
    }
}
