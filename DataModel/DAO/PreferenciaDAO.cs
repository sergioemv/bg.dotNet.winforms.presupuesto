using System.Collections.Generic;
using DataModel.DAO.Util;
using DataModel.Entidades;
using NHibernate;

namespace DataModel.DAO
{
    public class PreferenciaDAO:DefaultDAO
    {
        public Dictionary<string, Preferencia> getPreferenciasDict()
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            IList<Preferencia> prelist = session.CreateCriteria(typeof (Preferencia)).List<Preferencia>();
            if (prelist == null)
                return null;
            Dictionary<string, Preferencia> dict = new Dictionary<string, Preferencia>();
            foreach (Preferencia preferencia in prelist)
            {
                dict.Add(preferencia.Key, preferencia);
            }
            session.Close();
            return dict;
        }
    }
}