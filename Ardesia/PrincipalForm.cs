﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Ardesia
{
    public partial class PrincipalForm : DevExpress.XtraEditors.XtraForm
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void eployeesTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            new EmpleadoListForm().Show();
        }

    }
}