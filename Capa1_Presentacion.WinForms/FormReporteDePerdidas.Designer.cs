
namespace Capa1_Presentacion.WinForms
{
    partial class FormReporteDePerdidas
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
            this.gpbFiltroReporte = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReportePerdida = new System.Windows.Forms.DataGridView();
            this.btnCalcularPerdida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPromedioPerdida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadBienes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.gpbFiltroReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePerdida)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltroReporte
            // 
            this.gpbFiltroReporte.Controls.Add(this.btnBuscar);
            this.gpbFiltroReporte.Controls.Add(this.cboArea);
            this.gpbFiltroReporte.Controls.Add(this.label3);
            this.gpbFiltroReporte.Controls.Add(this.label2);
            this.gpbFiltroReporte.Controls.Add(this.dtpFechaFinal);
            this.gpbFiltroReporte.Controls.Add(this.dtpFechaInicial);
            this.gpbFiltroReporte.Controls.Add(this.label1);
            this.gpbFiltroReporte.Location = new System.Drawing.Point(25, 89);
            this.gpbFiltroReporte.Name = "gpbFiltroReporte";
            this.gpbFiltroReporte.Size = new System.Drawing.Size(746, 81);
            this.gpbFiltroReporte.TabIndex = 0;
            this.gpbFiltroReporte.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(665, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(463, 45);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(174, 21);
            this.cboArea.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AREA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA FINAL";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(240, 46);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(6, 46);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA INICIAL";
            // 
            // dgvReportePerdida
            // 
            this.dgvReportePerdida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePerdida.Location = new System.Drawing.Point(31, 188);
            this.dgvReportePerdida.Name = "dgvReportePerdida";
            this.dgvReportePerdida.Size = new System.Drawing.Size(740, 193);
            this.dgvReportePerdida.TabIndex = 1;
            // 
            // btnCalcularPerdida
            // 
            this.btnCalcularPerdida.Location = new System.Drawing.Point(35, 400);
            this.btnCalcularPerdida.Name = "btnCalcularPerdida";
            this.btnCalcularPerdida.Size = new System.Drawing.Size(137, 39);
            this.btnCalcularPerdida.TabIndex = 2;
            this.btnCalcularPerdida.Text = "CALCULAR PERDIDAS";
            this.btnCalcularPerdida.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PROMEDIO EN PERDIDAS";
            // 
            // txtPromedioPerdida
            // 
            this.txtPromedioPerdida.Location = new System.Drawing.Point(341, 429);
            this.txtPromedioPerdida.Name = "txtPromedioPerdida";
            this.txtPromedioPerdida.ReadOnly = true;
            this.txtPromedioPerdida.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioPerdida.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CANTIDAD DE BIENES";
            // 
            // txtCantidadBienes
            // 
            this.txtCantidadBienes.Location = new System.Drawing.Point(500, 429);
            this.txtCantidadBienes.Name = "txtCantidadBienes";
            this.txtCantidadBienes.ReadOnly = true;
            this.txtCantidadBienes.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadBienes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "MONTO TOTAL";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(196, 429);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 4;
            // 
            // FormReporteDePerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 478);
            this.Controls.Add(this.txtCantidadBienes);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtPromedioPerdida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcularPerdida);
            this.Controls.Add(this.dgvReportePerdida);
            this.Controls.Add(this.gpbFiltroReporte);
            this.Name = "FormReporteDePerdidas";
            this.Text = "FormReporteDePerdidas";
            this.gpbFiltroReporte.ResumeLayout(false);
            this.gpbFiltroReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePerdida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFiltroReporte;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReportePerdida;
        private System.Windows.Forms.Button btnCalcularPerdida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPromedioPerdida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadBienes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Button btnBuscar;
    }
}