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
            busToolStripMenuItem = new ToolStripMenuItem();
            agregarCandidatoToolStripMenuItem = new ToolStripMenuItem();
            eliminarCandidatoToolStripMenuItem = new ToolStripMenuItem();
            recomendarCandidatoToolStripMenuItem = new ToolStripMenuItem();
            verCandidatosRecomendadosToolStripMenuItem = new ToolStripMenuItem();
            administrarCurrículosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarProcesoDeSelecciónToolStripMenuItem, verCandidatosRecomendadosToolStripMenuItem, administrarCurrículosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iniciarProcesoDeSelecciónToolStripMenuItem
            // 
            iniciarProcesoDeSelecciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { busToolStripMenuItem, agregarCandidatoToolStripMenuItem, eliminarCandidatoToolStripMenuItem, recomendarCandidatoToolStripMenuItem });
            iniciarProcesoDeSelecciónToolStripMenuItem.Name = "iniciarProcesoDeSelecciónToolStripMenuItem";
            iniciarProcesoDeSelecciónToolStripMenuItem.Size = new Size(244, 29);
            iniciarProcesoDeSelecciónToolStripMenuItem.Text = "Iniciar proceso de selección";
            // 
            // busToolStripMenuItem
            // 
            busToolStripMenuItem.Name = "busToolStripMenuItem";
            busToolStripMenuItem.Size = new Size(300, 34);
            busToolStripMenuItem.Text = "Buscar Candidatos";
            busToolStripMenuItem.Click += busToolStripMenuItem_Click;
            // 
            // agregarCandidatoToolStripMenuItem
            // 
            agregarCandidatoToolStripMenuItem.Name = "agregarCandidatoToolStripMenuItem";
            agregarCandidatoToolStripMenuItem.Size = new Size(300, 34);
            agregarCandidatoToolStripMenuItem.Text = "Agregar Candidato";
            agregarCandidatoToolStripMenuItem.Click += agregarCandidatoToolStripMenuItem_Click;
            // 
            // eliminarCandidatoToolStripMenuItem
            // 
            eliminarCandidatoToolStripMenuItem.Name = "eliminarCandidatoToolStripMenuItem";
            eliminarCandidatoToolStripMenuItem.Size = new Size(300, 34);
            eliminarCandidatoToolStripMenuItem.Text = "Eliminar Candidato";
            eliminarCandidatoToolStripMenuItem.Click += eliminarCandidatoToolStripMenuItem_Click;
            // 
            // recomendarCandidatoToolStripMenuItem
            // 
            recomendarCandidatoToolStripMenuItem.Name = "recomendarCandidatoToolStripMenuItem";
            recomendarCandidatoToolStripMenuItem.Size = new Size(300, 34);
            recomendarCandidatoToolStripMenuItem.Text = "Recomendar Candidato";
            // 
            // verCandidatosRecomendadosToolStripMenuItem
            // 
            verCandidatosRecomendadosToolStripMenuItem.Name = "verCandidatosRecomendadosToolStripMenuItem";
            verCandidatosRecomendadosToolStripMenuItem.Size = new Size(269, 29);
            verCandidatosRecomendadosToolStripMenuItem.Text = "Ver candidatos recomendados";
            // 
            // administrarCurrículosToolStripMenuItem
            // 
            administrarCurrículosToolStripMenuItem.Name = "administrarCurrículosToolStripMenuItem";
            administrarCurrículosToolStripMenuItem.Size = new Size(200, 29);
            administrarCurrículosToolStripMenuItem.Text = "Administrar currículos";
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iniciarProcesoDeSelecciónToolStripMenuItem;
        private ToolStripMenuItem busToolStripMenuItem;
        private ToolStripMenuItem agregarCandidatoToolStripMenuItem;
        private ToolStripMenuItem eliminarCandidatoToolStripMenuItem;
        private ToolStripMenuItem recomendarCandidatoToolStripMenuItem;
        private ToolStripMenuItem verCandidatosRecomendadosToolStripMenuItem;
        private ToolStripMenuItem administrarCurrículosToolStripMenuItem;
    }
}