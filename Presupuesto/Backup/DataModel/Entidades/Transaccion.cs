using System;
using System.Collections.Generic;

namespace DataModel.Entidades
{
    public class Transaccion:EntidadConEventos, IEquatable<Transaccion>,IComparable<Transaccion> , DetallesTransaccionBean
    
    {
        private int id;
        private string nroFactura;
        private string memo;
        private DateTime fecha = DateTime.Today;
        private Proveedor proveedor;
        private IList<DetalleTransaccion> detalles;

        public Transaccion()
        {
        }

        public Transaccion(Proveedor prv)
        {
            proveedor = prv;
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                DateTime oldfecha = fecha;
                fecha = value;
                OnChanged(new PresupuestoModelEventArgs("Fecha",oldfecha,fecha));
            }
        }

        public virtual Proveedor pProveedor
        {
            get { return proveedor; }
            set
            {
                proveedor = value;
                OnChanged(new PresupuestoModelEventArgs("Proveedor"));
            }
        }

        public virtual string NroFactura
        {
            get { return nroFactura; }
            set
            {
                string oldValue = nroFactura;
                nroFactura = value;
                OnChanged(new PresupuestoModelEventArgs("NroFactura",oldValue,nroFactura));
            }
        }

        public virtual string Memo
        {
            get { return memo; }
            set
            {
                string oldvalue = memo;
                memo = value;
                OnChanged(new PresupuestoModelEventArgs("Memo",oldvalue,memo));
            }
        }

        public virtual IList<DetalleTransaccion> Detalles
        {
            get
            {
                if (detalles == null)
                    detalles = new List<DetalleTransaccion>();
                return detalles;
            }
            set { detalles = value; }
        }


        public bool Equals(Transaccion other)
        {
            if (other == null) return false;

            return other.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


        public int CompareTo(Transaccion other)
        {
            return Fecha.CompareTo(other.Fecha); 
        }

        #region DetallesTransaccionBean Members

        public IList<DetalleTransaccion> getDetallesTransaccion()
        {
            List<DetalleTransaccion> detallesTransaccions = new List<DetalleTransaccion>();
            detallesTransaccions.AddRange(Detalles);
            detallesTransaccions.Sort();
            return detallesTransaccions;
        }

        public void addDetalleTransaccion(DetalleTransaccion detalleTransaccion)
        {
           Detalles.Add(detalleTransaccion);
            detalleTransaccion.TransaccionPadre = this;
            OnChanged(new PresupuestoModelEventArgs("DetallesTransaccion"));
        }

        public void removeDetalleTransaccion(DetalleTransaccion detalleTransaccion)
        {
            Detalles.Remove(detalleTransaccion);
            detalleTransaccion.TransaccionPadre = null;
            OnChanged(new PresupuestoModelEventArgs("DetallesTransaccion"));
        }

        #endregion
    }

    public interface DetallesTransaccionBean
    {
        IList<DetalleTransaccion> getDetallesTransaccion();
        void addDetalleTransaccion(DetalleTransaccion detalleTransaccion);
        void removeDetalleTransaccion(DetalleTransaccion detalleTransaccion);
    }
}
