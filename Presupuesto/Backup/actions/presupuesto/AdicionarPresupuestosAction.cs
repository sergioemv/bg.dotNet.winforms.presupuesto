using System;
using System.Windows.Forms;
using ControlesPresupuesto;

namespace WinPresupuesto.actions.presupuesto
{
    class AdicionarPresupuestosAction:DefaultAction
    {

        public AdicionarPresupuestosAction()
        {
            name = "Adicionar Presupuesto";
        
        }

        public override void Hacer()
        {
            try
            {
                Panel panel = Parameters[EActionsParameters.CONTAINER] as Panel;
                if (panel == null) return;
                PresupuestoEdit control = new PresupuestoEdit();
             //   adicionarTipodePresupuesto(control.comboPeriodoBase.t)
                panel.Controls.Clear();
                panel.Controls.Add(control);
                control.Dock = DockStyle.Fill;
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