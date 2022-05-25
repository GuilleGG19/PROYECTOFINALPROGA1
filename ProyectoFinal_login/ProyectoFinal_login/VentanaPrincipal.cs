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
    public partial class VentanaPrincipal : Form
    {
        Form1 inicio;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

       String conString = "datasource=localhost;port=3306;username=root;";
        private MySqlCommand command;

        private void databainvetario()
        {
            String consulta = "SELECTED * FROM compania_trabjadores.inventario";
            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //tblinvetario.DataTable = dt;
                con.Close();
            }catch(Exception ex){
                MessageBox.Show("Error al leer datos " + ex.Message);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            /*comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("Efectivo");
            comboBox2.Items.Add("Tarjtea");*/
        }
    }
}
