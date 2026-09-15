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
            btnRecorridoInverso = new Button();
            groupBox1 = new GroupBox();
            txtPosicion = new TextBox();
            btnEliminarPos = new Button();
            btnInsertarPos = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(261, 28);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 0;
            label1.Text = "Listas Dobles";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(333, 126);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(119, 53);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar Inicio";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnFinal
            // 
            btnFinal.Location = new Point(333, 185);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(119, 53);
            btnFinal.TabIndex = 4;
            btnFinal.Text = "Insertar Final";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(333, 244);
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
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(94, 82);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 7;
            label2.Text = "Valor:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(333, 303);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 53);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F);
            btnLimpiar.Location = new Point(333, 362);
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
            // btnRecorridoInverso
            // 
            btnRecorridoInverso.Location = new Point(504, 126);
            btnRecorridoInverso.Name = "btnRecorridoInverso";
            btnRecorridoInverso.Size = new Size(129, 53);
            btnRecorridoInverso.TabIndex = 13;
            btnRecorridoInverso.Text = "Recorrido Inverso";
            btnRecorridoInverso.UseVisualStyleBackColor = true;
            btnRecorridoInverso.Click += btnRecorridoInverso_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPosicion);
            groupBox1.Controls.Add(btnEliminarPos);
            groupBox1.Controls.Add(btnInsertarPos);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(504, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 223);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(15, 52);
            txtPosicion.Multiline = true;
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(99, 26);
            txtPosicion.TabIndex = 13;
            // 
            // btnEliminarPos
            // 
            btnEliminarPos.Location = new Point(15, 152);
            btnEliminarPos.Name = "btnEliminarPos";
            btnEliminarPos.Size = new Size(99, 40);
            btnEliminarPos.TabIndex = 2;
            btnEliminarPos.Text = "Eliminar";
            btnEliminarPos.UseVisualStyleBackColor = true;
            btnEliminarPos.Click += btnEliminarPos_Click;
            // 
            // btnInsertarPos
            // 
            btnInsertarPos.Location = new Point(15, 96);
            btnInsertarPos.Name = "btnInsertarPos";
            btnInsertarPos.Size = new Size(99, 39);
            btnInsertarPos.TabIndex = 1;
            btnInsertarPos.Text = "Insertar";
            btnInsertarPos.UseVisualStyleBackColor = true;
            btnInsertarPos.Click += btnInsertarPos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(36, 31);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Posición";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnRecorridoInverso);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnRecorridoInverso;
        private Label label3;
        private Button btnEliminarPos;
        private Button btnInsertarPos;
        private TextBox txtPosicion;
        protected GroupBox groupBox1;
    }
}
