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

namespace Gestionescolar
{
    public partial class datosgenerales : Form
    {
        public datosgenerales()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("Server=localhost;Database= gestionescolar;UID=root;Password=muerete66");
            try
            {
                cnx.Open();
                string cmd = "INSERT INTO datosgenerales(nombre,apellido,sexo,direccion,edad) VALUES('" + txtnombre.Text + "','" + txtape.Text + "','"+cmbsex.Text+"','"+txtdireccio.Text+"',('" + dtpedad.Text + "'));";
                MySqlCommand insertion = new MySqlCommand(cmd, cnx);
                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                }



            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void datosgenerales_Load(object sender, EventArgs e)
        {
            dtpedad.Format = DateTimePickerFormat.Custom;
            dtpedad.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpedad_ValueChanged(object sender, EventArgs e)
        {
            string dt = dtpedad.Value.ToString("yyyy/MM/dd");

        }
    }
}
