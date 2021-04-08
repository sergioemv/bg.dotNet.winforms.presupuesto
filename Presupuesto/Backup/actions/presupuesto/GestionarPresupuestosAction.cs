using System;
using System.Windows.Forms;
using ControlesPresupuesto;

namespace WinPresupuesto.actions.presupuesto
{
    class GestionarPresupuestosAction:DefaultAction
    {
        
        public GestionarPresupuestosAction()
        {
            name = "Gestionar Presupuestos";
        
        }

        public override void Hacer()
        {
            try
            {
                Panel panel = Parameters[EActionsParameters.CONTAINER] as Panel;
                if (panel == null) return;
                PresupuestosMain control = new PresupuestosMain();
                panel.Controls.Clear();
                panel.Controls.Add(control);
                control.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            catch (Exception e)
            {
                mensajes = "No se pudieron editar los presupuestos \n"+ e.Message;
            }
        }

        


        public override bool PuedeEjecutar()
        {
            return Parameters.ContainsKey(EActionsParameters.CONTAINER);
        }
    }
}