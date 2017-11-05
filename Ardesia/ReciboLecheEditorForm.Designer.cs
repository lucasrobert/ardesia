namespace Ardesia
{
    partial class ReciboLecheEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboLecheEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ciudadComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.sectorComboBox = new System.Windows.Forms.ComboBox();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriaLecheTextBox = new System.Windows.Forms.TextBox();
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
            this.idTextBox.Location = new System.Drawing.Point(87, 7);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 23);
            this.idTextBox.TabIndex = 4;
            // 
            // ciudadComboBox
            // 
            this.ciudadComboBox.FormattingEnabled = true;
            this.ciudadComboBox.Location = new System.Drawing.Point(86, 38);
            this.ciudadComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ciudadComboBox.Name = "ciudadComboBox";
            this.ciudadComboBox.Size = new System.Drawing.Size(151, 24);
            this.ciudadComboBox.TabIndex = 7;
            // 
            // empleadoLabel
            // 
            this.empleadoLabel.AutoSize = true;
            this.empleadoLabel.Location = new System.Drawing.Point(7, 43);
            this.empleadoLabel.Name = "empleadoLabel";
            this.empleadoLabel.Size = new System.Drawing.Size(73, 17);
            this.empleadoLabel.TabIndex = 6;
            this.empleadoLabel.Text = "Empleado:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(355, 77);
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
            this.saveSimpleButton.Location = new System.Drawing.Point(230, 77);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // sectorComboBox
            // 
            this.sectorComboBox.FormattingEnabled = true;
            this.sectorComboBox.Location = new System.Drawing.Point(323, 38);
            this.sectorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sectorComboBox.Name = "sectorComboBox";
            this.sectorComboBox.Size = new System.Drawing.Size(151, 24);
            this.sectorComboBox.TabIndex = 19;
            // 
            // sectorLabel
            // 
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(243, 43);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sectorLabel.Size = new System.Drawing.Size(53, 17);
            this.sectorLabel.TabIndex = 18;
            this.sectorLabel.Text = "Sector:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cat. leche:";
            // 
            // categoriaLecheTextBox
            // 
            this.categoriaLecheTextBox.Location = new System.Drawing.Point(323, 7);
            this.categoriaLecheTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoriaLecheTextBox.Name = "categoriaLecheTextBox";
            this.categoriaLecheTextBox.Size = new System.Drawing.Size(151, 23);
            this.categoriaLecheTextBox.TabIndex = 21;
            // 
            // ReciboLecheEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 118);
            this.Controls.Add(this.categoriaLecheTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectorComboBox);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.ciudadComboBox);
            this.Controls.Add(this.empleadoLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReciboLecheEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recibo de leche";
            this.Load += new System.EventHandler(this.ReciboLecheEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.Label empleadoLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private System.Windows.Forms.ComboBox sectorComboBox;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoriaLecheTextBox;
    }
}