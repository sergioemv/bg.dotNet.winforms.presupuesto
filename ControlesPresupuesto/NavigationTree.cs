using System.Collections.Generic;
using System.Windows.Forms;
using WinPresupuesto.controls;

namespace ControlesPresupuesto
{
    public partial class NavigationTree : UserControl
    {
        public event NodeSelected NodeSelectedChanged;
        
        public NavigationTree()
        {
            InitializeComponent();
            
        }

        public TreeNodeCollection Nodes
        {
            get { return navTree.Nodes; }
        }

        //fills the navigation tree contents
        

        private void navTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        public void ExpandAll()
        {
            navTree.ExpandAll();
        }

        private void navTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NodeSelectedChanged(this, e);
        }
    }
}

namespace WinPresupuesto.controls
{
    public delegate void NodeSelected(object sender, TreeNodeMouseClickEventArgs e);
}