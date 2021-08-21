using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaDeTreinamento
{
    public partial class FormLogin : Form
    {
        MySqlConnection con;
        public FormLogin()
        {
            InitializeComponent();

            try
            {
                con = new MySqlConnection("server=localhost;port=3306;User ID = root; database = techstar_treinamento; password = ");
                con.Open();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand query = new MySqlCommand("SELECT * FROM usuario WHERE loginUsuario = @login", con);

                query.Parameters.AddWithValue("@login", textBoxLogin.Text);

                MySqlDataReader dr = query.ExecuteReader();

                if(dr.Read() != false)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                } 
                else
                {
                    MessageBox.Show("Esse usuario não existe!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
