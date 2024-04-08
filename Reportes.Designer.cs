namespace Reclutamiento
{
    partial class Reportes
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
            dataGridViewReportes = new DataGridView();
            txTid = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            btnSalir = new Button();
            btnReporte = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            dataGridViewReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReportes.Location = new Point(-1, 319);
            dataGridViewReportes.Name = "dataGridViewReportes";
            dataGridViewReportes.RowHeadersWidth = 62;
            dataGridViewReportes.RowTemplate.Height = 33;
            dataGridViewReportes.Size = new Size(1422, 437);
            dataGridViewReportes.TabIndex = 16;
            // 
            // txTid
            // 
            txTid.Location = new Point(559, 148);
            txTid.Name = "txTid";
            txTid.Size = new Size(150, 31);
            txTid.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(692, 59);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(407, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(597, 59);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(323, 62);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(635, 217);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(357, 226);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(191, 34);
            btnReporte.TabIndex = 9;
            btnReporte.Text = "Hacer Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 148);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 17;
            label1.Text = "Id Candidato";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1419, 829);
            Controls.Add(label1);
            Controls.Add(dataGridViewReportes);
            Controls.Add(txTid);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReportes;
        private TextBox txTid;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnSalir;
        private Button btnReporte;
        private Label label1;
    }
}