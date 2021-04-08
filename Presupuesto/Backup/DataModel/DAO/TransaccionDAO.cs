using System.Collections.Generic;
using DataModel.DAO.Util;
using DataModel.Entidades;
using NHibernate;

namespace DataModel.DAO
{
    public class TransaccionDAO:DefaultDAO
    {
        public IList<Transaccion> getTransacciones()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            IList<Transaccion> trnlist = session.CreateCriteria(typeof(Transaccion)).List<Transaccion>();
            ((List<Transaccion>)trnlist).Sort();
            session.Close();
            return trnlist;
        }
    }
}