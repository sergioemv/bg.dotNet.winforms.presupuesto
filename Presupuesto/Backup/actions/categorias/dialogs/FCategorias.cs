using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DataModel.Entidades;
using Presupuesto.actions.util;

namespace WinPresupuesto.actions.categorias.dialogs
{
    public partial class FCategorias : Form
    {
        private IdSet idSet;
        private IList<Categoria> categorias;    
        public IList<Categoria> Categorias
        {
            set { categorias = value; }
        }

        public IdSet pIdSet
        {
            set { idSet = value; }
        }

        public FCategorias()
        {
            InitializeComponent();
            //inicializacion manual
            this.CancelButton = this.btnOkCancel1.btnCancel;
        }

        public void fillTree()
        {
            categoriasTree.Nodes.Clear();
            TreeNode rootnode = null, ingresosNode,egresosNode;
            ingresosNode = new TreeNode("INGRESOS");
            ingresosNode.ImageIndex = 4;
            ingresosNode.SelectedImageIndex = 4;
            ingresosNode.Name = "INGRESOS_KEY_INDEX";
            egresosNode = new TreeNode("EGRESOS");
            egresosNode.ImageIndex = 5;
            egresosNode.SelectedImageIndex = 5;
            egresosNode.Name = "EGRESOS_KEY_INDEX";
            //adicionar el nodo de ingresos y egresos
            categoriasTree.Nodes.Add(egresosNode);
            categoriasTree.Nodes.Add(ingresosNode);
            if (categorias == null) throw new ArgumentException("lista de categorias nula");
            
            foreach (Categoria categoria in categorias)
            {
                categoria.Changed += new ChangedEventHandler(CambioCategoria);
                if (categoria.Parent == null)
                {
                    if (categoria.getTipoCategoria() == ETipoCategoria.EGRESO)
                        rootnode = egresosNode;
                    if (categoria.getTipoCategoria() == ETipoCategoria.INGRESO)
                        rootnode = ingresosNode;
                    if (rootnode != null)
                        rootnode.Nodes.Add(categoria.Id.ToString(), categoria.ToString(), 2);
                    else
                        categoriasTree.Nodes.Add(categoria.Id.ToString(), categoria.ToString(), 2);
                    if (categoria.Children.Count > 0)
                    {
                        TreeNode[] childNodes = null;
                        if (rootnode != null)
                        {
                            childNodes = rootnode.Nodes.Find(categoria.Id.ToString(), true);
                        }
                        else
                            childNodes = categoriasTree.Nodes.Find(categoria.Id.ToString(), true);
                        if (childNodes.Length > 0)
                        {
                            childNodes[0].ImageIndex = 0;
                            childNodes[0].SelectedImageIndex = 1;
                            fillChildNodes(childNodes[0], categoria.getChildrenOrdered());
                        }
                    }
                }
            }
            categoriasTree.ExpandAll();
        }

        private void CambioCategoria(object sender, EventArgs e)
        {
            if (sender is Categoria )
            {
                categoriasTree.Nodes.Find((sender as Categoria).Id.ToString(), true)[0].Text =
                    (sender as Categoria).Name;
                txtDescripcion.Text = (sender as Categoria).Description;
            }
        }

        private void fillChildNodes(TreeNode node, IEnumerable<Categoria> children)
        {
            if (children == null) throw new ArgumentException("lista de categorias hijas nula");
            foreach (Categoria child in children)
            {
                node.Nodes.Add(child.Id.ToString(),child.ToString(),2);
                if (child.Children.Count > 0)
                {
                    TreeNode[] childNodes = node.Nodes.Find(child.Id.ToString(), true);
                    if (childNodes.Length > 0)
                    {
                        childNodes[0].ImageIndex = 0;
                        childNodes[0].SelectedImageIndex = 1;
                        fillChildNodes(childNodes[0], child.getChildrenOrdered());
                    }
                }
            }
        }

       
        private void categoriasTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string key = e.Node.Name;

            foreach (Categoria cat in categorias)
            {
                if (cat.Id.ToString() == key)
                {
                    txtDescripcion.Text = cat.Description;
                    return;
                }
            }
            if (e.Node.Name == "INGRESOS_KEY_INDEX")
                txtDescripcion.Text = "Son todas las categorias por las cuales se deberá recibir dinero";
            if (e.Node.Name == "EGRESOS_KEY_INDEX")
                txtDescripcion.Text = "Son todas las categorias por las cuales se deberá hacer gastos de dinero";
        }

