namespace Ardesia
{
    partial class ControlDiarioEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDiarioEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.insumoLabel = new System.Windows.Forms.Label();
            this.empleadoLlabel = new System.Windows.Forms.Label();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditFecha = new DevExpress.XtraEditors.DateEdit();
            this.lookUpEditSector = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditInsumo = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditCantidad = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditInsumo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCantidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "disk.png");
            this.imageList1.Images.SetKeyName(1, "door--arrow.png");
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 16);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(233, 46);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(67, 17);
            this.cantidadLabel.TabIndex = 3;
            this.cantidadLabel.Text = "Cantidad:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(466, 16);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(49, 17);
            this.fechaLabel.TabIndex = 3;
            this.fechaLabel.Text = "Fecha:";
            // 
            // insumoLabel
            // 
            this.insumoLabel.AutoSize = true;
            this.insumoLabel.Location = new System.Drawing.Point(14, 46);
            this.insumoLabel.Name = "insumoLabel";
            this.insumoLabel.Size = new System.Drawing.Size(59, 17);
            this.insumoLabel.TabIndex = 6;
            this.insumoLabel.Text = "Insumo:";
            // 
            // empleadoLlabel
            // 
            this.empleadoLlabel.AutoSize = true;
            this.empleadoLlabel.Location = new System.Drawing.Point(233, 16);
            this.empleadoLlabel.Name = "empleadoLlabel";
            this.empleadoLlabel.Size = new System.Drawing.Size(73, 17);
            this.empleadoLlabel.TabIndex = 8;
            this.empleadoLlabel.Text = "Empleado:";
            // 
            // sectorLabel
            // 
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(466, 46);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(53, 17);
            this.sectorLabel.TabIndex = 10;
            this.sectorLabel.Text = "Sector:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(556, 84);
            this.exitSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(114, 27);
            this.exitSimpleButton.TabIndex = 17;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(431, 84);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // dateEditFecha
            // 
            this.dateEditFecha.EditValue = null;
            this.dateEditFecha.Location = new System.Drawing.Point(521, 13);
            this.dateEditFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEditFecha.Name = "dateEditFecha";
            this.dateEditFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFecha.Properties.NullText = "DD/MM/AAAA";
            this.dateEditFecha.Size = new System.Drawing.Size(150, 22);
            this.dateEditFecha.TabIndex = 38;
            // 
            // lookUpEditSector
            // 
            this.lookUpEditSector.Location = new System.Drawing.Point(521, 43);
            this.lookUpEditSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditSector.Name = "lookUpEditSector";
            this.lookUpEditSector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSector.Size = new System.Drawing.Size(150, 22);
            this.lookUpEditSector.TabIndex = 39;
            // 
            // lookUpEditEmpleado
            // 
            this.lookUpEditEmpleado.Location = new System.Drawing.Point(312, 13);
            this.lookUpEditEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditEmpleado.Name = "lookUpEditEmpleado";
            this.lookUpEditEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEmpleado.Size = new System.Drawing.Size(148, 22);
            this.lookUpEditEmpleado.TabIndex = 41;
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(79, 13);
            this.textEditId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(148, 22);
            this.textEditId.TabIndex = 42;
            // 
            // lookUpEditInsumo
            // 
            this.lookUpEditInsumo.Location = new System.Drawing.Point(79, 43);
            this.lookUpEditInsumo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditInsumo.Name = "lookUpEditInsumo";
            this.lookUpEditInsumo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditInsumo.Size = new System.Drawing.Size(148, 22);
            this.lookUpEditInsumo.TabIndex = 43;
            // 
            // textEditCantidad
            // 
            this.textEditCantidad.Enabled = false;
            this.textEditCantidad.Location = new System.Drawing.Point(312, 43);
            this.textEditCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditCantidad.Name = "textEditCantidad";
            this.textEditCantidad.Size = new System.Drawing.Size(148, 22);
            this.textEditCantidad.TabIndex = 44;
            // 
            // ControlDiarioEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 125);
            this.Controls.Add(this.textEditCantidad);
            this.Controls.Add(this.lookUpEditInsumo);
            this.Controls.Add(this.textEditId);
            this.Controls.Add(this.lookUpEditEmpleado);
            this.Controls.Add(this.lookUpEditSector);
            this.Controls.Add(this.dateEditFecha);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.empleadoLlabel);
            this.Controls.Add(this.insumoLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlDiarioEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control diario";
            this.Load += new System.EventHandler(this.ControlDiarioEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditInsumo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCantidad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label insumoLabel;
        private System.Windows.Forms.Label empleadoLlabel;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.DateEdit dateEditFecha;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSector;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEmpleado;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditInsumo;
        private DevExpress.XtraEditors.TextEdit textEditCantidad;
    }
}