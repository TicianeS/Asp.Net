using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prova1.DAL;

namespace Prova1.Controller
{
    public class BaseController
    {
        protected static CallEntities contexto = new CallEntities();
    }
}