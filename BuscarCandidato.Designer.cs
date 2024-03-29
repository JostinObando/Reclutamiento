namespace Reclutamiento
{
    partial class BuscarCandidato
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
            btnConsultar = new Button();
            btnSalir = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblCedula = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridViewCandidatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidatos).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(229, 281);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(419, 281);
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
            lblNombre.Location = new Point(155, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(395, 91);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(155, 177);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(66, 25);
            lblCedula.TabIndex = 4;
            lblCedula.Text = "Cedula";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(479, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // dataGridViewCandidatos
            // 
            dataGridViewCandidatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCandidatos.Location = new Point(76, 384);
            dataGridViewCandidatos.Name = "dataGridViewCandidatos";
            dataGridViewCandidatos.RowHeadersWidth = 62;
            dataGridViewCandidatos.RowTemplate.Height = 33;
            dataGridViewCandidatos.Size = new Size(657, 309);
            dataGridViewCandidatos.TabIndex = 8;
            // 
            // BuscarCandidato
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 835);
            Controls.Add(dataGridViewCandidatos);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblCedula);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Name = "BuscarCandidato";
            Text = "BuscarCandidato";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private Button btnSalir;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblCedula;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridViewCandidatos;
    }
}