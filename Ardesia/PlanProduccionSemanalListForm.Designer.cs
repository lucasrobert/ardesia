namespace Ardesia
{
    partial class PlanProduccionSemanalListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanProduccionSemanalListForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlPlanProduccionSemanal = new DevExpress.XtraGrid.GridControl();
            this.gridViewPlanProduccionSemanal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdPlanProduccionSemanal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditFiltro = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPlanProduccionSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlanProduccionSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro:";
            // 
            // deleteSimpleButton
            // 
            this.deleteSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteSimpleButton.ImageOptions.ImageIndex = 1;
            this.deleteSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.deleteSimpleButton.Location = new System.Drawing.Point(772, 363);
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
            this.editSimpleButton.Location = new System.Drawing.Point(651, 363);
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
            this.addSimpleButton.Location = new System.Drawing.Point(526, 363);
            this.addSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSimpleButton.Name = "addSimpleButton";
            this.addSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.addSimpleButton.TabIndex = 56;
            this.addSimpleButton.Text = "&Agregar";
            // 
            // gridControlPlanProduccionSemanal
            // 
            this.gridControlPlanProduccionSemanal.Location = new System.Drawing.Point(15, 41);
            this.gridControlPlanProduccionSemanal.MainView = this.gridViewPlanProduccionSemanal;
            this.gridControlPlanProduccionSemanal.Name = "gridControlPlanProduccionSemanal";
            this.gridControlPlanProduccionSemanal.Size = new System.Drawing.Size(875, 306);
            this.gridControlPlanProduccionSemanal.TabIndex = 61;
            this.gridControlPlanProduccionSemanal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPlanProduccionSemanal});
            // 
            // gridViewPlanProduccionSemanal
            // 
            this.gridViewPlanProduccionSemanal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdPlanProduccionSemanal,
            this.gridColumnFechaHora});
            this.gridViewPlanProduccionSemanal.GridControl = this.gridControlPlanProduccionSemanal;
            this.gridViewPlanProduccionSemanal.Name = "gridViewPlanProduccionSemanal";
            // 
            // gridColumnIdPlanProduccionSemanal
            // 
            this.gridColumnIdPlanProduccionSemanal.Caption = "ID";
            this.gridColumnIdPlanProduccionSemanal.Name = "gridColumnIdPlanProduccionSemanal";
            this.gridColumnIdPlanProduccionSemanal.Visible = true;
            this.gridColumnIdPlanProduccionSemanal.VisibleIndex = 0;
            // 
            // gridColumnFechaHora
            // 
            this.gridColumnFechaHora.Caption = "Fecha";
            this.gridColumnFechaHora.Name = "gridColumnFechaHora";
            this.gridColumnFechaHora.Visible = true;
            this.gridColumnFechaHora.VisibleIndex = 1;
            // 
            // textEditFiltro
            // 
            this.textEditFiltro.Location = new System.Drawing.Point(63, 13);
            this.textEditFiltro.Name = "textEditFiltro";
            this.textEditFiltro.Size = new System.Drawing.Size(237, 22);
            this.textEditFiltro.TabIndex = 62;
            // 
            // PlanProduccionSemanalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 405);
            this.Controls.Add(this.textEditFiltro);
            this.Controls.Add(this.gridControlPlanProduccionSemanal);
            this.Controls.Add(this.deleteSimpleButton);
            this.Controls.Add(this.editSimpleButton);
            this.Controls.Add(this.addSimpleButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlanProduccionSemanalListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan producción semanal";
            this.Load += new System.EventHandler(this.PlanProduccionSemanalListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPlanProduccionSemanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPlanProduccionSemanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addSimpleButton;
        private DevExpress.XtraGrid.GridControl gridControlPlanProduccionSemanal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPlanProduccionSemanal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdPlanProduccionSemanal;
        private DevExpress.XtraEditors.TextEdit textEditFiltro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaHora;
    }
}