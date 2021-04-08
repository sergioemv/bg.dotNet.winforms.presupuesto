using System;

namespace DataModel.Entidades
{
    public class Proveedor:EntidadConEventos, IEquatable<Proveedor>,IComparable<Proveedor>  
    
    {
        private int id;
        private string nombre = "";

        public Proveedor(string nombre)
        {
            this.nombre = nombre;
        }
        public Proveedor()
        {
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Nombre
        {
            get { return nombre; }
            set
            {
                string oldValue = nombre;
                nombre = value;
                OnChanged(new PresupuestoModelEventArgs("Nombre",oldValue,nombre));
            }
        }

       
        public bool Equals(Proveedor other)
        {
            if (other == null) return false;

            return other.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


        public int CompareTo(Proveedor other)
        {
            return Nombre.CompareTo(other.Nombre); 
        }
    }

    }
