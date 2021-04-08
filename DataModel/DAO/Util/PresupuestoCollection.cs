using System.Collections;
using DataModel.Entidades;

namespace DataModel.DAO.Util
{
    public class PresupuestoCollection : CollectionBase
    {
        // Add method
        public void Add(Presupuesto o)
        {
            InnerList.Add(o);
            InnerList.Sort();
        }

        // Indexer property
        public Presupuesto this[int index]
        {
            get { return (Presupuesto)InnerList[index]; }
            set { InnerList[index] = value; }
        }
    }
}