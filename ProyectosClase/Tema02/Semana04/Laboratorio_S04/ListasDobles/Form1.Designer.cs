namespace ListasDobles
{
    partial class Form1
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
            label1 = new Label();
            btnInsertar = new Button();
            btnFinal = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lstVisualizacion = new ListBox();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(348, 28);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 0;
            label1.Text = "Listas Dobles";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(445, 126);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(119, 53);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar Inicio";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnFinal
            // 
            btnFinal.Location = new Point(445, 185);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(119, 53);
            btnFinal.TabIndex = 4;
            btnFinal.Text = "Insertar Final";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(445, 244);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 53);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(56, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 7;
            label2.Text = "Valor";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(445, 303);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 53);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11F);
            btnLimpiar.Location = new Point(445, 362);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 53);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lstVisualizacion
            // 
            lstVisualizacion.FormattingEnabled = true;
            lstVisualizacion.ItemHeight = 15;
            lstVisualizacion.Location = new Point(146, 126);
            lstVisualizacion.Name = "lstVisualizacion";
            lstVisualizacion.Size = new Size(137, 289);
            lstVisualizacion.TabIndex = 11;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(146, 80);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(137, 23);
            txtValor.TabIndex = 12;
            txtValor.Click += txtValor_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValor);
            Controls.Add(lstVisualizacion);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnFinal);
            Controls.Add(btnInsertar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;        
        private Button btnInsertar;
        private Button btnFinal;
        private Button btnEliminar;
        private Label label2;
        private Button btnBuscar;
        private Button btnLimpiar;       
        private ListBox lstVisualizacion;
        private TextBox txtValor;
    }
}
