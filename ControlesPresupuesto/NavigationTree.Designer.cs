namespace ControlesPresupuesto
{
    partial class NavigationTree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Presupuestos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Inicio", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationTree));
            this.navTree = new System.Windows.Forms.TreeView();
            this.mainList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // navTree
            // 
            this.navTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navTree.ImageIndex = 0;
            this.navTree.ImageList = this.mainList;
            this.navTree.Location = new System.Drawing.Point(0, 0);
            this.navTree.Name = "navTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "PRESUPUESTOS_KEY";
            treeNode1.SelectedImageKey = "Summary-2.bmp";
            treeNode1.Text = "Presupuestos";
            treeNode2.ImageKey = "home.bmp";
            treeNode2.Name = "Inicio";
            treeNode2.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.SelectedImageKey = "home.bmp";
            treeNode2.Text = "Inicio";
            this.navTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.navTree.SelectedImageIndex = 2;
            this.navTree.ShowRootLines = false;
            this.navTree.Size = new System.Drawing.Size(405, 383);
            this.navTree.TabIndex = 1;
            this.navTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.navTree_AfterSelect);
            this.navTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.navTree_NodeMouseClick);
            // 
            // mainList
            // 
            this.mainList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainList.ImageStream")));
            this.mainList.TransparentColor = System.Drawing.Color.Fuchsia;
            this.mainList.Images.SetKeyName(0, "home.bmp");
            this.mainList.Images.SetKeyName(1, "Summary-2.bmp");
            this.mainList.Images.SetKeyName(2, "Summary.bmp");
            // 
            // NavigationTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navTree);
            this.Name = "NavigationTree";
            this.Size = new System.Drawing.Size(405, 383);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView navTree;
        private System.Windows.Forms.ImageList mainList;

    }
}