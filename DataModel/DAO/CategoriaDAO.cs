using System.Collections.Generic;
using DataModel.Entidades;
using NHibernate;

namespace DataModel.DAO
{
    public class CategoriaDAO:DefaultDAO
    {
        public IList<Categoria> getCategorias()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            IList<Categoria> catlist = session.CreateCriteria(typeof(Categoria)).List<Categoria>();
            ((List<Categoria>)catlist).Sort();
            session.Close();
            return catlist;
        }
        
    }
}