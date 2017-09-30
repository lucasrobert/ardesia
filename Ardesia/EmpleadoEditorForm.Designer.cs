namespace Ardesia
{
    partial class EmpleadoEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.ciudadComboBox = new System.Windows.Forms.ComboBox();
            this.ciudadLabel = new System.Windows.Forms.Label();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaLlabel = new System.Windows.Forms.Label();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.paisLabel = new System.Windows.Forms.Label();
            this.calleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(51, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(130, 21);
            this.idTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(187, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(48, 13);
            this.nombreLabel.TabIndex = 3;
            this.nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(240, 6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 21);
            this.nombreTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(436, 6);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(127, 21);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(568, 9);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(31, 13);
            this.tipoLabel.TabIndex = 3;
            this.tipoLabel.Text = "Tipo:";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(605, 6);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(127, 21);
            this.tipoComboBox.TabIndex = 5;
            // 
            // ciudadComboBox
            // 
            this.ciudadComboBox.FormattingEnabled = true;
            this.ciudadComboBox.Location = new System.Drawing.Point(240, 32);
            this.ciudadComboBox.Name = "ciudadComboBox";
            this.ciudadComboBox.Size = new System.Drawing.Size(130, 21);
            this.ciudadComboBox.TabIndex = 7;
            // 
            // ciudadLabel
            // 
            this.ciudadLabel.AutoSize = true;
            this.ciudadLabel.Location = new System.Drawing.Point(187, 36);
            this.ciudadLabel.Name = "ciudadLabel";
            this.ciudadLabel.Size = new System.Drawing.Size(44, 13);
            this.ciudadLabel.TabIndex = 6;
            this.ciudadLabel.Text = "Ciudad:";
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Location = new System.Drawing.Point(436, 32);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(127, 21);
            this.provinciaComboBox.TabIndex = 9;
            // 
            // provinciaLlabel
            // 
            this.provinciaLlabel.AutoSize = true;
            this.provinciaLlabel.Location = new System.Drawing.Point(376, 36);
            this.provinciaLlabel.Name = "provinciaLlabel";
            this.provinciaLlabel.Size = new System.Drawing.Size(54, 13);
            this.provinciaLlabel.TabIndex = 8;
            this.provinciaLlabel.Text = "Provincia:";
            // 
            // paisComboBox
            // 
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(605, 32);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(127, 21);
            this.paisComboBox.TabIndex = 11;
            // 
            // paisLabel
            // 
            this.paisLabel.AutoSize = true;
            this.paisLabel.Location = new System.Drawing.Point(569, 35);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(30, 13);
            this.paisLabel.TabIndex = 10;
            this.paisLabel.Text = "Pais:";
            // 
            // calleComboBox
            // 
            this.calleComboBox.FormattingEnabled = true;
            this.calleComboBox.Location = new System.Drawing.Point(51, 60);
            this.calleComboBox.Name = "calleComboBox";
            this.calleComboBox.Size = new System.Drawing.Size(319, 21);
            this.calleComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calle:";
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Location = new System.Drawing.Point(12, 36);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(24, 13);
            this.cpLabel.TabIndex = 14;
            this.cpLabel.Text = "CP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 15;
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(634, 102);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.exitSimpleButton.TabIndex = 17;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(527, 102);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(101, 22);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // EmpleadoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 136);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cpLabel);
            this.Controls.Add(this.calleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.paisLabel);
            this.Controls.Add(this.provinciaComboBox);
            this.Controls.Add(this.provinciaLlabel);
            this.Controls.Add(this.ciudadComboBox);
            this.Controls.Add(this.ciudadLabel);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "EmpleadoEditorForm";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.EmpleadoEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.Label ciudadLabel;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.Label provinciaLlabel;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.ComboBox calleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cpLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    }
}