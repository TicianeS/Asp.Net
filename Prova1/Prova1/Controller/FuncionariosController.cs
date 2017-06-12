using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prova1.DAL;

namespace Prova1.Controller
{
    public class FuncionariosController : BaseController
    {
       //protected static CallEntities contexto = new CallEntities();

        public static void AdicionarFunc(Funcionario funcionario)
        {
            contexto.Funcionarios.Add(funcionario);
            contexto.SaveChanges();
        }

        public static Funcionario PesquisarFunc(int id)
        {
            return contexto.Funcionarios.Find(id);
        }

        public static List<Funcionario> ListarFunc()
        {
            return contexto.Funcionarios.ToList();
        }

        public static void AlterarFunc(Funcionario funcionario)
        {
            var local = contexto.Set<Funcionario>().Local.FirstOrDefault(x => x.Id == funcionario.Id);

            contexto.Entry(local).State = System.Data.Entity.EntityState.Detached;
            contexto.Entry(funcionario).State =
                System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public static void ExcluirFunc(Funcionario funcionario)
        {
            var local = contexto.Set<Funcionario>().Local.FirstOrDefault(x => x.Id == funcionario.Id);

           contexto.Entry(local).State = System.Data.Entity.EntityState.Detached;

            contexto.Entry(funcionario).State =
                  System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

    }
}