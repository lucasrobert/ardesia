﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ardesia
{
    public partial class TransportistaListForm : DevExpress.XtraEditors.XtraForm
    {
        public TransportistaListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new TransportistaEditorForm().Show();

        }
        
    }
}
