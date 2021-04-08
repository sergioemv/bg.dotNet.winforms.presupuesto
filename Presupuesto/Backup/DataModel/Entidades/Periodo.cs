using System;

namespace DataModel.Entidades
{
    public class Periodo:Entidades.EntidadConEventos, IEquatable<Periodo>,IComparable<Periodo>  
    
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string tipo;
        private int orden;

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public virtual string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public virtual string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public virtual int Orden
        {
            get { return orden; }
            set { orden = value; }
        }

        public bool Equals(Periodo other)
        {
            if (other == null) return false;

            return other.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


        public int CompareTo(Periodo other)
        {
            return Orden.CompareTo(other.Orden.ToString()); 
        }
    }
}
