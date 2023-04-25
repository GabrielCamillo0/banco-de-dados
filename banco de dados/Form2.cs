using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace banco_de_dados
{
    public partial class Form2 : Form
    {
        private void cl()
        {
            rgmBox.Clear();
            nomeBox.Clear();
            cursoBox.Clear();
            pBox.Clear();
        }
        private void cbanco()
        {
            int rgm = Convert.ToInt16(rgmBox.Text);
            string conectar = "server=localhost;uid=root;pwd='';database=escola";
            MySqlConnection con = new MySqlConnection(conectar);
            MySqlCommand comando = new MySqlCommand("Insert Into aluno(rgm,nome,curso,periodo)values(" +

                "'" + rgm + "','"

               + nomeBox.Text + "','"

                + cursoBox.Text + "','"

                 + pBox.Text + "')", con);
            con.Open();
            comando.ExecuteReader();
            MessageBox.Show(" finalmente ");
        }
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            cbanco();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            cl();
            voltar.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rgmBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
