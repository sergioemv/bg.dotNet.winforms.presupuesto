using System;

namespace DataModel.Entidades
{

    public class ClaveCompuestaDetallePresupuesto 
    {
        private int idPresupuesto;
        private int idCategoria;
        private int idPeriodo;

        public virtual int IdPresupuesto
        {
            get { return idPresupuesto; }
            set { idPresupuesto = value; }
        }

        public virtual int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public virtual int IdPeriodo
        {
            get { return idPeriodo; }
            set { idPeriodo = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ClaveCompuestaDetallePresupuesto other = null;
            if (obj is ClaveCompuestaDetallePresupuesto)
                other = obj as ClaveCompuestaDetallePresupuesto;
            else
                return false;
            return
                IdCategoria == other.IdCategoria && IdPresupuesto == other.IdPresupuesto && IdPeriodo == other.IdPeriodo;
        }
        public override int GetHashCode()
        {
            return idCategoria.GetHashCode() + IdPresupuesto.GetHashCode() + IdPeriodo.GetHashCode();
        }
    }
    public class DetallePresupuesto
     :EntidadConEventos, IEquatable<DetallePresupuesto>, IComparable<DetallePresupuesto>  
    {
        private ClaveCompuestaDetallePresupuesto clave;
        private Presupuesto presupuesto;
        private Categoria categoria;
        private Periodo periodo;
        private double valor;
        private string descripcion;
         
        bool IEquatable<DetallePresupuesto>.Equals(DetallePresupuesto obj)
        {
            if (obj == null) return false;

            return pPeriodo.Equals(obj.pPeriodo) && pPresupuesto.Equals(obj.pPresupuesto) && pCategoria.Equals(obj.pCategoria);
        }
        public override int GetHashCode()
        {
            return pPeriodo.GetHashCode()+pPresupuesto.GetHashCode()+pCategoria.GetHashCode();
        }
        public override string ToString()
        {
            return pPresupuesto + ":" + pPeriodo + ":" + pCategoria + ":" + Valor;
        }

        public virtual string Descripcion
        {
            get { return descripcion; }
            set
            {
                string oldvalue = descripcion;
                descripcion = value;
                OnChanged(new PresupuestoModelEventArgs("Descripcion", oldvalue, descripcion));
            }
        }

        public virtual Presupuesto pPresupuesto
        {
            get { return presupuesto; }
            set
            {
                presupuesto = value;
                Clave.IdPresupuesto = presupuesto.Id;
            }
        }

        public virtual Categoria pCategoria
        {
            get { return categoria; }
            set
            {
                Categoria oldcat = categoria;
                categoria = value;
                Clave.IdCategoria = categoria.Id;
                OnChanged(new PresupuestoModelEventArgs("pCategoria",oldcat,categoria));
            }
        }

        public virtual Periodo pPeriodo
        {
            get { return periodo; }
            set
            {
                Periodo oldperiodo = periodo;
                periodo = value;
                Clave.IdPeriodo = periodo.Id;
                OnChanged(new PresupuestoModelEventArgs("pPeriodo",oldperiodo,periodo));
            }
        }

        public double Valor
        {
            get { return valor; }
            set
            {
                double oldValor = valor;
                 valor = value;
                OnChanged(new PresupuestoModelEventArgs("Valor",oldValor,valor));
            }
        }

        public  virtual ClaveCompuestaDetallePresupuesto Clave
        {
            get
            {
                if (clave == null)
                    clave = new ClaveCompuestaDetallePresupuesto();
                return clave;
            }
            set { clave = value; }
        }

        ///<summary>
        ///Compares the current object with another object of the same type.
        ///</summary>
        ///
        ///<returns>
        ///A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the other parameter.Zero This object is equal to other. Greater than zero This object is greater than other. 
        ///</returns>
        ///
        ///<param name="other">An object to compare with this object.</param>
        public int CompareTo(DetallePresupuesto other)
        {
            if (!pPresupuesto.Equals(other.pPresupuesto))
                return pPresupuesto.CompareTo(other.pPresupuesto);
            if (!pCategoria.Equals(other.pCategoria))
                return pCategoria.CompareTo(other.pCategoria);
            if (!pPeriodo.Equals(other.pPeriodo))
                return pPeriodo.CompareTo(other.pPeriodo);
         return 0;
        }
    }
}