namespace Ardesia
{
    partial class PedidoInsumoInsumoEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoInsumoInsumoEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.insumoLabel = new System.Windows.Forms.Label();
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
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(226, 9);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(54, 13);
            this.cantidadLabel.TabIndex = 28;
            this.cantidadLabel.Text = "Cantidad:";
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Location = new System.Drawing.Point(62, 6);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(158, 21);
            this.provinciaComboBox.TabIndex = 27;
            // 
            // insumoLabel
            // 
            this.insumoLabel.AutoSize = true;
            this.insumoLabel.Location = new System.Drawing.Point(12, 9);
            this.insumoLabel.Name = "insumoLabel";
            this.insumoLabel.Size = new System.Drawing.Size(46, 13);
            this.insumoLabel.TabIndex = 16;
            this.insumoLabel.Text = "Insumo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 30;
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(316, 45);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(98, 22);
            this.exitSimpleButton.TabIndex = 57;
            this.exitSimpleButton.Text = "&Salir";
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.ImageOptions.ImageIndex = 0;
            this.saveSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.saveSimpleButton.Location = new System.Drawing.Point(209, 45);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(101, 22);
            this.saveSimpleButton.TabIndex = 56;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // PedidoInsumoInsumoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 79);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.provinciaComboBox);
            this.Controls.Add(this.insumoLabel);
            this.Name = "PedidoInsumoInsumoEditorForm";
            this.Text = "Insumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.Label insumoLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
    }
}