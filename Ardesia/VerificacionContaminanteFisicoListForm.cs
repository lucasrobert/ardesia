using System;
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
    public partial class VerificacionContaminanteFisicoListForm : DevExpress.XtraEditors.XtraForm
    {
        public VerificacionContaminanteFisicoListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new VerificacionContaminanteFisicoEditorForm().Show();

        }
        
    }
}
