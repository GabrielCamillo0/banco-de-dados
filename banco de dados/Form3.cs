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
    public partial class Form3 : Form
    {
        private void buscarb()
        {
            MySqlConnection con = new MySqlConnection
          ("server=localhost;database=bolosPote;uid=root;pwd=1234");
            con.Open();
            String sql = "select nome,curso,periodo,rgm from alunos where nome =?";
            MySqlCommand comand = new MySqlCommand();
            comand.Parameters.AddWithValue("curso", nomeABox.Text);
            comand.CommandType = CommandType.Text;
            MySqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                nomeABox.Enabled = true;
                alunorgmBox.Enabled = true;
                nomeABox.Text = dr[0].ToString();
                alunorgmBox.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show(" nenhuma registro encontrado com esse nome ");
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            buscarb();
        }

        private void nomeABox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alunorgmBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show();
            cursoBox.Clear();
        }

        private void cursoBox_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
