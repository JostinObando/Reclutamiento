namespace Reclutamiento
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
            btnIngresar = new Button();
            BtnCancelar = new Button();
            lblUusuario = new Label();
            lblContrasenia = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(185, 269);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(369, 269);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 34);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // lblUusuario
            // 
            lblUusuario.AutoSize = true;
            lblUusuario.Location = new Point(203, 145);
            lblUusuario.Name = "lblUusuario";
            lblUusuario.Size = new Size(72, 25);
            lblUusuario.TabIndex = 3;
            lblUusuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(196, 215);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(101, 25);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(369, 145);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 5;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(369, 209);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(150, 31);
            txtContrasenia.TabIndex = 6;
            txtContrasenia.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUusuario);
            Controls.Add(BtnCancelar);
            Controls.Add(btnIngresar);
            Name = "Form1";
            Text = "Inicio Sesion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button BtnCancelar;
        private Label lblUusuario;
        private Label lblContrasenia;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
    }
}