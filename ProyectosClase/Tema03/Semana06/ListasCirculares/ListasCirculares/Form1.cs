namespace ListasCirculares
{
    public partial class Form1 : Form
    {
        private ListaCircular lista = new ListaCircular();
        public Form1()
        {
            InitializeComponent();
        }
        private void actualizarInterfaz()
        {
            lstVisualizacion.Items.Clear();
            Nodo? actual = lista.Cabeza;
            if (actual != null)
            {
                do
                {
                    string etiqueta = $"[ {actual!.Valor} -->]";

                    if (actual == lista.Cabeza) etiqueta += " (cabeza)";
                    if (actual == lista.Cola) etiqueta += " (Cola)";

                    lstVisualizacion.Items.Add(etiqueta);
                    actual = actual.Siguiente;
                } while (actual != lista.Cabeza);
            }
            else
            {
                lstVisualizacion.Items.Clear();
            }            
        }
        private bool obtenerValor(out int valor)
        {
            if (int.TryParse(txtValor.Text, out valor))
            {
                return true;
            }
            MessageBox.Show("Valor inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void btnInsertarInicio_Click(object sender, EventArgs e)
        {
            if (obtenerValor(out int valor))
            {
                lista.insertarInicio(valor);
                actualizarInterfaz();
                txtValor.Clear();
            }
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            if (obtenerValor(out int valor))
            {
                lista.insertarFinal(valor);
                actualizarInterfaz();
                txtValor.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(obtenerValor(out int valor))
            {
                if(lista.Eliminar(valor))
                {
                    MessageBox.Show($"El valor {valor} fue eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarInterfaz();
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtValor.Clear();
            }
        }
    }
}
