using System;
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
    public partial class Form_Geografia : Form
    {
        String ID_Pais = "";
        public Form_Geografia(String IDPais)
        {
            ID_Pais = IDPais;
            InitializeComponent();
            cargaComboGeografia();
            DataSet ds = new DataSet();
            ds = Comm.GetDataGeografia(cbx_TipoGeografia.SelectedValue.ToString(), IDPais);
            dataGv1.DataSource = ds.Tables[0];
        }



        public void cargaComboGeografia()
        {
            cbx_TipoGeografia.ValueMember = "ID_Tipo_Geografia";
            cbx_TipoGeografia.DisplayMember = "Descripcion";
            cbx_TipoGeografia.DataSource = Comm.cargaComboGeografia();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario;
            Formulario = new Forms_Paises();
            Formulario.Show();
        }

        private void cbxTipGeograf_Ind_Chang(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Comm.GetDataGeografia(cbx_TipoGeografia.SelectedValue.ToString(), ID_Pais);
            dataGv1.DataSource = ds.Tables[0];
        }
    }
}
