using System.Collections.Generic;
using DataModel.Entidades;
using NHibernate;
using NHibernate.Expression;

namespace DataModel.DAO
{
    public class DetalleTransaccionDAO:DefaultDAO
    {
        public IList<DetalleTransaccion> getDetallesTransaccion()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            IList<DetalleTransaccion> dprelist = session.CreateCriteria(typeof(DetalleTransaccion)).List<DetalleTransaccion>();
            ((List<DetalleTransaccion>)dprelist).Sort();
            session.Close();
            return dprelist;
        }

        public IList<DetalleTransaccion> getDetalleTransaccion(Transaccion transaccion)
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            ICriteria crit = session.CreateCriteria(typeof (DetalleTransaccion));
            crit.CreateCriteria("TransaccionPadre").Add(Expression.Eq("Id", transaccion.Id));
            IList<DetalleTransaccion> dprelist = crit.List<DetalleTransaccion>();
            ((List<DetalleTransaccion>)dprelist).Sort();
            session.Close();
            return dprelist;
       }
        
    }
}