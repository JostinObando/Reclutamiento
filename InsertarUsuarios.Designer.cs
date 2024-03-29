namespace Reclutamiento
{
    partial class InsertarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnSalir = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblCorreo = new Label();
            lbltelefono = new Label();
            lblExperincia = new Label();
            lbleducacion = new Label();
            lblCursos = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(236, 413);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(474, 413);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ImageAlign = ContentAlignment.MiddleRight;
            lblNombre.Location = new Point(153, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(425, 71);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(96, 159);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(149, 25);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "correoElectronico";
            lblCorreo.Click += lblCorreo_Click;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(133, 228);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(78, 25);
            lbltelefono.TabIndex = 5;
            lbltelefono.Text = "telefono";
            // 
            // lblExperincia
            // 
            lblExperincia.AutoSize = true;
            lblExperincia.Location = new Point(91, 304);
            lblExperincia.Name = "lblExperincia";
            lblExperincia.Size = new Size(154, 25);
            lblExperincia.TabIndex = 6;
            lblExperincia.Text = "Experencia laboral";
            // 
            // lbleducacion
            // 
            lbleducacion.AutoSize = true;
            lbleducacion.Location = new Point(425, 228);
            lbleducacion.Name = "lbleducacion";
            lbleducacion.Size = new Size(92, 25);
            lbleducacion.TabIndex = 7;
            lbleducacion.Text = "Educacion";
            // 
            // lblCursos
            // 
            lblCursos.AutoSize = true;
            lblCursos.Location = new Point(415, 153);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(135, 25);
            lblCursos.TabIndex = 8;
            lblCursos.Text = "Cursos Idiomas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(535, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(249, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(545, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(249, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(545, 228);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(249, 304);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 15;
            // 
            // InsertarUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(989, 553);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblCursos);
            Controls.Add(lbleducacion);
            Controls.Add(lblExperincia);
            Controls.Add(lbltelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Name = "InsertarUsuarios";
            Text = "InsertarUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnSalir;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblCorreo;
        private Label lbltelefono;
        private Label lblExperincia;
        private Label lbleducacion;
        private Label lblCursos;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}