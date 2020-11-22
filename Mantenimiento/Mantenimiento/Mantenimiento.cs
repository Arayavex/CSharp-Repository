using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario1 = new Forms_Paises();
            Formulario1.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario1 = new Form_Productos();
            Formulario1.Show();
        }
    }
}
