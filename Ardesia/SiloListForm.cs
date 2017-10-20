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
    public partial class SiloListForm : DevExpress.XtraEditors.XtraForm
    {
        public SiloListForm()
        {
            InitializeComponent();
        }

        private void editSimpleButton_Click(object sender, EventArgs e)
        {
            new SiloEditorForm().Show();
        }

        private void deleteSimpleButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void addSimpleButton_Click(object sender, EventArgs e)
        {
            new SiloEditorForm().Show();

        }
    }
}
