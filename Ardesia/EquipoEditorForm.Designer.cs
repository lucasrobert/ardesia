namespace Ardesia
{
    partial class EquipoEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipoEditorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.sectorLlabel = new System.Windows.Forms.Label();
            this.ciudadComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorLabel = new System.Windows.Forms.Label();
            this.fechaInicioTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ultimoMantenimientoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 30);
            this.panel1.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.ImageKey = "door--arrow.png";
            this.editButton.ImageList = this.imageList1;
            this.editButton.Location = new System.Drawing.Point(312, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "&Salir";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "disk.png");
            this.imageList1.Images.SetKeyName(1, "door--arrow.png");
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.ImageIndex = 0;
            this.saveButton.ImageList = this.imageList1;
            this.saveButton.Location = new System.Drawing.Point(231, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "&Guardar";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(268, 6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 20);
            this.nombreTextBox.TabIndex = 20;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(215, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(79, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(130, 20);
            this.idTextBox.TabIndex = 22;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID:";
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Location = new System.Drawing.Point(268, 32);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(130, 21);
            this.provinciaComboBox.TabIndex = 28;
            // 
            // sectorLlabel
            // 
            this.sectorLlabel.AutoSize = true;
            this.sectorLlabel.Location = new System.Drawing.Point(215, 36);
            this.sectorLlabel.Name = "sectorLlabel";
            this.sectorLlabel.Size = new System.Drawing.Size(41, 13);
            this.sectorLlabel.TabIndex = 27;
            this.sectorLlabel.Text = "Sector:";
            // 
            // ciudadComboBox
            // 
            this.ciudadComboBox.FormattingEnabled = true;
            this.ciudadComboBox.Location = new System.Drawing.Point(79, 32);
            this.ciudadComboBox.Name = "ciudadComboBox";
            this.ciudadComboBox.Size = new System.Drawing.Size(130, 21);
            this.ciudadComboBox.TabIndex = 26;
            // 
            // proveedorLabel
            // 
            this.proveedorLabel.AutoSize = true;
            this.proveedorLabel.Location = new System.Drawing.Point(12, 36);
            this.proveedorLabel.Name = "proveedorLabel";
            this.proveedorLabel.Size = new System.Drawing.Size(59, 13);
            this.proveedorLabel.TabIndex = 25;
            this.proveedorLabel.Text = "Proveedor:";
            // 
            // fechaInicioTimePicker
            // 
            this.fechaInicioTimePicker.Location = new System.Drawing.Point(128, 68);
            this.fechaInicioTimePicker.Name = "fechaInicioTimePicker";
            this.fechaInicioTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioTimePicker.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // ultimoMantenimientoLabel
            // 
            this.ultimoMantenimientoLabel.AutoSize = true;
            this.ultimoMantenimientoLabel.Location = new System.Drawing.Point(12, 101);
            this.ultimoMantenimientoLabel.Name = "ultimoMantenimientoLabel";
            this.ultimoMantenimientoLabel.Size = new System.Drawing.Size(110, 13);
            this.ultimoMantenimientoLabel.TabIndex = 31;
            this.ultimoMantenimientoLabel.Text = "Último mantenimiento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 32;
            // 
            // EquipoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 172);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ultimoMantenimientoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaInicioTimePicker);
            this.Controls.Add(this.provinciaComboBox);
            this.Controls.Add(this.sectorLlabel);
            this.Controls.Add(this.ciudadComboBox);
            this.Controls.Add(this.proveedorLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.panel1);
            this.Name = "EquipoEditorForm";
            this.Text = "Equipo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.Label sectorLlabel;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.Label proveedorLabel;
        private System.Windows.Forms.DateTimePicker fechaInicioTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ultimoMantenimientoLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}