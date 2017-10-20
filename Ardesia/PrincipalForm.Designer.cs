namespace Ardesia
{
    partial class PrincipalForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.eployeesTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.customersTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 7;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(693, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.eployeesTileBarItem);
            this.tileBarGroupTables.Items.Add(this.customersTileBarItem);
            this.tileBarGroupTables.Items.Add(this.tileBarItem1);
            this.tileBarGroupTables.Items.Add(this.tileBarItem2);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // eployeesTileBarItem
            // 
            this.eployeesTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.eployeesTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.eployeesTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement25.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement25.Text = "Produccion";
            this.eployeesTileBarItem.Elements.Add(tileItemElement25);
            this.eployeesTileBarItem.Name = "eployeesTileBarItem";
            this.eployeesTileBarItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.eployeesTileBarItem_ItemClick);
            // 
            // customersTileBarItem
            // 
            this.customersTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.customersTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.customersTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement26.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement26.Text = "Mantenimiento";
            this.customersTileBarItem.Elements.Add(tileItemElement26);
            this.customersTileBarItem.Id = 2;
            this.customersTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.customersTileBarItem.Name = "customersTileBarItem";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement27.Text = "Clientes";
            tileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileBarItem1.Elements.Add(tileItemElement27);
            this.tileBarItem1.Id = 3;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement28.Text = "Insumos";
            this.tileBarItem2.Elements.Add(tileItemElement28);
            this.tileBarItem2.Id = 6;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // PrincipalForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 115);
            this.Controls.Add(this.tileBar);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem eployeesTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem customersTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
    }
}