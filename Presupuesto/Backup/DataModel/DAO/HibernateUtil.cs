using NHibernate;
using NHibernate.Cfg;

namespace DataModel.DAO
{
    class HibernateUtil
    {
        private static ISessionFactory sessionFactory ;


        public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory==null)
                {
                    Configuration cfg;
                    cfg = new Configuration();
                    cfg.Configure("hibernate.cfg.xml");
                    sessionFactory = cfg.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }
    }
}
