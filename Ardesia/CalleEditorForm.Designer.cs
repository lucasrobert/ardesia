namespace Ardesia
{
    partial class CalleEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalleEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.paisLabel = new System.Windows.Forms.Label();
            this.provinciaLlabel = new System.Windows.Forms.Label();
            this.ciudadLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.textEditNombre = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditCiudad = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditProvincia = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditPais = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProvincia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPais.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "disk.png");
            this.imageList1.Images.SetKeyName(1, "door--arrow.png");
            // 
            // paisLabel
            // 
            this.paisLabel.AutoSize = true;
            this.paisLabel.Location = new System.Drawing.Point(239, 40);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(36, 17);
            this.paisLabel.TabIndex = 28;
            this.paisLabel.Text = "Pais:";
            // 
            // provinciaLlabel
            // 
            this.provinciaLlabel.AutoSize = true;
            this.provinciaLlabel.Location = new System.Drawing.Point(14, 40);
            this.provinciaLlabel.Name = "provinciaLlabel";
            this.provinciaLlabel.Size = new System.Drawing.Size(68, 17);
            this.provinciaLlabel.TabIndex = 26;
            this.provinciaLlabel.Text = "Provincia:";
            // 
            // ciudadLabel
            // 
            this.ciudadLabel.AutoSize = true;
            this.ciudadLabel.Location = new System.Drawing.Point(453, 11);
            this.ciudadLabel.Name = "ciudadLabel";
            this.ciudadLabel.Size = new System.Drawing.Size(55, 17);
            this.ciudadLabel.TabIndex = 24;
            this.ciudadLabel.Text = "Ciudad:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(239, 11);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 17);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 11);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 17);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(542, 72);
            this.exitSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(114, 27);
            this.exitSimpleButton.TabIndex = 31;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(417, 72);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 30;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(84, 9);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(147, 22);
            this.textEditId.TabIndex = 32;
            // 
            // textEditNombre
            // 
            this.textEditNombre.Enabled = false;
            this.textEditNombre.Location = new System.Drawing.Point(301, 9);
            this.textEditNombre.Name = "textEditNombre";
            this.textEditNombre.Size = new System.Drawing.Size(146, 22);
            this.textEditNombre.TabIndex = 33;
            // 
            // lookUpEditCiudad
            // 
            this.lookUpEditCiudad.Location = new System.Drawing.Point(514, 9);
            this.lookUpEditCiudad.Name = "lookUpEditCiudad";
            this.lookUpEditCiudad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCiudad.Properties.NullText = "";
            this.lookUpEditCiudad.Size = new System.Drawing.Size(146, 22);
            this.lookUpEditCiudad.TabIndex = 34;
            // 
            // lookUpEditProvincia
            // 
            this.lookUpEditProvincia.Location = new System.Drawing.Point(84, 37);
            this.lookUpEditProvincia.Name = "lookUpEditProvincia";
            this.lookUpEditProvincia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProvincia.Properties.NullText = "";
            this.lookUpEditProvincia.Size = new System.Drawing.Size(146, 22);
            this.lookUpEditProvincia.TabIndex = 35;
            // 
            // lookUpEditPais
            // 
            this.lookUpEditPais.Location = new System.Drawing.Point(301, 37);
            this.lookUpEditPais.Name = "lookUpEditPais";
            this.lookUpEditPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPais.Properties.NullText = "";
            this.lookUpEditPais.Size = new System.Drawing.Size(146, 22);
            this.lookUpEditPais.TabIndex = 36;
            // 
            // CalleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 113);
            this.Controls.Add(this.lookUpEditPais);
            this.Controls.Add(this.lookUpEditProvincia);
            this.Controls.Add(this.lookUpEditCiudad);
            this.Controls.Add(this.textEditNombre);
            this.Controls.Add(this.textEditId);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.paisLabel);
            this.Controls.Add(this.provinciaLlabel);
            this.Controls.Add(this.ciudadLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CalleEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calle";
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProvincia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPais.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.Label provinciaLlabel;
        private System.Windows.Forms.Label ciudadLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.TextEdit textEditNombre;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCiudad;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProvincia;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPais;
    }
}