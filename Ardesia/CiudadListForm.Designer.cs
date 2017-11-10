namespace Ardesia
{
    partial class CiudadListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiudadListForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFiltro = new DevExpress.XtraEditors.TextEdit();
            this.gridControlCiudad = new DevExpress.XtraGrid.GridControl();
            this.gridViewCiudad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombreCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPais = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCiudad)).BeginInit();
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
            this.deleteSimpleButton.Location = new System.Drawing.Point(772, 341);
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
            this.editSimpleButton.Location = new System.Drawing.Point(651, 341);
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
            this.addSimpleButton.Location = new System.Drawing.Point(526, 341);
            this.addSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSimpleButton.Name = "addSimpleButton";
            this.addSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.addSimpleButton.TabIndex = 56;
            this.addSimpleButton.Text = "&Agregar";
            // 
            // textEditFiltro
            // 
            this.textEditFiltro.Location = new System.Drawing.Point(62, 12);
            this.textEditFiltro.Name = "textEditFiltro";
            this.textEditFiltro.Size = new System.Drawing.Size(237, 22);
            this.textEditFiltro.TabIndex = 59;
            // 
            // gridControlCiudad
            // 
            this.gridControlCiudad.Location = new System.Drawing.Point(17, 40);
            this.gridControlCiudad.MainView = this.gridViewCiudad;
            this.gridControlCiudad.Name = "gridControlCiudad";
            this.gridControlCiudad.Size = new System.Drawing.Size(875, 286);
            this.gridControlCiudad.TabIndex = 60;
            this.gridControlCiudad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCiudad});
            // 
            // gridViewCiudad
            // 
            this.gridViewCiudad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdCiudad,
            this.gridColumnNombreCiudad,
            this.gridColumnCodigoPostal,
            this.gridColumnProvincia,
            this.gridColumnPais});
            this.gridViewCiudad.GridControl = this.gridControlCiudad;
            this.gridViewCiudad.Name = "gridViewCiudad";
            // 
            // gridColumnIdCiudad
            // 
            this.gridColumnIdCiudad.Caption = "ID";
            this.gridColumnIdCiudad.Name = "gridColumnIdCiudad";
            this.gridColumnIdCiudad.Visible = true;
            this.gridColumnIdCiudad.VisibleIndex = 0;
            // 
            // gridColumnNombreCiudad
            // 
            this.gridColumnNombreCiudad.Caption = "Nombre";
            this.gridColumnNombreCiudad.Name = "gridColumnNombreCiudad";
            this.gridColumnNombreCiudad.Visible = true;
            this.gridColumnNombreCiudad.VisibleIndex = 1;
            // 
            // gridColumnCodigoPostal
            // 
            this.gridColumnCodigoPostal.Caption = "CP";
            this.gridColumnCodigoPostal.Name = "gridColumnCodigoPostal";
            this.gridColumnCodigoPostal.Visible = true;
            this.gridColumnCodigoPostal.VisibleIndex = 2;
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
            this.gridColumnPais.Caption = "Pais";
            this.gridColumnPais.Name = "gridColumnPais";
            this.gridColumnPais.Visible = true;
            this.gridColumnPais.VisibleIndex = 4;
            // 
            // CiudadListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 383);
            this.Controls.Add(this.gridControlCiudad);
            this.Controls.Add(this.textEditFiltro);
            this.Controls.Add(this.deleteSimpleButton);
            this.Controls.Add(this.editSimpleButton);
            this.Controls.Add(this.addSimpleButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CiudadListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCiudad)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlCiudad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNombreCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPais;
    }
}