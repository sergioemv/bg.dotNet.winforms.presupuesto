using System;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Entidades
{
    public enum ETipoCategoria
    {
        INGRESO,EGRESO,OTRO
    }
    public class Categoria :Entidades.EntidadConEventos, IEquatable<Categoria>, CategoriasBean, IComparable<Categoria>  
    {
        private int id;
        private string description;
        private string orden = "";
        private string name;
        private string tipo;
        private Categoria parent;
        private IList<Categoria> children;

        bool IEquatable<Categoria>.Equals(Categoria obj)
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
            set { orden = value; }
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
                OnChanged(new PresupuestoModelEventArgs("Description", oldvalue, description));
            }
        }

        public virtual Categoria Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public virtual IList<Categoria> Children
        {
            get
            {
                if (children == null)
                    children = new List<Categoria>();
                return children;
            }
            set { children = value; }
        }
        
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public ETipoCategoria getTipoCategoria()
        {
            switch (tipo)
            {
                case "E":
                    return ETipoCategoria.EGRESO;
                case "I":
                    return ETipoCategoria.INGRESO;
                default:
                    return ETipoCategoria.OTRO;
            }
        }
        public void setTipoCategoria(ETipoCategoria tipoCat)
        {
            switch (tipoCat)
            {
                case ETipoCategoria.EGRESO:
                    Tipo = "E";
                    break;
                case ETipoCategoria.INGRESO:
                    Tipo = "I";
                    break;
                default:
                    break;
            }
        }
        public IList<Categoria> getChildrenOrdered()
        {
            List<Categoria> result = new List<Categoria>();
            result.AddRange(Children);
            result.Sort();
            return result;
        }


       
        public Categoria(string s)
        {
            name = s;
        }
        public Categoria()
        {
        }

        #region CategoriasBean Members

        public void addCategoria(Categoria categoria)
        {
            Children.Add(categoria);
            categoria.Parent = this;
            OnChanged(new PresupuestoModelEventArgs("Children"));
        }

        public IList<Categoria> getCategorias()
        {
            return Children;
        }

        public void removeCategoria(Categoria categoria)
        {
            Children.Remove(categoria);
            categoria.Parent = null;
            OnChanged(new PresupuestoModelEventArgs("Children"));
        }

        #endregion

        ///<summary>
        ///Compares the current object with another object of the same type.
        ///</summary>
        ///
        ///<returns>
        ///A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the other parameter.Zero This object is equal to other. Greater than zero This object is greater than other. 
        ///</returns>
        ///
        ///<param name="other">An object to compare with this object.</param>
        public int CompareTo(Categoria other)
        {
            return Orden.CompareTo(other.Orden.ToString());
        }
    }
}