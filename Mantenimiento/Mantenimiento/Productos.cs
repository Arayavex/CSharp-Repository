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
    public partial class Form_Productos : Form
    {
        public Form_Productos()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            ds = Comm.GetDataProductos();
            dataGv2.DataSource = ds.Tables[0];
            txtID.Text = dataGv2.Rows[0].Cells[0].Value.ToString();
            txtCantidad.Text = dataGv2.Rows[0].Cells[1].Value.ToString();
            txtPre.Text = dataGv2.Rows[0].Cells[2].Value.ToString();
            txtMarca.Text = dataGv2.Rows[0].Cells[3].Value.ToString();
            txtDesc.Text = dataGv2.Rows[0].Cells[4].Value.ToString();
            txtTipo.Text = dataGv2.Rows[0].Cells[5].Value.ToString();
        }

        private void dataGv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGv2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCantidad.Text = dataGv2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPre.Text = dataGv2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMarca.Text = dataGv2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDesc.Text = dataGv2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTipo.Text = dataGv2.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }

        private void ClearData()
        {
            txtID.Text = "";
            txtCantidad.Text = "";
            txtDesc.Text = "";
            txtMarca.Text = "";
            txtTipo.Text = "";
            txtPre.Text = "";

        }

        private void btnIngreProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Comm.IngresoProducto(txtID.Text, txtCantidad.Text, txtPre.Text, txtMarca.Text, txtDesc.Text, txtTipo.Text));
            DataSet ds = new DataSet();
            ds = Comm.GetDataProductos();
            dataGv2.DataSource = ds.Tables[0];
            ClearData();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Comm.EliminarProducto(txtID.Text));
            DataSet ds = new DataSet();
            ds = Comm.GetDataProductos();
            dataGv2.DataSource = ds.Tables[0];
            ClearData();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Comm.ModificarProducto(txtID.Text, txtDesc.Text));
            DataSet ds = new DataSet();
            ds = Comm.GetDataProductos();
            dataGv2.DataSource = ds.Tables[0];
            ClearData();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario1 = new Mantenimiento();
            Formulario1.Show();
        }
    }
}
