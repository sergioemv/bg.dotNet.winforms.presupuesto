using System;

namespace DataModel.Entidades
{
    public class DetalleTransaccion:EntidadConEventos, IEquatable<DetalleTransaccion>,IComparable<DetalleTransaccion>  
    
    {
        private int id;
        private Transaccion transaccionPadre;
        private Categoria categoriaAsignada;
        private double montoPagado;
        private double montoFacturado;
        private string memo;

        public DetalleTransaccion(Categoria cat)
        {
            categoriaAsignada = cat;
        }
        public DetalleTransaccion()
        {
        
        }
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual Transaccion TransaccionPadre
        {
            get { return transaccionPadre; }
            set
            {
                transaccionPadre = value;
                OnChanged(new PresupuestoModelEventArgs("TransaccionPadre"));
            }
        }

        public virtual Categoria CategoriaAsignada
        {
            get { return categoriaAsignada; }
            set
            {
                categoriaAsignada = value;
                OnChanged(new PresupuestoModelEventArgs("CategoriaAsignada"));
            }
        }

        public virtual double MontoPagado
        {
            get { return montoPagado; }
            set
            {
                double oldvalue = montoPagado;
                montoPagado = value;
                OnChanged(new PresupuestoModelEventArgs("MontoPagado",oldvalue,montoPagado));
            }
        }

        public virtual double MontoFacturado
        {
            get { return montoFacturado; }
            set
            {
                double oldValue = montoFacturado;
                montoFacturado = value;
                OnChanged(new PresupuestoModelEventArgs("MontoFacturado",oldValue,montoFacturado));
            }
        }

        public virtual string Memo
        {
            get { return memo; }
            set
            {
                string oldValue = memo;
                memo = value;
                OnChanged(new PresupuestoModelEventArgs("Memo",oldValue,memo));
            }
        }
        public bool Equals(DetalleTransaccion other)
        {
            if (other == null) return false;

            return other.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public int CompareTo(DetalleTransaccion other)
        {
            return CategoriaAsignada.CompareTo(other.CategoriaAsignada); 
        }
    }
}
