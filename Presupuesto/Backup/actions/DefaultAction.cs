using System.Collections.Generic;
using System.Windows.Forms;
using WinPresupuesto.actions;

namespace WinPresupuesto.actions
{
    abstract class DefaultAction:IAction
    {
        protected string name = "";
        protected string mensajes = "";
        private Dictionary<EActionsParameters, object> parameters;

        public Dictionary<EActionsParameters, object> Parameters
        {
            get
            {
                if (parameters==null)
                    parameters = new Dictionary<EActionsParameters, object>();
                return parameters;
            }
        }

        public void Ejecutar()
        {
            if (PuedeEjecutar())
                Hacer();
            if (mensajes.Length != 0)
                MessageBox.Show(mensajes, name,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public abstract void Hacer();
        public abstract bool PuedeEjecutar();
        

        public string ObtenerMensajes()
        {
            return mensajes;
        }
    }
}