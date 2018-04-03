using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaGSG
{
    public partial class Ceal : MetroFramework.Forms.MetroForm
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Ceal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserido com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            {

                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\junio\source\repos\SistemaGSG\SistemaGSG\bd_login.mdf;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO CEAL (cod,mes,data,valor,nome,box,boxd,boxt) VALUES(@cod,@mes,@data,@valor,@nome,@box,@boxd,@boxt)", con);
                cmd.Parameters.Add("@cod", textBox1.Text);
                cmd.Parameters.Add("@mes", textBox2.Text);
                cmd.Parameters.Add("@data", textBox3.Text);
                cmd.Parameters.Add("@valor", textBox4.Text);
                cmd.Parameters.Add("@nome", textBox5.Text);
                cmd.Parameters.Add("@box", checkBox1.Text);
                cmd.ExecuteNonQuery();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                checkBox1.Text = "";
                checkBox2.Text = "";
                checkBox3.Text = "";
                textBox5.Text = "";


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Main back = new frm_Main();
            back.Show();
            this.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
