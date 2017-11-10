namespace Ardesia
{
    partial class CiudadEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiudadEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.paisLabel = new System.Windows.Forms.Label();
            this.provinciaLlabel = new System.Windows.Forms.Label();
            this.cpLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.textEditNombre = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditCodigoPostal = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditProvincia = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditPais = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoPostal.Properties)).BeginInit();
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
            this.paisLabel.Location = new System.Drawing.Point(239, 43);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(36, 17);
            this.paisLabel.TabIndex = 28;
            this.paisLabel.Text = "Pais:";
            // 
            // provinciaLlabel
            // 
            this.provinciaLlabel.AutoSize = true;
            this.provinciaLlabel.Location = new System.Drawing.Point(14, 43);
            this.provinciaLlabel.Name = "provinciaLlabel";
            this.provinciaLlabel.Size = new System.Drawing.Size(68, 17);
            this.provinciaLlabel.TabIndex = 26;
            this.provinciaLlabel.Text = "Provincia:";
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Location = new System.Drawing.Point(460, 11);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(30, 17);
            this.cpLabel.TabIndex = 24;
            this.cpLabel.Text = "CP:";
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
            this.exitSimpleButton.Location = new System.Drawing.Point(532, 78);
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
            this.saveSimpleButton.Location = new System.Drawing.Point(407, 78);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 30;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(84, 8);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(147, 22);
            this.textEditId.TabIndex = 32;
            // 
            // textEditNombre
            // 
            this.textEditNombre.Location = new System.Drawing.Point(301, 8);
            this.textEditNombre.Name = "textEditNombre";
            this.textEditNombre.Size = new System.Drawing.Size(147, 22);
            this.textEditNombre.TabIndex = 33;
            // 
            // lookUpEditCodigoPostal
            // 
            this.lookUpEditCodigoPostal.Location = new System.Drawing.Point(495, 8);
            this.lookUpEditCodigoPostal.Name = "lookUpEditCodigoPostal";
            this.lookUpEditCodigoPostal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCodigoPostal.Properties.NullText = "";
            this.lookUpEditCodigoPostal.Size = new System.Drawing.Size(151, 22);
            this.lookUpEditCodigoPostal.TabIndex = 34;
            // 
            // lookUpEditProvincia
            // 
            this.lookUpEditProvincia.Location = new System.Drawing.Point(82, 40);
            this.lookUpEditProvincia.Name = "lookUpEditProvincia";
            this.lookUpEditProvincia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProvincia.Properties.NullText = "";
            this.lookUpEditProvincia.Size = new System.Drawing.Size(149, 22);
            this.lookUpEditProvincia.TabIndex = 35;
            // 
            // lookUpEditPais
            // 
            this.lookUpEditPais.Location = new System.Drawing.Point(301, 40);
            this.lookUpEditPais.Name = "lookUpEditPais";
            this.lookUpEditPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPais.Properties.NullText = "";
            this.lookUpEditPais.Size = new System.Drawing.Size(147, 22);
            this.lookUpEditPais.TabIndex = 36;
            // 
            // CiudadEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 119);
            this.Controls.Add(this.lookUpEditPais);
            this.Controls.Add(this.lookUpEditProvincia);
            this.Controls.Add(this.lookUpEditCodigoPostal);
            this.Controls.Add(this.textEditNombre);
            this.Controls.Add(this.textEditId);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.paisLabel);
            this.Controls.Add(this.provinciaLlabel);
            this.Controls.Add(this.cpLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CiudadEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ciudad";
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoPostal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProvincia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPais.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.Label provinciaLlabel;
        private System.Windows.Forms.Label cpLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.TextEdit textEditNombre;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCodigoPostal;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProvincia;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPais;
    }
}