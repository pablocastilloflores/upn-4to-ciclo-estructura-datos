namespace ListasDobles
{
    public partial class Form1 : Form
    {
        private ListaDoble lista = new ListaDoble();
        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarInterfaz()
        {
            lstVisualizacion.Items.Clear();
            Nodo? actual = lista.cabeza;

            while (actual != null)
            {
                lstVisualizacion.Items.Add($"<- [{actual.Valor}] ->");
                actual = actual.Siguiente;
            }
        }
        private bool obtenerValor(out int valor)
        {
            if (int.TryParse(txtValor.Text, out valor))
            {
                return true;
            }
            MessageBox.Show("Número incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (obtenerValor(out int valor))
            {
                if (lista.existe(valor))
                {
                    MessageBox.Show("Ese valor ya existe en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lista.insertarInicio(valor);
                actualizarInterfaz();
                txtValor.Clear();
            }
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (obtenerValor(out int valor))
            {
                if (lista.existe(valor))
                {
                    MessageBox.Show("Ese valor ya existe en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lista.insertarFinal(valor);
                actualizarInterfaz();
                txtValor.Clear();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obtenerValor(out int valor))
            {
                if (lista.eliminar(valor))
                {
                    MessageBox.Show($"Valor {valor} eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarInterfaz();
                }
                else
                {
                    MessageBox.Show("Valor no encontrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtValor.Clear();
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (obtenerValor(out int valor))
            {
                int indice = lista.buscar(valor);
                if (indice == -1)
                {
                    MessageBox.Show("Ese valor no existe en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lstVisualizacion.SelectedIndex = indice;
                MessageBox.Show($"Valor {valor} encontrado en la posición {indice + 1}", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lista.limpiar();
            actualizarInterfaz();
            txtValor.Clear();
        }
    }
}
