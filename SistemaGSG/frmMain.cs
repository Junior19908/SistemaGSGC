using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGSG
{
    public partial class frm_Main : MetroFramework.Forms.MetroForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ceal mont = new Ceal();
            mont.Show();
            this.Visible = false;
        }

        private void porCódÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRel relMont = new FormRel();
            relMont.Show();
            this.Visible = false;
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
