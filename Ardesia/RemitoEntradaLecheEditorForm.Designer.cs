namespace Ardesia
{
    partial class RemitoEntradaLecheEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemitoEntradaLecheEditorForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tamboLabel = new System.Windows.Forms.Label();
            this.transportistaLlabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.litrosLabel = new System.Windows.Forms.Label();
            this.reciboLecheLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.observacionesLabel = new System.Windows.Forms.Label();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.textEditLitros = new DevExpress.XtraEditors.TextEdit();
            this.textEditTemperatura = new DevExpress.XtraEditors.TextEdit();
            this.textEditObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.lookUpEditReciboLeche = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditTambo = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditTransportista = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLitros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTemperatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReciboLeche.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTambo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTransportista.Properties)).BeginInit();
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
            this.idLabel.Location = new System.Drawing.Point(14, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 17);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitSimpleButton.ImageOptions.ImageIndex = 1;
            this.exitSimpleButton.ImageOptions.ImageList = this.imageList1;
            this.exitSimpleButton.Location = new System.Drawing.Point(723, 156);
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
            this.saveSimpleButton.Location = new System.Drawing.Point(598, 156);
            this.saveSimpleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(118, 27);
            this.saveSimpleButton.TabIndex = 16;
            this.saveSimpleButton.Text = "&Guardar";
            // 
            // tamboLabel
            // 
            this.tamboLabel.AutoSize = true;
            this.tamboLabel.Location = new System.Drawing.Point(14, 39);
            this.tamboLabel.Name = "tamboLabel";
            this.tamboLabel.Size = new System.Drawing.Size(56, 17);
            this.tamboLabel.TabIndex = 6;
            this.tamboLabel.Text = "Tambo:";
            // 
            // transportistaLlabel
            // 
            this.transportistaLlabel.AutoSize = true;
            this.transportistaLlabel.Location = new System.Drawing.Point(225, 39);
            this.transportistaLlabel.Name = "transportistaLlabel";
            this.transportistaLlabel.Size = new System.Drawing.Size(93, 17);
            this.transportistaLlabel.TabIndex = 8;
            this.transportistaLlabel.Text = "Transportista:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(225, 9);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(49, 17);
            this.fechaLabel.TabIndex = 18;
            this.fechaLabel.Text = "Fecha:";
            // 
            // litrosLabel
            // 
            this.litrosLabel.AutoSize = true;
            this.litrosLabel.Location = new System.Drawing.Point(455, 39);
            this.litrosLabel.Name = "litrosLabel";
            this.litrosLabel.Size = new System.Drawing.Size(46, 17);
            this.litrosLabel.TabIndex = 19;
            this.litrosLabel.Text = "Litros:";
            // 
            // reciboLecheLabel
            // 
            this.reciboLecheLabel.AutoSize = true;
            this.reciboLecheLabel.Location = new System.Drawing.Point(455, 9);
            this.reciboLecheLabel.Name = "reciboLecheLabel";
            this.reciboLecheLabel.Size = new System.Drawing.Size(89, 17);
            this.reciboLecheLabel.TabIndex = 21;
            this.reciboLecheLabel.Text = "Recibo leche:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(684, 39);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(78, 17);
            this.tempLabel.TabIndex = 22;
            this.tempLabel.Text = "Temp (°C):";
            // 
            // observacionesLabel
            // 
            this.observacionesLabel.AutoSize = true;
            this.observacionesLabel.Location = new System.Drawing.Point(14, 74);
            this.observacionesLabel.Name = "observacionesLabel";
            this.observacionesLabel.Size = new System.Drawing.Size(102, 17);
            this.observacionesLabel.TabIndex = 24;
            this.observacionesLabel.Text = "Observaciones:";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(324, 8);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(125, 22);
            this.dateEdit.TabIndex = 26;
            // 
            // textEditId
            // 
            this.textEditId.Enabled = false;
            this.textEditId.Location = new System.Drawing.Point(91, 8);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(128, 22);
            this.textEditId.TabIndex = 27;
            // 
            // textEditLitros
            // 
            this.textEditLitros.Enabled = false;
            this.textEditLitros.Location = new System.Drawing.Point(550, 36);
            this.textEditLitros.Name = "textEditLitros";
            this.textEditLitros.Size = new System.Drawing.Size(128, 22);
            this.textEditLitros.TabIndex = 30;
            // 
            // textEditTemperatura
            // 
            this.textEditTemperatura.Enabled = false;
            this.textEditTemperatura.Location = new System.Drawing.Point(768, 36);
            this.textEditTemperatura.Name = "textEditTemperatura";
            this.textEditTemperatura.Size = new System.Drawing.Size(78, 22);
            this.textEditTemperatura.TabIndex = 31;
            // 
            // textEditObservaciones
            // 
            this.textEditObservaciones.Location = new System.Drawing.Point(122, 71);
            this.textEditObservaciones.Name = "textEditObservaciones";
            this.textEditObservaciones.Size = new System.Drawing.Size(721, 78);
            this.textEditObservaciones.TabIndex = 32;
            // 
            // lookUpEditReciboLeche
            // 
            this.lookUpEditReciboLeche.Location = new System.Drawing.Point(550, 8);
            this.lookUpEditReciboLeche.Name = "lookUpEditReciboLeche";
            this.lookUpEditReciboLeche.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditReciboLeche.Properties.NullText = "";
            this.lookUpEditReciboLeche.Size = new System.Drawing.Size(125, 22);
            this.lookUpEditReciboLeche.TabIndex = 34;
            // 
            // lookUpEditTambo
            // 
            this.lookUpEditTambo.Location = new System.Drawing.Point(91, 36);
            this.lookUpEditTambo.Name = "lookUpEditTambo";
            this.lookUpEditTambo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTambo.Properties.NullText = "";
            this.lookUpEditTambo.Size = new System.Drawing.Size(128, 22);
            this.lookUpEditTambo.TabIndex = 35;
            // 
            // lookUpEditTransportista
            // 
            this.lookUpEditTransportista.Location = new System.Drawing.Point(324, 36);
            this.lookUpEditTransportista.Name = "lookUpEditTransportista";
            this.lookUpEditTransportista.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTransportista.Properties.NullText = "";
            this.lookUpEditTransportista.Size = new System.Drawing.Size(125, 22);
            this.lookUpEditTransportista.TabIndex = 36;
            // 
            // RemitoEntradaLecheEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 197);
            this.Controls.Add(this.lookUpEditTransportista);
            this.Controls.Add(this.lookUpEditTambo);
            this.Controls.Add(this.lookUpEditReciboLeche);
            this.Controls.Add(this.textEditTemperatura);
            this.Controls.Add(this.textEditLitros);
            this.Controls.Add(this.textEditId);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.observacionesLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.reciboLecheLabel);
            this.Controls.Add(this.litrosLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.exitSimpleButton);
            this.Controls.Add(this.saveSimpleButton);
            this.Controls.Add(this.transportistaLlabel);
            this.Controls.Add(this.tamboLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.textEditObservaciones);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RemitoEntradaLecheEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remito de entrada de leche";
            this.Load += new System.EventHandler(this.RemitoEntradaLecheEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLitros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTemperatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReciboLeche.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTambo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTransportista.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private System.Windows.Forms.Label tamboLabel;
        private System.Windows.Forms.Label transportistaLlabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label litrosLabel;
        private System.Windows.Forms.Label reciboLecheLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label observacionesLabel;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.TextEdit textEditLitros;
        private DevExpress.XtraEditors.TextEdit textEditTemperatura;
        private DevExpress.XtraEditors.MemoEdit textEditObservaciones;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditReciboLeche;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTambo;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTransportista;
    }
}