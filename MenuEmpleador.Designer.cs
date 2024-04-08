namespace Reclutamiento
{
    partial class MenuEmpleador
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
            accionesEmpeladorToolStripMenuItem = new ToolStripMenuItem();
            buscarUsuairoToolStripMenuItem = new ToolStripMenuItem();
            hacerReporteToolStripMenuItem = new ToolStripMenuItem();
            actualizarInformacionToolStripMenuItem = new ToolStripMenuItem();
            borrarInformacionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesEmpeladorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesEmpeladorToolStripMenuItem
            // 
            accionesEmpeladorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarUsuairoToolStripMenuItem, hacerReporteToolStripMenuItem, actualizarInformacionToolStripMenuItem, borrarInformacionToolStripMenuItem });
            accionesEmpeladorToolStripMenuItem.Name = "accionesEmpeladorToolStripMenuItem";
            accionesEmpeladorToolStripMenuItem.Size = new Size(189, 29);
            accionesEmpeladorToolStripMenuItem.Text = "Acciones empelador";
            // 
            // buscarUsuairoToolStripMenuItem
            // 
            buscarUsuairoToolStripMenuItem.Name = "buscarUsuairoToolStripMenuItem";
            buscarUsuairoToolStripMenuItem.Size = new Size(290, 34);
            buscarUsuairoToolStripMenuItem.Text = "Buscar usuairo";
            buscarUsuairoToolStripMenuItem.Click += buscarUsuairoToolStripMenuItem_Click;
            // 
            // hacerReporteToolStripMenuItem
            // 
            hacerReporteToolStripMenuItem.Name = "hacerReporteToolStripMenuItem";
            hacerReporteToolStripMenuItem.Size = new Size(290, 34);
            hacerReporteToolStripMenuItem.Text = "Hacer reporte";
            hacerReporteToolStripMenuItem.Click += hacerReporteToolStripMenuItem_Click;
            // 
            // actualizarInformacionToolStripMenuItem
            // 
            actualizarInformacionToolStripMenuItem.Name = "actualizarInformacionToolStripMenuItem";
            actualizarInformacionToolStripMenuItem.Size = new Size(290, 34);
            actualizarInformacionToolStripMenuItem.Text = "Actualizar informacion";
            actualizarInformacionToolStripMenuItem.Click += actualizarInformacionToolStripMenuItem_Click;
            // 
            // borrarInformacionToolStripMenuItem
            // 
            borrarInformacionToolStripMenuItem.Name = "borrarInformacionToolStripMenuItem";
            borrarInformacionToolStripMenuItem.Size = new Size(290, 34);
            borrarInformacionToolStripMenuItem.Text = "Borrar informacion";
            borrarInformacionToolStripMenuItem.Click += borrarInformacionToolStripMenuItem_Click;
            // 
            // MenuEmpleador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuEmpleador";
            Text = "MenuEmpleador";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accionesEmpeladorToolStripMenuItem;
        private ToolStripMenuItem buscarUsuairoToolStripMenuItem;
        private ToolStripMenuItem hacerReporteToolStripMenuItem;
        private ToolStripMenuItem actualizarInformacionToolStripMenuItem;
        private ToolStripMenuItem borrarInformacionToolStripMenuItem;
    }
}