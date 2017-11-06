namespace Ardesia
{
    partial class InsumoEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsumoEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorLabel = new System.Windows.Forms.Label();
            this.sectorComboBox = new System.Windows.Forms.ComboBox();
            this.sectorLlabel = new System.Windows.Forms.Label();
            this.unidadMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.unidadMedidaLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
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
            this.idLabel.Location = new System.Drawing.Point(14, 11);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(95, 8);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 23);
            this.idTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(252, 11);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(62, 17);
            this.nombreLabel.TabIndex = 3;
            this.nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(320, 8);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(151, 23);
            this.nombreTextBox.TabIndex = 4;
            // 
            // proveedorComboBox
            // 
            this.proveedorComboBox.FormattingEnabled = true;
            this.proveedorComboBox.Location = new System.Drawing.Point(95, 39);
            this.proveedorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proveedorComboBox.Name = "proveedorComboBox";
            this.proveedorComboBox.Size = new System.Drawing.Size(151, 24);
            this.proveedorComboBox.TabIndex = 7;
            // 
            // proveedorLabel
            // 
            this.proveedorLabel.AutoSize = true;
            this.proveedorLabel.Location = new System.Drawing.Point(14, 43);
            this.proveedorLabel.Name = "proveedorLabel";
            this.proveedorLabel.Size = new System.Drawing.Size(77, 17);
            this.proveedorLabel.TabIndex = 6;
            this.proveedorLabel.Text = "Proveedor:";
            // 
            // sectorComboBox
            // 
            this.sectorComboBox.FormattingEnabled = true;
            this.sectorComboBox.Location = new System.Drawing.Point(320, 39);
            this.sectorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sectorComboBox.Name = "sectorComboBox";
            this.sectorComboBox.Size = new System.Drawing.Size(151, 24);
            this.sectorComboBox.TabIndex = 9;
            // 
            // sectorLlabel
            // 
            this.sectorLlabel.AutoSize = true;
            this.sectorLlabel.Location = new System.Drawing.Point(252, 43);
            this.sectorLlabel.Name = "sectorLlabel";
            this.sectorLlabel.Size = new System.Drawing.Size(53, 17);
            this.sectorLlabel.TabIndex = 8;
            this.sectorLlabel.Text = "Sector:";
            // 
            // unidadMedidaComboBox
            // 
            this.unidadMedidaComboBox.FormattingEnabled = true;
            this.unidadMedidaComboBox.Location = new System.Drawing.Point(93, 71);
            this.unidadMedidaComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unidadMedidaComboBox.Name = "unidadMedidaComboBox";
            this.unidadMedidaComboBox.Size = new System.Drawing.Size(153, 24);
            this.unidadMedidaComboBox.TabIndex = 11;
            // 
            // unidadMedidaLabel
            // 
            this.unidadMedidaLabel.AutoSize = true;
            this.unidadMedidaLabel.Location = new System.Drawing.Point(14, 71);
            this.unidadMedidaLabel.Name = "unidadMedidaLabel";
            this.unidadMedidaLabel.Size = new System.Drawing.Size(73, 34);
            this.unidadMedidaLabel.TabIndex = 10;
            this.unidadMedidaLabel.Text = "Unidad de \r\nmedida:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(361, 110);
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
            this.saveSimpleButton.Location = new System.Drawing.Point(236, 110);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // InsumoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 151);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.unidadMedidaComboBox);
            this.Controls.Add(this.unidadMedidaLabel);
            this.Controls.Add(this.sectorComboBox);
            this.Controls.Add(this.sectorLlabel);
            this.Controls.Add(this.proveedorComboBox);
            this.Controls.Add(this.proveedorLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InsumoEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insumo";
            this.Load += new System.EventHandler(this.InsumoEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox proveedorComboBox;
        private System.Windows.Forms.Label proveedorLabel;
        private System.Windows.Forms.ComboBox sectorComboBox;
        private System.Windows.Forms.Label sectorLlabel;
        private System.Windows.Forms.ComboBox unidadMedidaComboBox;
        private System.Windows.Forms.Label unidadMedidaLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    }
}