        private void categoriasTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            Editar(sender,e);
           
        }
        private void Editar(object sender, EventArgs e)
        {
            if (categoriasTree.SelectedNode == null) return;
            DefaultAction action = Actions.INSTANCE.getAction(EActions.EDITAR_CATEGORIA) as DefaultAction;
            if (action == null) return;
            action.Parameters.Add(EActionsParameters.CATEGORIAS, categorias);
            foreach (Categoria cat in categorias)
            {
                if (cat.Id.ToString() == categoriasTree.SelectedNode.Name)
                    action.Parameters.Add(EActionsParameters.CATEGORIA, cat);
            }
            action.Ejecutar();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Editar(sender,e);
        }

        private void adicionar(object sender, EventArgs e)
        {
           
            DefaultAction action = Actions.INSTANCE.getAction(EActions.ADICIONAR_CATEGORIA_AL_LADO) as DefaultAction;
            if (action == null) return;
            if (categoriasTree.SelectedNode==null) return;
            action.Parameters.Add(EActionsParameters.CATEGORIAS, categorias);
            action.Parameters.Add(EActionsParameters.IDS,idSet);
            foreach (Categoria cat in categorias)
            {
                if (cat.Id.ToString() == categoriasTree.SelectedNode.Name)
                    action.Parameters.Add(EActionsParameters.CATEGORIA, cat);
            }
            if (categoriasTree.SelectedNode.Name=="INGRESOS_KEY_INDEX")
                action.Parameters.Add(EActionsParameters.TIPO_CATEGORIA,ETipoCategoria.INGRESO);
            if (categoriasTree.SelectedNode.Name == "EGRESOS_KEY_INDEX")
                action.Parameters.Add(EActionsParameters.TIPO_CATEGORIA, ETipoCategoria.EGRESO);
            action.Ejecutar();
            fillTree();
            //seleccionar la nueva categoria
            if (!action.Parameters.ContainsKey(EActionsParameters.NUEVA_CATEGORIA)) return;
            Categoria nuevacat = action.Parameters[EActionsParameters.NUEVA_CATEGORIA] as Categoria;
            if (nuevacat == null) return;
            categoriasTree.SelectedNode = categoriasTree.Nodes.Find(nuevacat.Id.ToString(), true)[0];


        }

        private void AdicionarSub(object sender, EventArgs e)
        {
            if (categoriasTree.SelectedNode == null) return;
            DefaultAction action = Actions.INSTANCE.getAction(EActions.ADICIONAR_CATEGORIA_HIJA) as DefaultAction;
            if (action == null) return;
            action.Parameters.Add(EActionsParameters.CATEGORIAS, categorias);
            action.Parameters.Add(EActionsParameters.IDS, idSet);
            foreach (Categoria cat in categorias)
            {
                if (cat.Id.ToString() == categoriasTree.SelectedNode.Name)
                    action.Parameters.Add(EActionsParameters.CATEGORIA, cat);
            }
            action.Ejecutar();
            fillTree();
            //seleccionar la nueva categoria
            if (!action.Parameters.ContainsKey(EActionsParameters.NUEVA_CATEGORIA)) return;
            Categoria nuevacat = action.Parameters[EActionsParameters.NUEVA_CATEGORIA] as Categoria;
            if (nuevacat == null) return;
            categoriasTree.SelectedNode = categoriasTree.Nodes.Find(nuevacat.Id.ToString(), true)[0];
        }

        private void adicionarAlLadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adicionar(sender, e);
        }

        private void adicionarAbajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarSub(sender, e);
        }

        private void Borrar(object sender, EventArgs e)
        {
            if (categoriasTree.SelectedNode == null) return;
            DefaultAction action = Actions.INSTANCE.getAction(EActions.ELIMINAR_CATEGORIA) as DefaultAction;
            if (action == null) return;
            action.Parameters.Add(EActionsParameters.CATEGORIAS, categorias);
            foreach (Categoria cat in categorias)
            {
                if (cat.Id.ToString() == categoriasTree.SelectedNode.Name)
                    action.Parameters.Add(EActionsParameters.CATEGORIA, cat);
            }
            action.Ejecutar();
            fillTree();
            
            
        }

        private void categoriasTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
                adicionar(sender, e);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            adicionar(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarSub(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editar(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Borrar(sender,e);
        }

        private void FCategorias_Load(object sender, EventArgs e)
        {

        }

        private void eliminarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

      

       
    }
}