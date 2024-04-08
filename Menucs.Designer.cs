namespace Reclutamiento
{
    partial class Menucs
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
            menuStrip1 = new MenuStrip();
            iniciarProcesoDeSelecciónToolStripMenuItem = new ToolStripMenuItem();
            agregarCandidatoToolStripMenuItem = new ToolStripMenuItem();
            actualizarCandidatoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarProcesoDeSelecciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iniciarProcesoDeSelecciónToolStripMenuItem
            // 
            iniciarProcesoDeSelecciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarCandidatoToolStripMenuItem, actualizarCandidatoToolStripMenuItem });
            iniciarProcesoDeSelecciónToolStripMenuItem.Name = "iniciarProcesoDeSelecciónToolStripMenuItem";
            iniciarProcesoDeSelecciónToolStripMenuItem.Size = new Size(244, 29);
            iniciarProcesoDeSelecciónToolStripMenuItem.Text = "Iniciar proceso de selección";
            // 
            // agregarCandidatoToolStripMenuItem
            // 
            agregarCandidatoToolStripMenuItem.Name = "agregarCandidatoToolStripMenuItem";
            agregarCandidatoToolStripMenuItem.Size = new Size(277, 34);
            agregarCandidatoToolStripMenuItem.Text = "Agregar Candidato";
            agregarCandidatoToolStripMenuItem.Click += agregarCandidatoToolStripMenuItem_Click;
            // 
            // actualizarCandidatoToolStripMenuItem
            // 
            actualizarCandidatoToolStripMenuItem.Name = "actualizarCandidatoToolStripMenuItem";
            actualizarCandidatoToolStripMenuItem.Size = new Size(277, 34);
            actualizarCandidatoToolStripMenuItem.Text = "Actualizar Candidato";
            actualizarCandidatoToolStripMenuItem.Click += actualizarCandidatoToolStripMenuItem_Click;
            // 
            // Menucs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Menucs";
            Text = "Menucs";
            Load += Menucs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iniciarProcesoDeSelecciónToolStripMenuItem;
        private ToolStripMenuItem agregarCandidatoToolStripMenuItem;
        private ToolStripMenuItem actualizarCandidatoToolStripMenuItem;
    }
}