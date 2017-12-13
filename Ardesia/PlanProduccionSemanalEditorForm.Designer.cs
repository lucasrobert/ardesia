namespace Ardesia
{
    partial class PlanProduccionSemanalEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanProduccionSemanalEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditFecha = new DevExpress.XtraEditors.DateEdit();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
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
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(238, 16);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(49, 17);
            this.fechaLabel.TabIndex = 3;
            this.fechaLabel.Text = "Fecha:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(320, 64);
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
            this.saveSimpleButton.Location = new System.Drawing.Point(195, 64);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // dateEditFecha
            // 
            this.dateEditFecha.EditValue = null;
            this.dateEditFecha.Location = new System.Drawing.Point(293, 13);
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
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(79, 13);
            this.textEditId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(148, 22);
            this.textEditId.TabIndex = 42;
            // 
            // PlanProduccionSemanalEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 105);
            this.Controls.Add(this.textEditId);
            this.Controls.Add(this.dateEditFecha);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlanProduccionSemanalEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plan producción semanal";
            this.Load += new System.EventHandler(this.PlanProduccionSemanalEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.DateEdit dateEditFecha;
        private DevExpress.XtraEditors.TextEdit textEditId;
    }
}