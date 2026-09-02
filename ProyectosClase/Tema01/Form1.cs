namespace Semana01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista listaEnlazada = new Lista();

        private void btnVer_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            if (!listaEnlazada.mostrarLista(lstLista))
            {
                MessageBox.Show("Lista esta vacía", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (listaEnlazada.buscarNodo(Int32.Parse(txtActual.Text)))
            {
                MessageBox.Show("Valor existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listaEnlazada.insertarNodo(Int32.Parse(txtActual.Text));
                MessageBox.Show("Valor Insertado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtActual.Focus();
            txtActual.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool rpta = listaEnlazada.buscarNodo(Int32.Parse(txtBuscar.Text));
            if (rpta == true)
            {
                MessageBox.Show("Valor SI Existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Valor NO Existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int anterior = Int32.Parse(txtAnterior.Text);
                int nuevo = Int32.Parse(txtNuevo.Text);
                bool rpta = listaEnlazada.modificarNodo(anterior, nuevo);
                if (rpta == true)
                {
                    MessageBox.Show("Actualizacion Realizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("No se pudo realizar actualizacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool rpta = listaEnlazada.eliminarNodo(Int32.Parse(txtEliminar.Text));

            if (rpta)
            {
                MessageBox.Show("Nodo Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error. No se puede eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaEnlazada.ordenarLista();
            btnVer_Click(sender, e);
        }
    }
}
