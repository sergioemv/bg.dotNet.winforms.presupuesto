using System.Collections.Generic;
using DataModel.Entidades;
using NHibernate;
using NHibernate.Expression;

namespace DataModel.DAO
{
    public class DetallePresupuestoDAO:DefaultDAO
    {
        public IList<DetallePresupuesto> getDetallePresupuesto()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            IList<DetallePresupuesto> dprelist = session.CreateCriteria(typeof(DetallePresupuesto)).List<DetallePresupuesto>();
            ((List<DetallePresupuesto>)dprelist).Sort();
            session.Close();
            return dprelist;
        }

        public IList<DetallePresupuesto> getDetallePresupuesto(Presupuesto presupuesto)
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            ICriteria crit = session.CreateCriteria(typeof (DetallePresupuesto));
            crit.CreateCriteria("pPresupuesto").Add(Expression.Eq("Id",presupuesto.Id));
            IList<DetallePresupuesto> dprelist = crit.List<DetallePresupuesto>();
            ((List<DetallePresupuesto>)dprelist).Sort();
            session.Close();
            return dprelist;
       }
        
    }
}