﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento
{
    public partial class Forms_Paises : Form
    {
        public Forms_Paises()
        {
            InitializeComponent();
            DataSet ds = new DataSet(); 
            ds = Comm.GetDataPais();
            dataGv1.DataSource = ds.Tables[0];
            txtID.Text = dataGv1.Rows[0].Cells[0].Value.ToString();
            txtPais.Text = dataGv1.Rows[0].Cells[1].Value.ToString();
        }

      
        private void ClearData()
        {
            txtID.Text = "";
            txtPais.Text = "";
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Comm.IngresarPais(txtID.Text,txtPais.Text));
            DataSet ds = new DataSet();
            ds = Comm.GetDataPais();
            dataGv1.DataSource = ds.Tables[0];
            ClearData();
        }

        
        private void dataGv1show(object sender, DataGridViewCellMouseEventArgs e)
        { 
            //ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = dataGv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPais.Text = dataGv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Comm.ModificarPais(txtID.Text, txtPais.Text));
            DataSet ds = new DataSet();
            ds = Comm.GetDataPais();
            dataGv1.DataSource = ds.Tables[0];
            ClearData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Comm.EliminarPais(txtID.Text));
            DataSet ds = new DataSet();
            ds = Comm.GetDataPais();
            dataGv1.DataSource = ds.Tables[0];
            ClearData();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario1 = new Mantenimiento();
            Formulario1.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario1 = new Form_Geografia(txtID.Text);
            Formulario1.Show();
        }
    }
    }


