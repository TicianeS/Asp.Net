using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aula2205_EF_DatabaseFirst.DAL;

namespace Aula2205_EF_DatabaseFirst.Views.Produto
{
    public partial class ListaProdutos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            strConnLojaEntities contexto = new strConnLojaEntities();

            gvwProdutos.DataSource = contexto.Produtoes.ToList();
            gvwProdutos.DataBind();

        }
    }
}