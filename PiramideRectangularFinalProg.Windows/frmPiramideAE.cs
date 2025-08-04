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
    public partial class frmPiramideAE : Form
    {
        private PiramideRectangular? piramide;
        public frmPiramideAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            cboColores.DataSource = Enum.GetValues(typeof(PiramideColor));

            if (piramide != null)
            {
               SetPiramide(piramide);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if(ValidarDatos())
            {

                if(piramide is null)

                {
                    int ladoBase = int.Parse(txtLado.Text);
                    int cantidadLados = (int)nudCantidad.Value;
                    PiramideMaterial material;
                    if (rbtPlastico.Checked)
                        material = PiramideMaterial.Plastico;
                    else if (rbtVidrio.Checked)
                        material = PiramideMaterial.Vidrio;
                    else
                        material = PiramideMaterial.Madera;
                    PiramideColor color = (PiramideColor)cboColores.SelectedItem!;

                    piramide = new PiramideRectangular(ladoBase, cantidadLados, material, color);
                }

                piramide.LadoBase = int.Parse(txtLado.Text);
                piramide.Altura = int.Parse(txtAltura.Text);
                piramide.CantidadLados = (int)nudCantidad.Value;

                if(rbtPlastico.Checked)
                {
                    piramide.Material = PiramideMaterial.Plastico;
                } else if(rbtVidrio.Checked)
                {
                    piramide.Material = PiramideMaterial.Vidrio;
                } else
                {
                    piramide.Material = PiramideMaterial.Madera;
                }

                piramide.Color = (PiramideColor)cboColores.SelectedIndex;

                DialogResult = DialogResult.OK;

            }

        }

        public bool ValidarDatos()
        {

            bool valido = true;
            errorProvider1.Clear();

            if(string.IsNullOrEmpty(txtLado.Text) || !int.TryParse(txtLado.Text, out int valorLado) || valorLado <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Ingrese un valor valido.");
            }

            if (string.IsNullOrEmpty(txtAltura.Text) || !int.TryParse(txtAltura.Text, out int valorAltura) || valorAltura <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Ingrese un valor valido.");
            }

            return valido;

        }

        public PiramideRectangular? GetPiramide()
        {
            return piramide;
        }

        public void SetPiramide(PiramideRectangular piramide)
        {
            this.piramide = piramide;
            txtLado.Text = piramide.LadoBase.ToString();
            txtAltura.Text = piramide.Altura.ToString();
            nudCantidad.Value = piramide.CantidadLados;
            switch (piramide.Material)
            {
                case PiramideMaterial.Plastico:
                    rbtPlastico.Checked = true;
                    break;
                case PiramideMaterial.Vidrio:
                    rbtVidrio.Checked = true;
                    break;
                case PiramideMaterial.Madera:
                    rbtMadera.Checked = true;
                    break;
                default:
                    rbtPlastico.Checked = false;
                    rbtVidrio.Checked = false;
                    rbtMadera.Checked = false;
                    break;
            }
            cboColores.SelectedItem = piramide.Color;

        }
    }
}
