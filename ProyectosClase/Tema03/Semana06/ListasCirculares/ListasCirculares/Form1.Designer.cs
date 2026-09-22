namespace ListasCirculares
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
            label2 = new Label();
            txtValor = new TextBox();
            lstVisualizacion = new ListBox();
            btnInsertarInicio = new Button();
            btnInsertarFinal = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(349, 26);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Listas Circulares";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 64);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(154, 61);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 2;
            // 
            // lstVisualizacion
            // 
            lstVisualizacion.FormattingEnabled = true;
            lstVisualizacion.ItemHeight = 15;
            lstVisualizacion.Location = new Point(102, 106);
            lstVisualizacion.Name = "lstVisualizacion";
            lstVisualizacion.Size = new Size(161, 289);
            lstVisualizacion.TabIndex = 3;
            // 
            // btnInsertarInicio
            // 
            btnInsertarInicio.Location = new Point(328, 106);
            btnInsertarInicio.Name = "btnInsertarInicio";
            btnInsertarInicio.Size = new Size(104, 50);
            btnInsertarInicio.TabIndex = 4;
            btnInsertarInicio.Text = "Insertar Inicio";
            btnInsertarInicio.UseVisualStyleBackColor = true;
            btnInsertarInicio.Click += btnInsertarInicio_Click;
            // 
            // btnInsertarFinal
            // 
            btnInsertarFinal.Location = new Point(328, 162);
            btnInsertarFinal.Name = "btnInsertarFinal";
            btnInsertarFinal.Size = new Size(104, 50);
            btnInsertarFinal.TabIndex = 5;
            btnInsertarFinal.Text = "Insertar Final";
            btnInsertarFinal.UseVisualStyleBackColor = true;
            btnInsertarFinal.Click += btnInsertarFinal_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(328, 223);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 50);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(328, 289);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 50);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(328, 345);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(104, 50);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertarFinal);
            Controls.Add(btnInsertarInicio);
            Controls.Add(lstVisualizacion);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private ListBox lstVisualizacion;
        private Button btnInsertarInicio;
        private Button btnInsertarFinal;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
    }
}
