using Aula2205_EF_DatabaseFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Aula2205_EF_DatabaseFirst.Views.Categoria
{
    public partial class ListaCategorias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // contexto (referencia para o banco)
            strConnLojaEntities contexto = new strConnLojaEntities();

            gvwCategorias.DataSource = contexto.Categorias.ToList(); //pega as categorias do banco, datasource é a fonte de dados
            gvwCategorias.DataBind(); // processa e monta a tabela
        }
    }
}