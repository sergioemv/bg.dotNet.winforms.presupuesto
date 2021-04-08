using System.Collections.Generic;
using DataModel.DAO.Util;
using DataModel.Entidades;
using NHibernate;

namespace DataModel.DAO
{
    public class PresupuestoDAO:DefaultDAO
    {
        public IList<Presupuesto> getPresupuestos()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            IList<Presupuesto> prelist = session.CreateCriteria(typeof(Presupuesto)).List<Presupuesto>();
            ((List<Presupuesto>)prelist).Sort();
            session.Close();
            return prelist;
        }

        
        public PresupuestoCollection getPresupuestoCollection()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            PresupuestoCollection collection = new PresupuestoCollection();
            IList<Presupuesto> prelist = session.CreateCriteria(typeof(Presupuesto)).List<Presupuesto>();
            foreach (Presupuesto presupuesto in prelist)
            {
                 collection.Add(presupuesto);
            }
            return collection;
        }
    }
}