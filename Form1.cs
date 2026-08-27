namespace MesaTechGestionTickets.Lab1
{
    public partial class FormMesaTech : Form
    {
        private ListaEnlazadaTickets listaTickets = new ListaEnlazadaTickets();
        public FormMesaTech()
        {
            InitializeComponent();
            cmbPrioridad.SelectedIndex = 0; // Establece la prioridad predeterminada en Alta
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string ubicacion = txtUbicacion.Text.Trim();
            string tipoFalla = txtTipoFalla.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string prioridad = cmbPrioridad.Text;

            Ticket nuevoTicket = new Ticket(id, ubicacion, tipoFalla, descripcion, prioridad);

            string resultado = listaTickets.Agregar(nuevoTicket);

            if (string.IsNullOrEmpty(resultado))
            {
                txtResultado.Text = $"Ticket '{id}' registrado exitosamente.";
                LimpiarCampos();
            }
            else
            {
                txtResultado.Text = resultado;
            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            string resultado = listaTickets.Listar();
            txtResultado.Text = resultado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtIdBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                txtResultado.Text = "Por favor, ingrese un ID para buscar.";
                return;
            }

            Ticket? ticketEncontrado = listaTickets.Buscar(id);

            if (ticketEncontrado != null)
            {
                txtResultado.Text = $"Ticket encontrado:{Environment.NewLine}{ticketEncontrado}";
            }
            else
            {
                txtResultado.Text = $"No se encontró ningún ticket con el ID '{id}'.";
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtIdBusqueda.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                txtResultado.Text = "Ingrese un Id para eliminar.";
                return;
            }

            string resultado = listaTickets.Eliminar(id);
            txtResultado.Text = resultado;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string id = txtIdBusqueda.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                txtResultado.Text = "Ingrese un Id para cerrar.";
                return;
            }

            string resultado = listaTickets.Cerrar(id);
            txtResultado.Text = resultado;
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = listaTickets.Contar();
            txtResultado.Text = $"Actualmente hay {total} ticket(s) activo(s) (Pendientes).";
        }
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtUbicacion.Clear();
            txtTipoFalla.Clear();
            txtDescripcion.Clear();
            cmbPrioridad.SelectedIndex = 0; // Restablece la prioridad a Alta    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
