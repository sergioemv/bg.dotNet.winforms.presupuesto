using ControlesPresupuesto;

namespace WinPresupuesto
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.panelNavegacion = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navTree = new NavigationTree();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.Presupuesto = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.mainMenu = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.Ver = new DevExpress.XtraBars.BarSubItem();
            this.Herramientas = new DevExpress.XtraBars.BarSubItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Navegacion = new DevExpress.XtraBars.BarCheckItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.defaultContainerPanel = new System.Windows.Forms.Panel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.panelNavegacion.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            // 
            // dockManager1
            // 
            this.dockManager1.Controller = this.barAndDockingController1;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelNavegacion});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar"});
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinName = "The Asphalt World";
            this.barAndDockingController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Controls.Add(this.dockPanel1_Container);
            this.panelNavegacion.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelNavegacion.ID = new System.Guid("7fef1f1f-54d5-4fe6-9944-3459fe788cb6");
            this.panelNavegacion.Location = new System.Drawing.Point(0, 45);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(233, 612);
            this.panelNavegacion.Text = "Navegación";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navTree);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(227, 584);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navTree
            // 
            this.navTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navTree.Location = new System.Drawing.Point(0, 0);
            this.navTree.Name = "navTree";
            this.navTree.Size = new System.Drawing.Size(227, 584);
            this.navTree.TabIndex = 0;
            this.navTree.NodeSelectedChanged += new WinPresupuesto.controls.NodeSelected(this.navTree_NodeSelectedChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.mainMenu,
            this.statusBar});
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Herramientas", new System.Guid("6c0d9318-049b-4013-9e66-a8da048f567d")),
            new DevExpress.XtraBars.BarManagerCategory("Archivo", new System.Guid("b8fe5b27-7fdc-4da5-ba50-b20ce395e00f")),
            new DevExpress.XtraBars.BarManagerCategory("Ver", new System.Guid("bcb4faaf-9874-4d27-a81e-f9fb33418711"))});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.btnSalir,
            this.Herramientas,
            this.Ver,
            this.Navegacion,
            this.Presupuesto,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.mainMenu;
            this.barManager1.MaxItemId = 22;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.barManager1.StatusBar = this.statusBar;
            // 
            // bar1
            // 
            this.bar1.BarName = "mainToolbar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.Presupuesto)});
            this.bar1.Text = "mainToolbar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.AccessibleDescription = "Organizar las Categorias de los presupuestos";
            this.barButtonItem1.AccessibleName = "Organizar las categorías";
            this.barButtonItem1.Caption = "Organizar Categorías";
            this.barButtonItem1.CategoryGuid = new System.Guid("6c0d9318-049b-4013-9e66-a8da048f567d");
            this.barButtonItem1.Hint = "Organizar las categorias";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageIndex = 1;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // Presupuesto
            // 
            this.Presupuesto.Caption = "Presupuesto";
            this.Presupuesto.CategoryGuid = new System.Guid("6c0d9318-049b-4013-9e66-a8da048f567d");
            this.Presupuesto.Id = 17;
            this.Presupuesto.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.Presupuesto.Name = "Presupuesto";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Crear Nuevo...";
            this.barButtonItem2.Id = 18;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Seleccionar Predeterminado";
            this.barButtonItem3.Id = 19;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Abrir";
            this.barButtonItem4.Id = 20;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Eliminar";
            this.barButtonItem5.Id = 21;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // mainMenu
            // 
            this.mainMenu.BarName = "mainMenu";
            this.mainMenu.DockCol = 0;
            this.mainMenu.DockRow = 0;
            this.mainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.Ver),
            new DevExpress.XtraBars.LinkPersistInfo(this.Herramientas)});
            this.mainMenu.OptionsBar.MultiLine = true;
            this.mainMenu.OptionsBar.UseWholeRow = true;
            this.mainMenu.Text = "Main Menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Archivo";
            this.barSubItem1.CategoryGuid = new System.Guid("b8fe5b27-7fdc-4da5-ba50-b20ce395e00f");
            this.barSubItem1.Id = 8;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "&Salir";
            this.btnSalir.CategoryGuid = new System.Guid("b8fe5b27-7fdc-4da5-ba50-b20ce395e00f");
            this.btnSalir.Id = 11;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // Ver
            // 
            this.Ver.Caption = "Ver";
            this.Ver.CategoryGuid = new System.Guid("bcb4faaf-9874-4d27-a81e-f9fb33418711");
            this.Ver.Id = 15;
            this.Ver.Name = "Ver";
            // 
            // Herramientas
            // 
            this.Herramientas.Caption = "&Herramientas";
            this.Herramientas.CategoryGuid = new System.Guid("6c0d9318-049b-4013-9e66-a8da048f567d");
            this.Herramientas.Id = 13;
            this.Herramientas.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.Presupuesto)});
            this.Herramientas.Name = "Herramientas";
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status Bar";
            // 
            // Navegacion
            // 
            this.Navegacion.Caption = "Navegación";
            this.Navegacion.CategoryGuid = new System.Guid("bcb4faaf-9874-4d27-a81e-f9fb33418711");
            this.Navegacion.Checked = true;
            this.Navegacion.Id = 16;
            this.Navegacion.Name = "Navegacion";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // defaultContainerPanel
            // 
            this.defaultContainerPanel.BackColor = System.Drawing.Color.Beige;
            this.defaultContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultContainerPanel.Location = new System.Drawing.Point(233, 45);
            this.defaultContainerPanel.Name = "defaultContainerPanel";
            this.defaultContainerPanel.Size = new System.Drawing.Size(673, 612);
            this.defaultContainerPanel.TabIndex = 6;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinPresupuesto.Properties.Resources.fondodetalle;
            this.ClientSize = new System.Drawing.Size(906, 679);
            this.Controls.Add(this.defaultContainerPanel);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Gastos y Presupuesto";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.panelNavegacion.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker worker;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.Docking.DockPanel panelNavegacion;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar mainMenu;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarSubItem Herramientas;
        private DevExpress.XtraBars.BarSubItem Ver;
        private DevExpress.XtraBars.BarCheckItem Navegacion;
        private System.Windows.Forms.Panel defaultContainerPanel;
        private NavigationTree navTree;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarSubItem Presupuesto;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}