using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prova1.DAL;

namespace Prova1.Controller
{
    public class HoraExtraController : BaseController
    {

       //protected static CallEntities contexto = new CallEntities();

        public static void AdicionarHE(HorasExtra horaExtra)
        {
            contexto.HorasExtras.Add(horaExtra);
            contexto.SaveChanges();
        }

        public static IEnumerable<HorasExtra> PesquisarHE(DateTime data)
        {

            return contexto.HorasExtras.ToList().Where(x => x.Data.Day == data.Day);
        }

        public static HorasExtra PesquisarHEporIDeData(DateTime data, int id)
        {

            return contexto.HorasExtras.FirstOrDefault(x => x.Funcionario.Id == id && x.Data == data);

        }

        public static List<HorasExtra> ListarHE()
        {
            return contexto.HorasExtras.ToList();
        }

        public static void AlterarHE(HorasExtra horaExtra)
        {
          var local = contexto.Set<HorasExtra>().Local.FirstOrDefault(x => x.Id == horaExtra.Id);

            contexto.Entry(local).State = System.Data.Entity.EntityState.Detached;
            contexto.Entry(horaExtra).State =
                System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public static void ExcluirHE(HorasExtra horaExtra)
        {
            var local = contexto.Set<HorasExtra>().Local.FirstOrDefault(x => x.Id == horaExtra.Id);

            contexto.Entry(local).State = System.Data.Entity.EntityState.Detached;

            contexto.Entry(horaExtra).State =
                  System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }


    }
}