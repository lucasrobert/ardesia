namespace Ardesia
{
    partial class CalleListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalleListForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFiltro = new DevExpress.XtraEditors.TextEdit();
            this.gridControlCalle = new DevExpress.XtraGrid.GridControl();
            this.gridViewCalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombreCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPais = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalle)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus-circle.png");
            this.imageList1.Images.SetKeyName(1, "cross-circle.png");
            this.imageList1.Images.SetKeyName(2, "pencil.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro:";
            // 
            // deleteSimpleButton
            // 
            this.deleteSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSimpleButton.ImageOptions.ImageIndex = 1;
            this.deleteSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.deleteSimpleButton.Location = new System.Drawing.Point(772, 332);
            this.deleteSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteSimpleButton.Name = "deleteSimpleButton";
            this.deleteSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.deleteSimpleButton.TabIndex = 58;
            this.deleteSimpleButton.Text = "&Borrar";
            // 
            // editSimpleButton
            // 
            this.editSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editSimpleButton.ImageOptions.ImageIndex = 2;
            this.editSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.editSimpleButton.Location = new System.Drawing.Point(651, 332);
            this.editSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editSimpleButton.Name = "editSimpleButton";
            this.editSimpleButton.Size = new System.Drawing.Size(114, 27);
            this.editSimpleButton.TabIndex = 57;
            this.editSimpleButton.Text = "&Editar";
            // 
            // addSimpleButton
            // 
            this.addSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSimpleButton.ImageOptions.ImageIndex = 0;
            this.addSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.addSimpleButton.Location = new System.Drawing.Point(526, 332);
            this.addSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSimpleButton.Name = "addSimpleButton";
            this.addSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.addSimpleButton.TabIndex = 56;
            this.addSimpleButton.Text = "&Agregar";
            // 
            // textEditFiltro
            // 
            this.textEditFiltro.Location = new System.Drawing.Point(62, 10);
            this.textEditFiltro.Name = "textEditFiltro";
            this.textEditFiltro.Size = new System.Drawing.Size(237, 22);
            this.textEditFiltro.TabIndex = 59;
            // 
            // gridControlCalle
            // 
            this.gridControlCalle.Location = new System.Drawing.Point(17, 38);
            this.gridControlCalle.MainView = this.gridViewCalle;
            this.gridControlCalle.Name = "gridControlCalle";
            this.gridControlCalle.Size = new System.Drawing.Size(873, 282);
            this.gridControlCalle.TabIndex = 60;
            this.gridControlCalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCalle});
            // 
            // gridViewCalle
            // 
            this.gridViewCalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdCalle,
            this.gridColumnNombreCalle,
            this.gridColumnCiudad,
            this.gridColumnProvincia,
            this.gridColumnPais});
            this.gridViewCalle.GridControl = this.gridControlCalle;
            this.gridViewCalle.Name = "gridViewCalle";
            // 
            // gridColumnIdCalle
            // 
            this.gridColumnIdCalle.Caption = "ID";
            this.gridColumnIdCalle.Name = "gridColumnIdCalle";
            this.gridColumnIdCalle.Visible = true;
            this.gridColumnIdCalle.VisibleIndex = 0;
            // 
            // gridColumnNombreCalle
            // 
            this.gridColumnNombreCalle.Caption = "Nombre";
            this.gridColumnNombreCalle.Name = "gridColumnNombreCalle";
            this.gridColumnNombreCalle.Visible = true;
            this.gridColumnNombreCalle.VisibleIndex = 1;
            // 
            // gridColumnCiudad
            // 
            this.gridColumnCiudad.Caption = "Ciudad";
            this.gridColumnCiudad.Name = "gridColumnCiudad";
            this.gridColumnCiudad.Visible = true;
            this.gridColumnCiudad.VisibleIndex = 2;
            // 
            // gridColumnProvincia
            // 
            this.gridColumnProvincia.Caption = "Provincia";
            this.gridColumnProvincia.Name = "gridColumnProvincia";
            this.gridColumnProvincia.Visible = true;
            this.gridColumnProvincia.VisibleIndex = 3;
            // 
            // gridColumnPais
            // 
            this.gridColumnPais.Caption = "País";
            this.gridColumnPais.Name = "gridColumnPais";
            this.gridColumnPais.Visible = true;
            this.gridColumnPais.VisibleIndex = 4;
            // 
            // CalleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 374);
            this.Controls.Add(this.gridControlCalle);
            this.Controls.Add(this.textEditFiltro);
            this.Controls.Add(this.deleteSimpleButton);
            this.Controls.Add(this.editSimpleButton);
            this.Controls.Add(this.addSimpleButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CalleListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calles";
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addSimpleButton;
        private DevExpress.XtraEditors.TextEdit textEditFiltro;
        private DevExpress.XtraGrid.GridControl gridControlCalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdCalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNombreCalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPais;
    }
}