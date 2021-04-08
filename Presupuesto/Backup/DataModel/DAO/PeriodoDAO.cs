using System.Collections.Generic;
using DataModel.Entidades;
using NHibernate;

namespace DataModel.DAO
{
    public class PeriodoDAO:DefaultDAO
    {
        public IList<Periodo> getPeriodos()
        {
          
                ISession session = HibernateUtil.SessionFactory.OpenSession();
                IList<Periodo> perlist = session.CreateCriteria(typeof (Periodo)).List<Periodo>();
                session.Close();
                return perlist;
          
        }

        public IList<string> getTiposPeriodo()
        {
            IList<string> tiposPeriodo = new List<string>();
            foreach (Periodo per in getPeriodos())
            {
                if (!tiposPeriodo.Contains(per.Tipo))
                    tiposPeriodo.Add(per.Tipo);
            }
            return tiposPeriodo;
        }
    }
}