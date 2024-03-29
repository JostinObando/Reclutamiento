namespace Reclutamiento
{
    partial class Elminar
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
            btnEliminar = new Button();
            btnSalir = new Button();
            lblIdUusuario = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(219, 258);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(457, 258);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIdUusuario
            // 
            lblIdUusuario.AutoSize = true;
            lblIdUusuario.Location = new Point(270, 111);
            lblIdUusuario.Name = "lblIdUusuario";
            lblIdUusuario.Size = new Size(95, 25);
            lblIdUusuario.TabIndex = 3;
            lblIdUusuario.Text = "ID Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // Elminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(lblIdUusuario);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Name = "Elminar";
            Text = "Elminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnSalir;
        private Label lblIdUusuario;
        private TextBox textBox2;
    }
}