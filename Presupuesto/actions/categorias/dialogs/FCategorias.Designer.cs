using BtnOkCancel=ControlesPresupuesto.BtnOkCancel;

namespace WinPresupuesto.actions.categorias.dialogs
{
    partial class FCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCategorias));
            this.treeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarAlLadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAbajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenesArbol = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.adicionarSubCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.categoriasTree = new System.Windows.Forms.TreeView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOkCancel1 = new BtnOkCancel();
            this.treeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMenu
            // 
            this.treeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarAlLadoToolStripMenuItem,
            this.adicionarAbajoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.eliminarCategoríaToolStripMenuItem});
            this.treeMenu.Name = "contextMenuStrip1";
            this.treeMenu.Size = new System.Drawing.Size(251, 92);
            // 
            // adicionarAlLadoToolStripMenuItem
            // 
            this.adicionarAlLadoToolStripMenuItem.Name = "adicionarAlLadoToolStripMenuItem";
            this.adicionarAlLadoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.adicionarAlLadoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.adicionarAlLadoToolStripMenuItem.Text = "Adicionar Categoría al lado";
            this.adicionarAlLadoToolStripMenuItem.Click += new System.EventHandler(this.adicionarAlLadoToolStripMenuItem_Click);
            // 
            // adicionarAbajoToolStripMenuItem
            // 
            this.adicionarAbajoToolStripMenuItem.Name = "adicionarAbajoToolStripMenuItem";
            this.adicionarAbajoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)));
            this.adicionarAbajoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.adicionarAbajoToolStripMenuItem.Text = "Adicionar Categoría abajo";
            this.adicionarAbajoToolStripMenuItem.Click += new System.EventHandler(this.adicionarAbajoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItem3.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem3.Text = "Editar Categoría";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // eliminarCategoríaToolStripMenuItem
            // 
            this.eliminarCategoríaToolStripMenuItem.Name = "eliminarCategoríaToolStripMenuItem";
            this.eliminarCategoríaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.eliminarCategoríaToolStripMenuItem.Text = "Eliminar Categoría";
            this.eliminarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCategoríaToolStripMenuItem_Click);
            // 
            // imagenesArbol
            // 
            this.imagenesArbol.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenesArbol.ImageStream")));
            this.imagenesArbol.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imagenesArbol.Images.SetKeyName(0, "Box Closed.bmp");
            this.imagenesArbol.Images.SetKeyName(1, "Box Open.bmp");
            this.imagenesArbol.Images.SetKeyName(2, "note.bmp");
            this.imagenesArbol.Images.SetKeyName(3, "last.bmp");
            this.imagenesArbol.Images.SetKeyName(4, "arrowup_green16.bmp");
            this.imagenesArbol.Images.SetKeyName(5, "arrowdown_red16.bmp");
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarSubCatToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 17);
            this.toolStripSplitButton1.Text = "Nueva";
            this.toolStripSplitButton1.ToolTipText = "Adicionar Nueva Categoria";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // adicionarSubCatToolStripMenuItem
            // 
            this.adicionarSubCatToolStripMenuItem.Image = global::WinPresupuesto.Properties.Resources.properties24_h;
            this.adicionarSubCatToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.adicionarSubCatToolStripMenuItem.Name = "adicionarSubCatToolStripMenuItem";
            this.adicionarSubCatToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.adicionarSubCatToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.adicionarSubCatToolStripMenuItem.Text = "Nueva";
            this.adicionarSubCatToolStripMenuItem.Click += new System.EventHandler(this.adicionar);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WinPresupuesto.Properties.Resources.treenode_add;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItem1.Text = "Nueva Sub Categoria";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AdicionarSub);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 17);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.Editar);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(47, 17);
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.Click += new System.EventHandler(this.Borrar);
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.FloatOnDblClick = false;
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar"});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.Location = new System.Drawing.Point(2, 19);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(364, 270);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Borrar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Editar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nueva Sub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AdicionarSub);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.adicionar);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 59);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.categoriasTree);
            this.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(578, 297);
            this.splitContainerControl1.SplitterPosition = 198;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // categoriasTree
            // 
            this.categoriasTree.ContextMenuStrip = this.treeMenu;
            this.categoriasTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriasTree.HotTracking = true;
            this.categoriasTree.ImageIndex = 3;
            this.categoriasTree.ImageList = this.imagenesArbol;
            this.categoriasTree.Location = new System.Drawing.Point(0, 0);
            this.categoriasTree.Name = "categoriasTree";
            this.categoriasTree.SelectedImageIndex = 3;
            this.categoriasTree.ShowPlusMinus = false;
            this.categoriasTree.ShowRootLines = false;
            this.categoriasTree.Size = new System.Drawing.Size(192, 291);
            this.categoriasTree.TabIndex = 2;
            this.categoriasTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.categoriasTree_NodeMouseDoubleClick);
            this.categoriasTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoriasTree_AfterSelect);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.button4);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.button3);
            this.groupControl2.Controls.Add(this.button2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 191);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(368, 100);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Controles";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 291);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Descripción";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(578, 54);
            this.panelControl1.TabIndex = 7;
            this.panelControl1.Text = "panelControl1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Use esta página para crear y gestionar las categorías que clasifican los presupue" +
                "stos y gastos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorías";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinPresupuesto.Properties.Resources.treenode_add;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnOkCancel1
            // 
            this.btnOkCancel1.BackColor = System.Drawing.SystemColors.Control;
            this.btnOkCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOkCancel1.Location = new System.Drawing.Point(2, 354);
            this.btnOkCancel1.Name = "btnOkCancel1";
            this.btnOkCancel1.Size = new System.Drawing.Size(578, 43);
            this.btnOkCancel1.TabIndex = 8;
            // 
            // FCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.btnOkCancel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FCategorias";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizar Categorías";
            this.Load += new System.EventHandler(this.FCategorias_Load);
            this.treeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem adicionarSubCatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ImageList imagenesArbol;
        private System.Windows.Forms.ContextMenuStrip treeMenu;
        private System.Windows.Forms.ToolStripMenuItem adicionarAlLadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAbajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoríaToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        public System.Windows.Forms.TreeView categoriasTree;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BtnOkCancel btnOkCancel1;

    }
}