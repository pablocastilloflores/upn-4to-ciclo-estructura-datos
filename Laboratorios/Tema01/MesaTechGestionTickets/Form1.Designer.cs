namespace MesaTechGestionTickets.Lab1
{
    partial class FormMesaTech
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosTicket = new GroupBox();
            cmbPrioridad = new ComboBox();
            txtDescripcion = new TextBox();
            txtTipoFalla = new TextBox();
            txtUbicacion = new TextBox();
            txtId = new TextBox();
            lblPrioridad = new Label();
            lblDescripcion = new Label();
            lblTipoFalla = new Label();
            lblUbicacion = new Label();
            lblId = new Label();
            grpBotones = new GroupBox();
            btnLimpiar = new Button();
            btnContar = new Button();
            btnCerrar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnListar = new Button();
            btnRegistrar = new Button();
            grpOperacionesId = new GroupBox();
            lblAclaracionId = new Label();
            txtIdBusqueda = new TextBox();
            lblIdBusqueda = new Label();
            grpResultados = new GroupBox();
            txtResultado = new TextBox();
            grpDatosTicket.SuspendLayout();
            grpBotones.SuspendLayout();
            grpOperacionesId.SuspendLayout();
            grpResultados.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosTicket
            // 
            grpDatosTicket.Controls.Add(cmbPrioridad);
            grpDatosTicket.Controls.Add(txtDescripcion);
            grpDatosTicket.Controls.Add(txtTipoFalla);
            grpDatosTicket.Controls.Add(txtUbicacion);
            grpDatosTicket.Controls.Add(txtId);
            grpDatosTicket.Controls.Add(lblPrioridad);
            grpDatosTicket.Controls.Add(lblDescripcion);
            grpDatosTicket.Controls.Add(lblTipoFalla);
            grpDatosTicket.Controls.Add(lblUbicacion);
            grpDatosTicket.Controls.Add(lblId);
            grpDatosTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDatosTicket.Location = new Point(12, 12);
            grpDatosTicket.Name = "grpDatosTicket";
            grpDatosTicket.Size = new Size(475, 302);
            grpDatosTicket.TabIndex = 0;
            grpDatosTicket.TabStop = false;
            grpDatosTicket.Text = "Sección 1 - Datos del Ticket";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.Font = new Font("Segoe UI", 9F);
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbPrioridad.Location = new Point(174, 255);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(295, 23);
            cmbPrioridad.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(174, 200);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(295, 25);
            txtDescripcion.TabIndex = 8;
            // 
            // txtTipoFalla
            // 
            txtTipoFalla.Font = new Font("Segoe UI", 10F);
            txtTipoFalla.Location = new Point(174, 149);
            txtTipoFalla.Name = "txtTipoFalla";
            txtTipoFalla.Size = new Size(295, 25);
            txtTipoFalla.TabIndex = 7;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Segoe UI", 10F);
            txtUbicacion.Location = new Point(174, 100);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(295, 25);
            txtUbicacion.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(174, 53);
            txtId.Name = "txtId";
            txtId.Size = new Size(295, 25);
            txtId.TabIndex = 5;
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrioridad.Location = new Point(90, 255);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(77, 19);
            lblPrioridad.TabIndex = 4;
            lblPrioridad.Text = "Prioridad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.Location = new Point(76, 200);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 19);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblTipoFalla
            // 
            lblTipoFalla.AutoSize = true;
            lblTipoFalla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoFalla.Location = new Point(71, 149);
            lblTipoFalla.Name = "lblTipoFalla";
            lblTipoFalla.Size = new Size(97, 19);
            lblTipoFalla.TabIndex = 2;
            lblTipoFalla.Text = "Tipo de falla:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUbicacion.Location = new Point(90, 100);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(79, 19);
            lblUbicacion.TabIndex = 1;
            lblUbicacion.Text = "Ubicación:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.Location = new Point(141, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(26, 19);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // grpBotones
            // 
            grpBotones.Controls.Add(btnLimpiar);
            grpBotones.Controls.Add(btnContar);
            grpBotones.Controls.Add(btnCerrar);
            grpBotones.Controls.Add(btnEliminar);
            grpBotones.Controls.Add(btnBuscar);
            grpBotones.Controls.Add(btnListar);
            grpBotones.Controls.Add(btnRegistrar);
            grpBotones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpBotones.Location = new Point(12, 331);
            grpBotones.Name = "grpBotones";
            grpBotones.Size = new Size(475, 101);
            grpBotones.TabIndex = 1;
            grpBotones.TabStop = false;
            grpBotones.Text = "Sección 2 - Botones de Acción";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 8.5F);
            btnLimpiar.Location = new Point(408, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(61, 56);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnContar
            // 
            btnContar.Font = new Font("Segoe UI", 8.5F);
            btnContar.Location = new Point(341, 28);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(61, 56);
            btnContar.TabIndex = 5;
            btnContar.Text = "Contar Activos";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 8.5F);
            btnCerrar.Location = new Point(274, 28);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(61, 56);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar Ticket";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 8.5F);
            btnEliminar.Location = new Point(207, 28);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(61, 56);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Ticket";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 8.5F);
            btnBuscar.Location = new Point(140, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(61, 56);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Ticket";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 8.5F);
            btnListar.Location = new Point(71, 28);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(63, 56);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar Todos";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 8.5F);
            btnRegistrar.Location = new Point(6, 28);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(61, 56);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar Ticket";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // grpOperacionesId
            // 
            grpOperacionesId.Controls.Add(lblAclaracionId);
            grpOperacionesId.Controls.Add(txtIdBusqueda);
            grpOperacionesId.Controls.Add(lblIdBusqueda);
            grpOperacionesId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpOperacionesId.Location = new Point(493, 12);
            grpOperacionesId.Name = "grpOperacionesId";
            grpOperacionesId.Size = new Size(303, 102);
            grpOperacionesId.TabIndex = 3;
            grpOperacionesId.TabStop = false;
            grpOperacionesId.Text = "Sección 3 - Operaciones por Id";
            // 
            // lblAclaracionId
            // 
            lblAclaracionId.AutoSize = true;
            lblAclaracionId.Font = new Font("Segoe UI", 7.5F);
            lblAclaracionId.Location = new Point(6, 72);
            lblAclaracionId.Name = "lblAclaracionId";
            lblAclaracionId.Size = new Size(214, 12);
            lblAclaracionId.TabIndex = 7;
            lblAclaracionId.Text = "Usado por los botones Buscar, Cerrar y Eliminar.";
            // 
            // txtIdBusqueda
            // 
            txtIdBusqueda.Font = new Font("Segoe UI", 9.5F);
            txtIdBusqueda.Location = new Point(184, 30);
            txtIdBusqueda.Name = "txtIdBusqueda";
            txtIdBusqueda.Size = new Size(113, 24);
            txtIdBusqueda.TabIndex = 6;
            // 
            // lblIdBusqueda
            // 
            lblIdBusqueda.AutoSize = true;
            lblIdBusqueda.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblIdBusqueda.Location = new Point(6, 36);
            lblIdBusqueda.Name = "lblIdBusqueda";
            lblIdBusqueda.Size = new Size(178, 17);
            lblIdBusqueda.TabIndex = 1;
            lblIdBusqueda.Text = "Id a buscar/eliminar/cerrar:";
            // 
            // grpResultados
            // 
            grpResultados.Controls.Add(txtResultado);
            grpResultados.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpResultados.Location = new Point(493, 120);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(303, 312);
            grpResultados.TabIndex = 4;
            grpResultados.TabStop = false;
            grpResultados.Text = "Sección 4 - Salida de Resultados";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ControlLightLight;
            txtResultado.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(6, 35);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(291, 260);
            txtResultado.TabIndex = 6;
            // 
            // FormMesaTech
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpResultados);
            Controls.Add(grpOperacionesId);
            Controls.Add(grpBotones);
            Controls.Add(grpDatosTicket);
            Name = "FormMesaTech";
            Text = "Form1";
            grpDatosTicket.ResumeLayout(false);
            grpDatosTicket.PerformLayout();
            grpBotones.ResumeLayout(false);
            grpOperacionesId.ResumeLayout(false);
            grpOperacionesId.PerformLayout();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosTicket;
        private TextBox txtDescripcion;
        private TextBox txtTipoFalla;
        private TextBox txtUbicacion;
        private TextBox txtId;
        private Label lblPrioridad;
        private Label lblDescripcion;
        private Label lblTipoFalla;
        private Label lblUbicacion;
        private Label lblId;
        private ComboBox cmbPrioridad;
        private GroupBox grpBotones;
        private Button btnRegistrar;
        private Button btnContar;
        private Button btnCerrar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnListar;
        private Button btnLimpiar;
        private GroupBox grpOperacionesId;
        private Label lblIdBusqueda;
        private TextBox txtIdBusqueda;
        private Label lblAclaracionId;
        private GroupBox grpResultados;
        private TextBox txtResultado;
    }
}
