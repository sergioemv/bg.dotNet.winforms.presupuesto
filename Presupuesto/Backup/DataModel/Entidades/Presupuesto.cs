using System;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Entidades
{
    
    public class Presupuesto :EntidadConEventos, IEquatable<Presupuesto>, IComparable<Presupuesto>, DetallePresupuestosBean  
    {
        private int id;
        private string name;
        private string description;
        private string orden = "";
        private DateTime fecha;
        private IList<DetallePresupuesto> detalles;

        bool IEquatable<Presupuesto>.Equals(Presupuesto obj)
        {
            if (obj == null) return false;

            return obj.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return Name;
        }
        
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

       
        public virtual string Orden
        {
            get { return orden; }
            set
            {
                string oldOrden = orden;
                orden = value;
                OnChanged(new PresupuestoModelEventArgs("Orden",oldOrden,orden));
            }
        }
        
        
        public virtual string Name
        {
            get { return name; }
            set
            {
                string oldvalue = name;
                name = value;
                OnChanged(new PresupuestoModelEventArgs("Name",oldvalue,name));
            }
        }
        
        
        public virtual string Description
        {
            get { return description; }
            set
            {
                string oldvalue = description;
                description = value;
                OnChanged(new PresupuestoModelEventArgs("Description", oldvalue, value));
            }
        }
        
    
        public virtual DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public virtual IList<DetallePresupuesto> Detalles
        {
            get
            {
                if (detalles == null)
                    detalles = new List<DetallePresupuesto>();
                 return detalles;
            }
            set { detalles = value; }
        }


        public Presupuesto(string s)
        {
            name = s;
        }
        public Presupuesto()
        {
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
        public int CompareTo(Presupuesto other)
        {
            if (Orden!=null && other.Orden!=null)
                return Orden.CompareTo(other.Orden.ToString());
            return Id.ToString().CompareTo(other.Id.ToString());
        }

        #region DetallePresupuestosBean Members

        public IList<DetallePresupuesto> getDetallePresupuesto()
        {
            List<DetallePresupuesto> ldetalles = new List<DetallePresupuesto>();
            ldetalles.AddRange(Detalles);
            ldetalles.Sort();
            return ldetalles;
        }

        public void addDetallePresupuesto(DetallePresupuesto detallePresupuesto)
        {
            Detalles.Add(detallePresupuesto);
            detallePresupuesto.pPresupuesto = this;
            OnChanged(new PresupuestoModelEventArgs("Detalles"));
        }

        public void removeDetallePresupuesto(DetallePresupuesto detallePresupuesto)
        {
            Detalles.Remove(detallePresupuesto);
            detallePresupuesto.pPresupuesto = null;
            OnChanged(new PresupuestoModelEventArgs("Detalles"));
        }

        #endregion
    }

    public interface DetallePresupuestosBean
    {
        IList<DetallePresupuesto> getDetallePresupuesto();
        void addDetallePresupuesto(DetallePresupuesto detallePresupuesto);
        void removeDetallePresupuesto(DetallePresupuesto detallePresupuesto);
    }
}