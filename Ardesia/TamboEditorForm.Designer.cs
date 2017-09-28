namespace Ardesia
{
    partial class TamboEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamboEditorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.calleComboBox = new System.Windows.Forms.ComboBox();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.paisLabel = new System.Windows.Forms.Label();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaLlabel = new System.Windows.Forms.Label();
            this.ciudadComboBox = new System.Windows.Forms.ComboBox();
            this.ciudadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 30);
            this.panel1.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.ImageKey = "door--arrow.png";
            this.editButton.ImageList = this.imageList1;
            this.editButton.Location = new System.Drawing.Point(488, 3);
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
            this.saveButton.Location = new System.Drawing.Point(407, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "&Guardar";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(259, 6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 20);
            this.nombreTextBox.TabIndex = 20;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(199, 9);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(63, 6);
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
            // capacidadTextBox
            // 
            this.capacidadTextBox.Location = new System.Drawing.Point(448, 6);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(130, 20);
            this.capacidadTextBox.TabIndex = 24;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(395, 9);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(47, 13);
            this.numeroLabel.TabIndex = 23;
            this.numeroLabel.Text = "Numero:";
            // 
            // calleComboBox
            // 
            this.calleComboBox.FormattingEnabled = true;
            this.calleComboBox.Location = new System.Drawing.Point(63, 59);
            this.calleComboBox.Name = "calleComboBox";
            this.calleComboBox.Size = new System.Drawing.Size(326, 21);
            this.calleComboBox.TabIndex = 31;
            // 
            // paisComboBox
            // 
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(448, 32);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(130, 21);
            this.paisComboBox.TabIndex = 30;
            // 
            // paisLabel
            // 
            this.paisLabel.AutoSize = true;
            this.paisLabel.Location = new System.Drawing.Point(392, 36);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(30, 13);
            this.paisLabel.TabIndex = 29;
            this.paisLabel.Text = "Pais:";
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Location = new System.Drawing.Point(259, 33);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(130, 21);
            this.provinciaComboBox.TabIndex = 28;
            // 
            // provinciaLlabel
            // 
            this.provinciaLlabel.AutoSize = true;
            this.provinciaLlabel.Location = new System.Drawing.Point(199, 36);
            this.provinciaLlabel.Name = "provinciaLlabel";
            this.provinciaLlabel.Size = new System.Drawing.Size(54, 13);
            this.provinciaLlabel.TabIndex = 27;
            this.provinciaLlabel.Text = "Provincia:";
            // 
            // ciudadComboBox
            // 
            this.ciudadComboBox.FormattingEnabled = true;
            this.ciudadComboBox.Location = new System.Drawing.Point(63, 32);
            this.ciudadComboBox.Name = "ciudadComboBox";
            this.ciudadComboBox.Size = new System.Drawing.Size(130, 21);
            this.ciudadComboBox.TabIndex = 26;
            // 
            // ciudadLabel
            // 
            this.ciudadLabel.AutoSize = true;
            this.ciudadLabel.Location = new System.Drawing.Point(14, 36);
            this.ciudadLabel.Name = "ciudadLabel";
            this.ciudadLabel.Size = new System.Drawing.Size(43, 13);
            this.ciudadLabel.TabIndex = 25;
            this.ciudadLabel.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Calle:";
            // 
            // TamboEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calleComboBox);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.paisLabel);
            this.Controls.Add(this.provinciaComboBox);
            this.Controls.Add(this.provinciaLlabel);
            this.Controls.Add(this.ciudadComboBox);
            this.Controls.Add(this.ciudadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.panel1);
            this.Name = "TamboEditorForm";
            this.Text = "Tambo";
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
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox calleComboBox;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.Label provinciaLlabel;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.Label ciudadLabel;
        private System.Windows.Forms.Label label2;
    }
}