using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataModel.DAO;
using WinPresupuesto.actions;

namespace WinPresupuesto
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Actions.INSTANCE.getAction(EActions.GESTIONAR_CATEGORIAS).Ejecutar();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            
            fillPresupuestos();
            navTree.ExpandAll();
        }
        private void FillTree()
        {
            fillPresupuestos();
        }

        private void fillPresupuestos()
        {
            PresupuestoDAO dao = new PresupuestoDAO();
            IList<DataModel.Entidades.Presupuesto> preList = null;
            try
            {
              preList = dao.getPresupuestos();
            }catch
            {
                MessageBox.Show("No se pudieron obtener los presupuestos!");
                return;
            }
            TreeNodeCollection nodes = navTree.Nodes[0].Nodes.Find("PRESUPUESTOS_KEY", false)[0].Nodes;
            foreach (DataModel.Entidades.Presupuesto presupuesto in preList)
            {
                nodes.Add(presupuesto.Id.ToString(), presupuesto.Name, 2,2);
            }
        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void navTree_NodeSelectedChanged(object sender, TreeNodeMouseClickEventArgs e)
        {
            DefaultAction action = null;
            if (e.Node.Name == "PRESUPUESTOS_KEY")
            {
                action = Actions.INSTANCE.getAction(EActions.GESTIONAR_PRESUPUESTOS) as DefaultAction;
            }
            if (action == null) return;
            action.Parameters.Add(EActionsParameters.CONTAINER, defaultContainerPanel);
            action.Ejecutar();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DefaultAction action = null;
            action = Actions.INSTANCE.getAction(EActions.ADICIONAR_PRESUPUESTO) as DefaultAction;
            if (action == null) return;
            action.Parameters.Add(EActionsParameters.CONTAINER, defaultContainerPanel);
            action.Ejecutar();
        }

    }
}