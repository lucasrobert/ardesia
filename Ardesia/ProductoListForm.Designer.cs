namespace Ardesia
{
    partial class ProductoListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoListForm));
            this.repositoryItemLookUpEditEquipo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditSector = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mantenimientoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiasEstacionamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpFormula = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnSector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEditEquipo
            // 
            this.repositoryItemLookUpEditEquipo.AutoHeight = false;
            this.repositoryItemLookUpEditEquipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditEquipo.Name = "repositoryItemLookUpEditEquipo";
            // 
            // repositoryItemLookUpEditSector
            // 
            this.repositoryItemLookUpEditSector.AutoHeight = false;
            this.repositoryItemLookUpEditSector.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSector.Name = "repositoryItemLookUpEditSector";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "disk.png");
            this.imageList1.Images.SetKeyName(1, "door--arrow.png");
            this.imageList1.Images.SetKeyName(2, "plus-circle.png");
            this.imageList1.Images.SetKeyName(3, "cross-circle.png");
            this.imageList1.Images.SetKeyName(4, "magnifier-zoom.png");
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.mantenimientoGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpFormula});
            this.gridControl1.Size = new System.Drawing.Size(601, 311);
            this.gridControl1.TabIndex = 36;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mantenimientoGridView});
            // 
            // mantenimientoGridView
            // 
            this.mantenimientoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnNombre,
            this.gridColumnDiasEstacionamiento,
            this.gridColumnFormula,
            this.gridColumnSector});
            this.mantenimientoGridView.GridControl = this.gridControl1;
            this.mantenimientoGridView.Name = "mantenimientoGridView";
            this.mantenimientoGridView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.mantenimientoGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.mantenimientoGridView.OptionsPrint.PrintFilterInfo = true;
            this.mantenimientoGridView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.mantenimientoGridView.OptionsView.ShowAutoFilterRow = true;
            this.mantenimientoGridView.OptionsView.ShowFooter = true;
            this.mantenimientoGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            // 
            // gridColumnNombre
            // 
            this.gridColumnNombre.Caption = "Nombre";
            this.gridColumnNombre.Name = "gridColumnNombre";
            this.gridColumnNombre.Visible = true;
            this.gridColumnNombre.VisibleIndex = 1;
            // 
            // gridColumnDiasEstacionamiento
            // 
            this.gridColumnDiasEstacionamiento.Caption = "Dias estacionamiento";
            this.gridColumnDiasEstacionamiento.Name = "gridColumnDiasEstacionamiento";
            this.gridColumnDiasEstacionamiento.Visible = true;
            this.gridColumnDiasEstacionamiento.VisibleIndex = 2;
            // 
            // gridColumnFormula
            // 
            this.gridColumnFormula.Caption = "Formula";
            this.gridColumnFormula.ColumnEdit = this.repositoryItemLookUpFormula;
            this.gridColumnFormula.Name = "gridColumnFormula";
            this.gridColumnFormula.Visible = true;
            this.gridColumnFormula.VisibleIndex = 3;
            // 
            // repositoryItemLookUpFormula
            // 
            this.repositoryItemLookUpFormula.AutoHeight = false;
            this.repositoryItemLookUpFormula.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpFormula.Name = "repositoryItemLookUpFormula";
            // 
            // gridColumnSector
            // 
            this.gridColumnSector.Caption = "Sector";
            this.gridColumnSector.ColumnEdit = this.repositoryItemLookUpEditSector;
            this.gridColumnSector.Name = "gridColumnSector";
            this.gridColumnSector.Visible = true;
            this.gridColumnSector.VisibleIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 1;
            this.simpleButton1.ImageOptions.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(512, 329);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 22);
            this.simpleButton1.TabIndex = 52;
            this.simpleButton1.Text = "&Borrar";
            // 
            // editSimpleButton
            // 
            this.editSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editSimpleButton.ImageOptions.ImageIndex = 2;
            this.editSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.editSimpleButton.Location = new System.Drawing.Point(408, 329);
            this.editSimpleButton.Name = "editSimpleButton";
            this.editSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.editSimpleButton.TabIndex = 51;
            this.editSimpleButton.Text = "&Editar";
            this.editSimpleButton.Click += new System.EventHandler(this.editSimpleButton_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 0;
            this.simpleButton2.ImageOptions.ImageList = this.imageList1;
            this.simpleButton2.Location = new System.Drawing.Point(301, 329);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(101, 22);
            this.simpleButton2.TabIndex = 50;
            this.simpleButton2.Text = "&Agregar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ProductoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 363);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.editSimpleButton);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpFormula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView mantenimientoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormula;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSector;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditEquipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSector;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton editSimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiasEstacionamiento;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpFormula;
    }
}