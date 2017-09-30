namespace Ardesia
{
    partial class PedidoInsumoProduccionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoInsumoProduccionEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.empleadoLabel = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.productoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.proveedorLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.limpiezaRadioButton = new System.Windows.Forms.RadioButton();
            this.mantenimientoRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.verInsumosSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "disk.png");
            this.imageList1.Images.SetKeyName(1, "door--arrow.png");
            this.imageList1.Images.SetKeyName(2, "plus-circle.png");
            this.imageList1.Images.SetKeyName(3, "cross-circle.png");
            this.imageList1.Images.SetKeyName(4, "magnifier-zoom.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plan de producción:";
            // 
            // deleteButton
            // 
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.ImageIndex = 3;
            this.deleteButton.ImageList = this.imageList1;
            this.deleteButton.Location = new System.Drawing.Point(202, 73);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "&Borrar";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.ImageIndex = 2;
            this.addButton.ImageList = this.imageList1;
            this.addButton.Location = new System.Drawing.Point(121, 73);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "&Agregar";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // empleadoLabel
            // 
            this.empleadoLabel.AutoSize = true;
            this.empleadoLabel.Location = new System.Drawing.Point(367, 46);
            this.empleadoLabel.Name = "empleadoLabel";
            this.empleadoLabel.Size = new System.Drawing.Size(57, 13);
            this.empleadoLabel.TabIndex = 28;
            this.empleadoLabel.Text = "Empleado:";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(231, 10);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(130, 21);
            this.clienteComboBox.TabIndex = 27;
            // 
            // productoComboBox
            // 
            this.productoComboBox.FormattingEnabled = true;
            this.productoComboBox.Location = new System.Drawing.Point(430, 41);
            this.productoComboBox.Name = "productoComboBox";
            this.productoComboBox.Size = new System.Drawing.Size(127, 21);
            this.productoComboBox.TabIndex = 25;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(367, 15);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(40, 13);
            this.fechaLabel.TabIndex = 21;
            this.fechaLabel.Text = "Fecha:";
            // 
            // proveedorLabel
            // 
            this.proveedorLabel.AutoSize = true;
            this.proveedorLabel.Location = new System.Drawing.Point(166, 15);
            this.proveedorLabel.Name = "proveedorLabel";
            this.proveedorLabel.Size = new System.Drawing.Size(61, 13);
            this.proveedorLabel.TabIndex = 22;
            this.proveedorLabel.Text = "Proveedor:";
            this.proveedorLabel.Click += new System.EventHandler(this.clienteLabel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(60, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 21);
            this.idTextBox.TabIndex = 24;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(13, 15);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(48, 13);
            this.numeroLabel.TabIndex = 23;
            this.numeroLabel.Text = "Número:";
            // 
            // limpiezaRadioButton
            // 
            this.limpiezaRadioButton.AutoSize = true;
            this.limpiezaRadioButton.Location = new System.Drawing.Point(83, 46);
            this.limpiezaRadioButton.Name = "limpiezaRadioButton";
            this.limpiezaRadioButton.Size = new System.Drawing.Size(65, 17);
            this.limpiezaRadioButton.TabIndex = 29;
            this.limpiezaRadioButton.Text = "Limpieza";
            this.limpiezaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mantenimientoRadioButton
            // 
            this.mantenimientoRadioButton.AutoSize = true;
            this.mantenimientoRadioButton.Location = new System.Drawing.Point(155, 46);
            this.mantenimientoRadioButton.Name = "mantenimientoRadioButton";
            this.mantenimientoRadioButton.Size = new System.Drawing.Size(95, 17);
            this.mantenimientoRadioButton.TabIndex = 30;
            this.mantenimientoRadioButton.Text = "Mantenimiento";
            this.mantenimientoRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(255, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Producción";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pedido por:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.ImporteColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 187);
            this.dataGridView1.TabIndex = 33;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // ImporteColumn
            // 
            this.ImporteColumn.HeaderText = "Importe";
            this.ImporteColumn.Name = "ImporteColumn";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(401, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 21);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Importe total:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2017, 9, 20, 11, 45, 0, 0);
            // 
            // verInsumosSimpleButton
            // 
            this.verInsumosSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.verInsumosSimpleButton.ImageOptions.ImageIndex = 4;
            this.verInsumosSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.verInsumosSimpleButton.Location = new System.Drawing.Point(12, 328);
            this.verInsumosSimpleButton.Name = "verInsumosSimpleButton";
            this.verInsumosSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.verInsumosSimpleButton.TabIndex = 34;
            this.verInsumosSimpleButton.Text = "&Ver insumos";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(459, 328);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.exitSimpleButton.TabIndex = 36;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(352, 328);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(101, 22);
            this.saveSimpleButton.TabIndex = 35;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // PedidoInsumoProduccionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 362);
            this.Controls.Add(this.verInsumosSimpleButton);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.mantenimientoRadioButton);
            this.Controls.Add(this.limpiezaRadioButton);
            this.Controls.Add(this.empleadoLabel);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.productoComboBox);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.proveedorLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "PedidoInsumoProduccionEditorForm";
            this.Text = "Pedido de insumos por producción";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label empleadoLabel;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox productoComboBox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label proveedorLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.RadioButton limpiezaRadioButton;
        private System.Windows.Forms.RadioButton mantenimientoRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteColumn;
        private DevExpress.XtraEditors.SimpleButton verInsumosSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    }
}