namespace Semana01
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
            txtActual = new TextBox();
            btnInsertar = new Button();
            btnVer = new Button();
            lstLista = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            btnModificar = new Button();
            txtNuevo = new TextBox();
            label6 = new Label();
            txtAnterior = new TextBox();
            groupBox4 = new GroupBox();
            btnEliminar = new Button();
            txtEliminar = new TextBox();
            label4 = new Label();
            btnOrdenar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 19);
            label1.Name = "label1";
            label1.Size = new Size(272, 25);
            label1.TabIndex = 0;
            label1.Text = "LISTAS ENLAZADAS SIMPLES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 26);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor Actual";
            // 
            // txtActual
            // 
            txtActual.Location = new Point(125, 23);
            txtActual.Name = "txtActual";
            txtActual.Size = new Size(114, 23);
            txtActual.TabIndex = 2;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(74, 68);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(108, 37);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar Nodo";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(315, 78);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(120, 38);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver Lista Enlazada";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(315, 175);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(120, 214);
            lstLista.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInsertar);
            groupBox1.Controls.Add(txtActual);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(20, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(21, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 122);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(73, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 39);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(124, 28);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(114, 23);
            txtBuscar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 33);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Buscar Valor";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Controls.Add(txtNuevo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtAnterior);
            groupBox3.Location = new Point(468, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(311, 151);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modificar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 42);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 5;
            label5.Text = "Valor Modificar";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(107, 117);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 27);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar Valor";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(120, 77);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(164, 23);
            txtNuevo.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 81);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 2;
            label6.Text = "Valor Nuevo";
            // 
            // txtAnterior
            // 
            txtAnterior.Location = new Point(120, 39);
            txtAnterior.Name = "txtAnterior";
            txtAnterior.Size = new Size(164, 23);
            txtAnterior.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnEliminar);
            groupBox4.Controls.Add(txtEliminar);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(468, 247);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(311, 115);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(107, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 27);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(120, 22);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(164, 23);
            txtEliminar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 26);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 6;
            label4.Text = "Valor Eliminar:";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(315, 127);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(120, 37);
            btnOrdenar.TabIndex = 10;
            btnOrdenar.Text = "Ordenar Lista";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 431);
            Controls.Add(btnOrdenar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstLista);
            Controls.Add(btnVer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Listas Enlazadas Simples";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtActual;
        private Button btnInsertar;
        private Button btnVer;
        private ListBox lstLista;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private GroupBox groupBox3;
        private Button btnModificar;
        private TextBox txtNuevo;
        private Label label6;
        private TextBox txtAnterior;
        private Label label5;
        private GroupBox groupBox4;
        private Label label4;
        private Button btnEliminar;
        private TextBox txtEliminar;
        private Button btnOrdenar;
    }
}
