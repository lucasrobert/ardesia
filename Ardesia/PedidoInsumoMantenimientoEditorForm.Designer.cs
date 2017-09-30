namespace Ardesia
{
    partial class PedidoInsumoMantenimientoEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoInsumoMantenimientoEditorForm));
            this.repositoryItemLookUpEditEquipo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.verInsumosSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mantenimientoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numeroLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.numeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.mantLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.proveedorLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.fechaLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.empleadoLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEditEquipo
            // 
            this.repositoryItemLookUpEditEquipo.AutoHeight = false;
            this.repositoryItemLookUpEditEquipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditEquipo.Name = "repositoryItemLookUpEditEquipo";
            // 
            // repositoryItemLookUpEditEmpleado
            // 
            this.repositoryItemLookUpEditEmpleado.AutoHeight = false;
            this.repositoryItemLookUpEditEmpleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditEmpleado.Name = "repositoryItemLookUpEditEmpleado";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(515, 329);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.exitSimpleButton.TabIndex = 12;
            this.exitSimpleButton.Text = "&Salir";
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
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(408, 329);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(101, 22);
            this.saveSimpleButton.TabIndex = 11;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // verInsumosSimpleButton
            // 
            this.verInsumosSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.verInsumosSimpleButton.ImageOptions.ImageIndex = 4;
            this.verInsumosSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.verInsumosSimpleButton.Location = new System.Drawing.Point(12, 329);
            this.verInsumosSimpleButton.Name = "verInsumosSimpleButton";
            this.verInsumosSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.verInsumosSimpleButton.TabIndex = 10;
            this.verInsumosSimpleButton.Text = "&Ver insumos";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 189);
            this.gridControl1.MainView = this.mantenimientoGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(601, 134);
            this.gridControl1.TabIndex = 36;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mantenimientoGridView});
            // 
            // mantenimientoGridView
            // 
            this.mantenimientoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnFecha,
            this.gridColumnEquipo,
            this.gridColumnEmpleado,
            this.gridColumnImporte});
            this.mantenimientoGridView.GridControl = this.gridControl1;
            this.mantenimientoGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe total:", this.gridColumnImporte, "")});
            this.mantenimientoGridView.Name = "mantenimientoGridView";
            this.mantenimientoGridView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.mantenimientoGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.mantenimientoGridView.OptionsPrint.PrintFilterInfo = true;
            this.mantenimientoGridView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.mantenimientoGridView.OptionsView.ShowAutoFilterRow = true;
            this.mantenimientoGridView.OptionsView.ShowFooter = true;
            this.mantenimientoGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnFecha
            // 
            this.gridColumnFecha.Caption = "Fecha";
            this.gridColumnFecha.Name = "gridColumnFecha";
            this.gridColumnFecha.Visible = true;
            this.gridColumnFecha.VisibleIndex = 0;
            // 
            // gridColumnEquipo
            // 
            this.gridColumnEquipo.Caption = "Equipo";
            this.gridColumnEquipo.ColumnEdit = this.repositoryItemLookUpEditEquipo;
            this.gridColumnEquipo.Name = "gridColumnEquipo";
            this.gridColumnEquipo.Visible = true;
            this.gridColumnEquipo.VisibleIndex = 1;
            // 
            // gridColumnEmpleado
            // 
            this.gridColumnEmpleado.Caption = "Empleado";
            this.gridColumnEmpleado.ColumnEdit = this.repositoryItemLookUpEditEmpleado;
            this.gridColumnEmpleado.Name = "gridColumnEmpleado";
            this.gridColumnEmpleado.Visible = true;
            this.gridColumnEmpleado.VisibleIndex = 2;
            // 
            // gridColumnImporte
            // 
            this.gridColumnImporte.Caption = "Importe";
            this.gridColumnImporte.Name = "gridColumnImporte";
            this.gridColumnImporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "importeTotal", "SUMA={0:#.##}")});
            this.gridColumnImporte.Visible = true;
            this.gridColumnImporte.VisibleIndex = 3;
            // 
            // numeroLabelControl
            // 
            this.numeroLabelControl.Location = new System.Drawing.Point(12, 14);
            this.numeroLabelControl.Name = "numeroLabelControl";
            this.numeroLabelControl.Size = new System.Drawing.Size(41, 13);
            this.numeroLabelControl.TabIndex = 37;
            this.numeroLabelControl.Text = "Número:";
            // 
            // numeroTextEdit
            // 
            this.numeroTextEdit.Location = new System.Drawing.Point(68, 11);
            this.numeroTextEdit.Name = "numeroTextEdit";
            this.numeroTextEdit.Size = new System.Drawing.Size(140, 20);
            this.numeroTextEdit.TabIndex = 38;
            // 
            // addSimpleButton
            // 
            this.addSimpleButton.ImageOptions.ImageIndex = 2;
            this.addSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.addSimpleButton.Location = new System.Drawing.Point(92, 160);
            this.addSimpleButton.Name = "addSimpleButton";
            this.addSimpleButton.Size = new System.Drawing.Size(97, 23);
            this.addSimpleButton.TabIndex = 13;
            this.addSimpleButton.Text = "&Agregar";
            // 
            // deleteSimpleButton
            // 
            this.deleteSimpleButton.ImageOptions.ImageIndex = 3;
            this.deleteSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.deleteSimpleButton.Location = new System.Drawing.Point(195, 160);
            this.deleteSimpleButton.Name = "deleteSimpleButton";
            this.deleteSimpleButton.Size = new System.Drawing.Size(97, 23);
            this.deleteSimpleButton.TabIndex = 39;
            this.deleteSimpleButton.Text = "&Borrar";
            // 
            // mantLabelControl
            // 
            this.mantLabelControl.Location = new System.Drawing.Point(12, 165);
            this.mantLabelControl.Name = "mantLabelControl";
            this.mantLabelControl.Size = new System.Drawing.Size(74, 13);
            this.mantLabelControl.TabIndex = 40;
            this.mantLabelControl.Text = "Mantenimiento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(214, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Proveedor:";
            // 
            // proveedorLookUpEdit
            // 
            this.proveedorLookUpEdit.Location = new System.Drawing.Point(274, 11);
            this.proveedorLookUpEdit.Name = "proveedorLookUpEdit";
            this.proveedorLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.proveedorLookUpEdit.Size = new System.Drawing.Size(140, 20);
            this.proveedorLookUpEdit.TabIndex = 42;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(473, 11);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.NullText = "DD/MM/AAAA";
            this.dateEdit1.Size = new System.Drawing.Size(140, 20);
            this.dateEdit1.TabIndex = 43;
            // 
            // fechaLabelControl
            // 
            this.fechaLabelControl.Location = new System.Drawing.Point(416, 14);
            this.fechaLabelControl.Name = "fechaLabelControl";
            this.fechaLabelControl.Size = new System.Drawing.Size(33, 13);
            this.fechaLabelControl.TabIndex = 44;
            this.fechaLabelControl.Text = "Fecha:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Empleado:";
            // 
            // empleadoLookUpEdit
            // 
            this.empleadoLookUpEdit.Location = new System.Drawing.Point(68, 40);
            this.empleadoLookUpEdit.Name = "empleadoLookUpEdit";
            this.empleadoLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.empleadoLookUpEdit.Size = new System.Drawing.Size(140, 20);
            this.empleadoLookUpEdit.TabIndex = 46;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(12, 88);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(601, 66);
            this.memoEdit1.TabIndex = 50;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Observaciones:";
            // 
            // PedidoInsumoMantenimientoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 363);
            this.Controls.Add(this.verInsumosSimpleButton);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.empleadoLookUpEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fechaLabelControl);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.proveedorLookUpEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.mantLabelControl);
            this.Controls.Add(this.deleteSimpleButton);
            this.Controls.Add(this.addSimpleButton);
            this.Controls.Add(this.numeroTextEdit);
            this.Controls.Add(this.numeroLabelControl);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PedidoInsumoMantenimientoEditorForm";
            this.Text = "Pedido de insumos por mantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView mantenimientoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImporte;
        private DevExpress.XtraEditors.SimpleButton verInsumosSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.LabelControl numeroLabelControl;
        private DevExpress.XtraEditors.TextEdit numeroTextEdit;
        private DevExpress.XtraEditors.SimpleButton addSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
        private DevExpress.XtraEditors.LabelControl mantLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit proveedorLookUpEdit;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl fechaLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit empleadoLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditEquipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditEmpleado;
    }
}