namespace Ardesia
{
    partial class VerificacionContaminanteFisicoEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificacionContaminanteFisicoEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.contaminadoLabel = new System.Windows.Forms.Label();
            this.sectorComboBox = new System.Windows.Forms.ComboBox();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.empleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoLlabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.contaminadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contaminadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
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
            this.idTextBox.Location = new System.Drawing.Point(73, 8);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 23);
            this.idTextBox.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(14, 91);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(83, 17);
            this.descripcionLabel.TabIndex = 3;
            this.descripcionLabel.Text = "Descripción:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(115, 88);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(345, 23);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // contaminadoLabel
            // 
            this.contaminadoLabel.AutoSize = true;
            this.contaminadoLabel.Location = new System.Drawing.Point(14, 67);
            this.contaminadoLabel.Name = "contaminadoLabel";
            this.contaminadoLabel.Size = new System.Drawing.Size(95, 17);
            this.contaminadoLabel.TabIndex = 3;
            this.contaminadoLabel.Text = "Contaminado:";
            // 
            // sectorComboBox
            // 
            this.sectorComboBox.FormattingEnabled = true;
            this.sectorComboBox.Location = new System.Drawing.Point(73, 39);
            this.sectorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sectorComboBox.Name = "sectorComboBox";
            this.sectorComboBox.Size = new System.Drawing.Size(151, 24);
            this.sectorComboBox.TabIndex = 7;
            // 
            // sectorLabel
            // 
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(14, 42);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(53, 17);
            this.sectorLabel.TabIndex = 6;
            this.sectorLabel.Text = "Sector:";
            // 
            // empleadoComboBox
            // 
            this.empleadoComboBox.FormattingEnabled = true;
            this.empleadoComboBox.Location = new System.Drawing.Point(309, 39);
            this.empleadoComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empleadoComboBox.Name = "empleadoComboBox";
            this.empleadoComboBox.Size = new System.Drawing.Size(151, 24);
            this.empleadoComboBox.TabIndex = 9;
            // 
            // empleadoLlabel
            // 
            this.empleadoLlabel.AutoSize = true;
            this.empleadoLlabel.Location = new System.Drawing.Point(230, 42);
            this.empleadoLlabel.Name = "empleadoLlabel";
            this.empleadoLlabel.Size = new System.Drawing.Size(73, 17);
            this.empleadoLlabel.TabIndex = 8;
            this.empleadoLlabel.Text = "Empleado:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(342, 143);
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
            this.saveSimpleButton.Location = new System.Drawing.Point(217, 143);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // contaminadoCheckEdit
            // 
            this.contaminadoCheckEdit.Location = new System.Drawing.Point(115, 66);
            this.contaminadoCheckEdit.Name = "contaminadoCheckEdit";
            this.contaminadoCheckEdit.Properties.Caption = "";
            this.contaminadoCheckEdit.Size = new System.Drawing.Size(18, 19);
            this.contaminadoCheckEdit.TabIndex = 18;
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = "5/11/2017";
            this.dateEdit.Location = new System.Drawing.Point(309, 8);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(151, 22);
            this.dateEdit.TabIndex = 19;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(230, 11);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(49, 17);
            this.fechaLabel.TabIndex = 20;
            this.fechaLabel.Text = "Fecha:";
            // 
            // VerificacionContaminanteFisicoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 184);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.contaminadoCheckEdit);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.empleadoComboBox);
            this.Controls.Add(this.empleadoLlabel);
            this.Controls.Add(this.sectorComboBox);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.contaminadoLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VerificacionContaminanteFisicoEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verificación contaminante físico";
            this.Load += new System.EventHandler(this.VerificacionContaminanteFisicoEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contaminadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label contaminadoLabel;
        private System.Windows.Forms.ComboBox sectorComboBox;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.ComboBox empleadoComboBox;
        private System.Windows.Forms.Label empleadoLlabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraEditors.CheckEdit contaminadoCheckEdit;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private System.Windows.Forms.Label fechaLabel;
    }
}