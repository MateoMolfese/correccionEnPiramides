using PiramideRectangularFinalProg.Datos;
using PiramideRectangularFinalProg.Entidades;

namespace PiramideRectangularFinalProg.Windows
{
    public partial class frmPiramides : Form
    {

        private RepositorioDePiramides repositorio;
        private List<PiramideRectangular>? piramides;
        private int cantidad;

        public frmPiramides()
        {
            InitializeComponent();
            repositorio = new RepositorioDePiramides();
        }

        private void frmPiramides_Load(object sender, EventArgs e)
        {
            cantidad = repositorio.getCantidadPiramides();
            if (cantidad > 0)
            {
                piramides = repositorio.GetPiramides();
                MostrarDatosEnGrilla();
            }
            MostrarCantidadPiramides();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var piramide in piramides!)
            {
                var row = ConstruirFila();
                setearFila(row, piramide);
                AgregarFila(row);
            }

            MostrarCantidadPiramides();
        }

        private DataGridViewRow ConstruirFila()
        {
            var row = new DataGridViewRow();
            row.CreateCells(dgvDatos);
            return row;
        }

        private void setearFila(DataGridViewRow row, PiramideRectangular obj)
        {
            row.Cells[colLado.Index].Value = obj.LadoBase.ToString("N2");
            row.Cells[colCantidad.Index].Value = obj.CantidadLados;
            row.Cells[colMaterial.Index].Value = obj.Material;
            row.Cells[colColor.Index].Value = obj.Color;
            row.Cells[colVolumen.Index].Value = obj.CalcularVolumen().ToString("N2");

            row.Tag = obj;
        }

        private void AgregarFila(DataGridViewRow row)
        {
            dgvDatos.Rows.Add(row);
        }

        private void MostrarCantidadPiramides()
        {
            txtCantidad.Text = cantidad.ToString();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPiramideAE form = new frmPiramideAE() { Text = "Agregar Piramide" };
            DialogResult dr = form.ShowDialog(this);

            if (dr == DialogResult.Cancel) return;

            PiramideRectangular piramide = form.GetPiramide();
            if (piramide is null)
            {
                return;
            }
            if (!repositorio.Existe(piramide))
            {
                repositorio.Agregar(piramide);
                cantidad = repositorio.getCantidadPiramides();
                var r = ConstruirFila();
                setearFila(r, piramide);
                AgregarFila(r);
                MostrarCantidadPiramides();
                MessageBox.Show($"Piramide {piramide.ToString()} agregada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Piramide {piramide.ToString()} existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var pSeleccionada = dgvDatos.SelectedRows[0];
            PiramideRectangular piramide = (PiramideRectangular)pSeleccionada.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar la piramide {piramide.ToString()}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            repositorio.Borrar(piramide);
            quitarFila(pSeleccionada);
            cantidad = repositorio.getCantidadPiramides();
            MostrarCantidadPiramides();
            MessageBox.Show($"Piramide {piramide.ToString()} borrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitarFila(DataGridViewRow p)
        {
            dgvDatos.Rows.Remove(p);
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {

            piramides = repositorio.GetPiramides();
            cantidad = repositorio.getCantidadPiramides();
            MostrarCantidadPiramides();
            MostrarDatosEnGrilla();

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repositorio.guardarDatos();
            MessageBox.Show("fin del programa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {

            var pDetalles = dgvDatos.SelectedRows[0];
            var piramide = pDetalles.Tag as PiramideRectangular;

            frmDetallePiramide form = new frmDetallePiramide() { Text = "Detalles de la Piramide." };
            form.EstablecerPiramide(piramide);
            DialogResult dr = form.ShowDialog(this);

            if (dr == DialogResult.OK) return;

        }

        private void lado09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piramides = repositorio.getListaOrdenada(Orden.Asc);
            MostrarDatosEnGrilla();
        }

        private void lado90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            piramides = repositorio.getListaOrdenada(Orden.Desc);
            MostrarDatosEnGrilla();
        }

        private void tsCboContornos_Click(object sender, EventArgs e)
        {
            PiramideColor color = (PiramideColor)tsCboContornos.SelectedItem!;
            piramides = repositorio.Filtrar(color);
            cantidad = repositorio.getCantidadPiramides(color);
            MostrarDatosEnGrilla();
            MostrarCantidadPiramides();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var pSeleccionada = dgvDatos.SelectedRows[0];
            PiramideRectangular piramide = (PiramideRectangular)pSeleccionada.Tag!;
            frmPiramideAE form = new frmPiramideAE() { Text = "Editar Piramide" };

            
            form.SetPiramide(piramide); 

            DialogResult dr = form.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            PiramideRectangular piramideEditada = form.GetPiramide();
            if (piramideEditada is null)
            {
                return;
            }
            if (!repositorio.Existe(piramideEditada, piramide))
            {
                repositorio.Editar(piramide, piramideEditada);
                setearFila(pSeleccionada, piramideEditada);
                MessageBox.Show($"Piramide {piramideEditada.ToString()} editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Piramide {piramideEditada.ToString()} existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
