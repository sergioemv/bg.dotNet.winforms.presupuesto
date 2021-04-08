using System;

namespace DataModel.Entidades
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    public class PresupuestoModelEventArgs:EventArgs
    {
        private string field;
        private object oldValue;
        private object newValue;
        public PresupuestoModelEventArgs(string field, object oldValue, object newValue)
        {
            this.field = field;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

        public PresupuestoModelEventArgs(string field)
        {
            this.field = field;
        }

        public string Field
        {
            get { return field; }
            set { field = value; }
        }

        public object OldValue
        {
            get { return oldValue; }
            set { oldValue = value; }
        }

        public object NewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }
    }
    public abstract class EntidadConEventos 

    {
        public virtual event ChangedEventHandler Changed;
        protected virtual void OnChanged(PresupuestoModelEventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }
    }
}
