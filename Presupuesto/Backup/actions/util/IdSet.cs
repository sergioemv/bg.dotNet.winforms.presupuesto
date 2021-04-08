using System.Collections.Generic;

namespace Presupuesto.actions.util
{
    public class IdSet
    {
        private IList<int> ids;

         private IList<int> Ids
        {
            get
            {
                if (ids == null)
                    ids = new List<int>();
                return ids;
            }
        }
        public void registerId(int id)
        {
            if (!Ids.Contains(id))
            {
                Ids.Add(id);
                ((List<int>) Ids).Sort();
            }
        }

        public int getNextValidId()
        {
            int j = 2;
            foreach (int i in Ids)
            {
                if (j!=i) break;
                j++;
            }
            return j;
        }

        public void clear()
        {
            ids = new List<int>();
        }
    }
}
