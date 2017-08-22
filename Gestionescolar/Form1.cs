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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datosgenerales f = new datosgenerales();
            f.Show();
        }

        private void verEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verest f = new verest();
            f.Show();
        }
    }
}
