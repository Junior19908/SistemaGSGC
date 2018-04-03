using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGSG.bd_loginDataSetTableAdapters;

namespace SistemaGSG
{
    public partial class FormRel : MetroFramework.Forms.MetroForm
    {
        public FormRel()
        {
            InitializeComponent();
        }

        private void FormRel_Load(object sender, EventArgs e)
        {
            // TODA: esta linha de código carrega dados na tabela 'bd_loginDataSet.CEAL'. Você pode movê-la ou removê-la conforme necessário.
            this.cEALTableAdapter.Fill(this.bd_loginDataSet.CEAL);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Main frm_Main = new frm_Main();
            frm_Main.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ceal ceal = new Ceal();
            ceal.Show();
            this.Visible = false;
        }
    }
}
