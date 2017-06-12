using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc1206.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="*")]
        public string Nome { get; set; }
        [Display (Name = "Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

    }
}