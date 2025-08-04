using PiramideRectangularFinalProg.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiramideRectangularFinalProg.Windows
{
    public partial class frmDetallePiramide : Form
    {
        private PiramideRectangular? piramide;
        public frmDetallePiramide()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmDetallePiramide_Load(object sender, EventArgs e)
        {

            if(piramide is not null)
            {

                txtLado.Text = piramide.LadoBase.ToString();
                txtAltura.Text = piramide.Altura.ToString();
                txtCantidadLados.Text = piramide.CantidadLados.ToString();
                txtColor.Text = piramide.Color.ToString();
                txtMaterial.Text = piramide.Material.ToString();
                txtVolumen.Text = piramide.CalcularVolumen().ToString("N2");
                txtAreaLateral.Text = piramide.CalcularAreaLateral().ToString("N2");
                txtAreaTotal.Text = piramide.CalcularAreaTotal().ToString("N2");
                txtAreaBase.Text = piramide.CalcularAreaBase().ToString("N2");

            }

        }

        public void EstablecerPiramide(PiramideRectangular pira)
        {
            piramide = pira;
        }
    }
}
