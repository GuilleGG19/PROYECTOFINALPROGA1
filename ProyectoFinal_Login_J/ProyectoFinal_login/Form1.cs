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

namespace ProyectoFinal_login
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;");

        Entrada logeo;

        public Form1()
        {
            InitializeComponent();
        }

       /*private void leerDatos()
        {
            string consulta = "SELECT * FROM `usuarios` WHERE 1";
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(consulta, con);
                MessageBox.Show("Conectado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.);
            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                if ((textBox1.Text == "Admin") && (textBox2.Text == "pass"))
                {
                    logeo = new Entrada();
                    logeo.ShowDialog();
                    this.Hide();
                }
                else if((textBox1.Text == "Admin2") && (textBox2.Text == "pass"))
                {
                    logeo = new Entrada();
                    logeo.ShowDialog();
                    this.Hide();
                }
            }*/

            Form1 Entrada = new Form1();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT usuario, contraseña FROM compania_trabajadores.usuario WHERE usuario = @vusuario AND contraseña = @vcontraseña ", con);
                cmd.Parameters.AddWithValue("@vusuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@vcontraseña", textBox2.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    con.Close();
                    logeo = new Entrada();
                    logeo.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}