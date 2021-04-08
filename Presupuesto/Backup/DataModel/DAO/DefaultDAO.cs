using NHibernate;

namespace DataModel.DAO
{
    public class DefaultDAO
    {
        public virtual void Actualizar(object ob)
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            session.Update(ob);
            session.Flush();
            session.Close();
        }
        public virtual void Adicionar(object ob)
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            session.Save(ob);
            session.Flush();
            session.Close();
        }
        public virtual void Eliminar(object ob)
        {
            ISession session = HibernateUtil.SessionFactory.OpenSession();
            session.Save(ob);
            session.Flush();
            session.Close();
        }

    }
}
