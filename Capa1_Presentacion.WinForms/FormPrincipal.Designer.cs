
namespace Capa1_Presentacion.WinForms
{
    partial class FormPrincipal
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDeBienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorBienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.movimientoDeBienToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorBienToolStripMenuItem,
            this.mantenedorEmpleadoToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // movimientoDeBienToolStripMenuItem
            // 
            this.movimientoDeBienToolStripMenuItem.Name = "movimientoDeBienToolStripMenuItem";
            this.movimientoDeBienToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.movimientoDeBienToolStripMenuItem.Text = "Movimiento de Bien";
            this.movimientoDeBienToolStripMenuItem.Click += new System.EventHandler(this.movimientoDeBienToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // mantenedorBienToolStripMenuItem
            // 
            this.mantenedorBienToolStripMenuItem.Name = "mantenedorBienToolStripMenuItem";
            this.mantenedorBienToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mantenedorBienToolStripMenuItem.Text = "Mantenedor Bien";
            // 
            // mantenedorEmpleadoToolStripMenuItem
            // 
            this.mantenedorEmpleadoToolStripMenuItem.Name = "mantenedorEmpleadoToolStripMenuItem";
            this.mantenedorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mantenedorEmpleadoToolStripMenuItem.Text = "Mantenedor Empleado";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorBienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoDeBienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}