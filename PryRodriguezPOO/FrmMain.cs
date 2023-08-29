using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRodriguezPOO
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClasPersonaje objeto = new ClasPersonaje();
            objeto.Nombre = txtNombre.Text;
            objeto.Fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.Destreza = int.Parse (txtDestreza.Text);

            lblInfo1.Text += objeto.Nombre + "-" + objeto.Fuerza +"-"+
                objeto.Destreza+ "\n";
           
        }
    }
}
