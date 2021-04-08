using System.Collections.Generic;
using DataModel.Entidades;
using NHibernate;

namespace DataModel.DAO
{
    public class ProveedorDAO:DefaultDAO
    {
        public IList<Proveedor> getProveedores()
        {
          
                ISession session = HibernateUtil.SessionFactory.OpenSession();
                IList<Proveedor> prolist = session.CreateCriteria(typeof (Proveedor)).List<Proveedor>();
                session.Close();
                return prolist;
          
        }
    }
}