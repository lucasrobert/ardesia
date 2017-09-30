﻿namespace Ardesia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipoEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList();
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
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(268, 6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 21);
            this.nombreTextBox.TabIndex = 20;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(215, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(48, 13);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(79, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(130, 21);
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
            this.sectorLlabel.Size = new System.Drawing.Size(42, 13);
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
            this.proveedorLabel.Size = new System.Drawing.Size(61, 13);
            this.proveedorLabel.TabIndex = 25;
            this.proveedorLabel.Text = "Proveedor:";
            // 
            // fechaInicioTimePicker
            // 
            this.fechaInicioTimePicker.Location = new System.Drawing.Point(128, 68);
            this.fechaInicioTimePicker.Name = "fechaInicioTimePicker";
            this.fechaInicioTimePicker.Size = new System.Drawing.Size(200, 21);
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
            this.ultimoMantenimientoLabel.Size = new System.Drawing.Size(113, 13);
            this.ultimoMantenimientoLabel.TabIndex = 31;
            this.ultimoMantenimientoLabel.Text = "Último mantenimiento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 32;
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(304, 138);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.exitSimpleButton.TabIndex = 34;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(197, 138);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(101, 22);
            this.saveSimpleButton.TabIndex = 33;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // EquipoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 172);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
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
            this.Name = "EquipoEditorForm";
            this.Text = "Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.Label sectorLlabel;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.Label proveedorLabel;
        private System.Windows.Forms.DateTimePicker fechaInicioTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ultimoMantenimientoLabel;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    }
}