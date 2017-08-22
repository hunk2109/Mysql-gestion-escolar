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
    public partial class verest : Form
    {
        public verest()
        {
            InitializeComponent();
        }

        private void verest_Load(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("Server=localhost;Database= gestionescolar;UID=root;Password=muerete66");
            try
            {
                MySqlDataAdapter adac = new MySqlDataAdapter("select * from datosgenerales", cnx);
                DataTable tabla = new DataTable("Estudiantes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            }
    }

