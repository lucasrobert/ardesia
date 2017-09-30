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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiudadEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.paisLabel = new System.Windows.Forms.Label();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaLlabel = new System.Windows.Forms.Label();
            this.ciudadComboBox = new System.Windows.Forms.ComboBox();
            this.cpLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
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
            // paisComboBox
            // 
            this.paisComboBox.Enabled = false;
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(258, 32);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(130, 21);
            this.paisComboBox.TabIndex = 29;
            // 
            // paisLabel
            // 
            this.paisLabel.AutoSize = true;
            this.paisLabel.Location = new System.Drawing.Point(205, 35);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(30, 13);
            this.paisLabel.TabIndex = 28;
            this.paisLabel.Text = "Pais:";
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Location = new System.Drawing.Point(72, 32);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(127, 21);
            this.provinciaComboBox.TabIndex = 27;
            // 
            // provinciaLlabel
            // 
            this.provinciaLlabel.AutoSize = true;
            this.provinciaLlabel.Location = new System.Drawing.Point(12, 35);
            this.provinciaLlabel.Name = "provinciaLlabel";
            this.provinciaLlabel.Size = new System.Drawing.Size(54, 13);
            this.provinciaLlabel.TabIndex = 26;
            this.provinciaLlabel.Text = "Provincia:";
            // 
            // ciudadComboBox
            // 
            this.ciudadComboBox.FormattingEnabled = true;
            this.ciudadComboBox.Location = new System.Drawing.Point(424, 6);
            this.ciudadComboBox.Name = "ciudadComboBox";
            this.ciudadComboBox.Size = new System.Drawing.Size(130, 21);
            this.ciudadComboBox.TabIndex = 25;
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Location = new System.Drawing.Point(394, 9);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(24, 13);
            this.cpLabel.TabIndex = 24;
            this.cpLabel.Text = "CP:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(258, 6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 21);
            this.nombreTextBox.TabIndex = 20;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(205, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(48, 13);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(72, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(127, 21);
            this.idTextBox.TabIndex = 22;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(456, 63);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.exitSimpleButton.TabIndex = 31;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(349, 63);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(101, 22);
            this.saveSimpleButton.TabIndex = 30;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // CiudadEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 97);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.paisLabel);
            this.Controls.Add(this.provinciaComboBox);
            this.Controls.Add(this.provinciaLlabel);
            this.Controls.Add(this.ciudadComboBox);
            this.Controls.Add(this.cpLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "CiudadEditorForm";
            this.Text = "Ciudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.Label provinciaLlabel;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.Label cpLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    }
}