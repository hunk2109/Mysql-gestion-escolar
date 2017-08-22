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
    public partial class Agrematerias : Form
    {
        public Agrematerias()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("Server=localhost;Database= gestionescolar;UID=root;Password=muerete66");
            try
            {
                cnx.Open();
                string cmd = "insert into materias(materias) values('" + txtmat.Text + "')";
                MySqlCommand insertion = new MySqlCommand(cmd, cnx);
                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
