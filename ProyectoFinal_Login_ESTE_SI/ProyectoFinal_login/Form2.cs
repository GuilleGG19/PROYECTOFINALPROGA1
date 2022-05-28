using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_login
{
    public partial class Entrada : Form
    {
        VentanaPrincipal ventana2;
        public Entrada()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana2 = new VentanaPrincipal();
            ventana2.Show();
            this.Hide();
        }
    }
}
