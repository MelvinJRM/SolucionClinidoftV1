
namespace Capa1_Presentacion.WinForms
{
    partial class FormMovimientoDeBien
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
            this.grpEmpleadoOrigen = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmpOri = new System.Windows.Forms.Button();
            this.txtAreEmpOri = new System.Windows.Forms.TextBox();
            this.txtNomEmpOri = new System.Windows.Forms.TextBox();
            this.txtDniEmpOri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEmpleadoDestino = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmpDes = new System.Windows.Forms.Button();
            this.txtAreEmpDes = new System.Windows.Forms.TextBox();
            this.txtNomEmpDes = new System.Windows.Forms.TextBox();
            this.txtDniEmpDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCodigoFecha = new System.Windows.Forms.GroupBox();
            this.txtCodigoMovimiento = new System.Windows.Forms.TextBox();
            this.dtpFechaDeMovimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.cboMotivo = new System.Windows.Forms.ComboBox();
            this.btnAgregarUno = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.dgvEmpOrigen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpDestino = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpEmpleadoOrigen.SuspendLayout();
            this.grpEmpleadoDestino.SuspendLayout();
            this.grpCodigoFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmpleadoOrigen
            // 
            this.grpEmpleadoOrigen.Controls.Add(this.btnBuscarEmpOri);
            this.grpEmpleadoOrigen.Controls.Add(this.txtAreEmpOri);
            this.grpEmpleadoOrigen.Controls.Add(this.txtNomEmpOri);
            this.grpEmpleadoOrigen.Controls.Add(this.txtDniEmpOri);
            this.grpEmpleadoOrigen.Controls.Add(this.label2);
            this.grpEmpleadoOrigen.Controls.Add(this.label3);
            this.grpEmpleadoOrigen.Controls.Add(this.label1);
            this.grpEmpleadoOrigen.Location = new System.Drawing.Point(14, 26);
            this.grpEmpleadoOrigen.Name = "grpEmpleadoOrigen";
            this.grpEmpleadoOrigen.Size = new System.Drawing.Size(502, 81);
            this.grpEmpleadoOrigen.TabIndex = 0;
            this.grpEmpleadoOrigen.TabStop = false;
            this.grpEmpleadoOrigen.Text = "DATOS EMPLEADO DE ORIGEN";
            // 
            // btnBuscarEmpOri
            // 
            this.btnBuscarEmpOri.Location = new System.Drawing.Point(421, 44);
            this.btnBuscarEmpOri.Name = "btnBuscarEmpOri";
            this.btnBuscarEmpOri.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmpOri.TabIndex = 6;
            this.btnBuscarEmpOri.Text = "BUSCAR";
            this.btnBuscarEmpOri.UseVisualStyleBackColor = true;
            this.btnBuscarEmpOri.Click += new System.EventHandler(this.btnBuscarEmpOri_Click);
            // 
            // txtAreEmpOri
            // 
            this.txtAreEmpOri.Location = new System.Drawing.Point(287, 47);
            this.txtAreEmpOri.Name = "txtAreEmpOri";
            this.txtAreEmpOri.ReadOnly = true;
            this.txtAreEmpOri.Size = new System.Drawing.Size(112, 20);
            this.txtAreEmpOri.TabIndex = 5;
            // 
            // txtNomEmpOri
            // 
            this.txtNomEmpOri.Location = new System.Drawing.Point(87, 47);
            this.txtNomEmpOri.Name = "txtNomEmpOri";
            this.txtNomEmpOri.ReadOnly = true;
            this.txtNomEmpOri.Size = new System.Drawing.Size(182, 20);
            this.txtNomEmpOri.TabIndex = 4;
            // 
            // txtDniEmpOri
            // 
            this.txtDniEmpOri.Location = new System.Drawing.Point(6, 48);
            this.txtDniEmpOri.Name = "txtDniEmpOri";
            this.txtDniEmpOri.Size = new System.Drawing.Size(63, 20);
            this.txtDniEmpOri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRES Y APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AREA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // grpEmpleadoDestino
            // 
            this.grpEmpleadoDestino.Controls.Add(this.btnBuscarEmpDes);
            this.grpEmpleadoDestino.Controls.Add(this.txtAreEmpDes);
            this.grpEmpleadoDestino.Controls.Add(this.txtNomEmpDes);
            this.grpEmpleadoDestino.Controls.Add(this.txtDniEmpDes);
            this.grpEmpleadoDestino.Controls.Add(this.label4);
            this.grpEmpleadoDestino.Controls.Add(this.label5);
            this.grpEmpleadoDestino.Controls.Add(this.label6);
            this.grpEmpleadoDestino.Location = new System.Drawing.Point(14, 114);
            this.grpEmpleadoDestino.Name = "grpEmpleadoDestino";
            this.grpEmpleadoDestino.Size = new System.Drawing.Size(502, 86);
            this.grpEmpleadoDestino.TabIndex = 1;
            this.grpEmpleadoDestino.TabStop = false;
            this.grpEmpleadoDestino.Text = "DATOS EMPLEADO DE DESTINO";
            // 
            // btnBuscarEmpDes
            // 
            this.btnBuscarEmpDes.Location = new System.Drawing.Point(421, 51);
            this.btnBuscarEmpDes.Name = "btnBuscarEmpDes";
            this.btnBuscarEmpDes.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEmpDes.TabIndex = 6;
            this.btnBuscarEmpDes.Text = "BUSCAR";
            this.btnBuscarEmpDes.UseVisualStyleBackColor = true;
            this.btnBuscarEmpDes.Click += new System.EventHandler(this.btnBuscarEmpDes_Click);
            // 
            // txtAreEmpDes
            // 
            this.txtAreEmpDes.Location = new System.Drawing.Point(287, 54);
            this.txtAreEmpDes.Name = "txtAreEmpDes";
            this.txtAreEmpDes.ReadOnly = true;
            this.txtAreEmpDes.Size = new System.Drawing.Size(112, 20);
            this.txtAreEmpDes.TabIndex = 5;
            // 
            // txtNomEmpDes
            // 
            this.txtNomEmpDes.Location = new System.Drawing.Point(87, 54);
            this.txtNomEmpDes.Name = "txtNomEmpDes";
            this.txtNomEmpDes.ReadOnly = true;
            this.txtNomEmpDes.Size = new System.Drawing.Size(182, 20);
            this.txtNomEmpDes.TabIndex = 4;
            // 
            // txtDniEmpDes
            // 
            this.txtDniEmpDes.Location = new System.Drawing.Point(6, 55);
            this.txtDniEmpDes.Name = "txtDniEmpDes";
            this.txtDniEmpDes.Size = new System.Drawing.Size(63, 20);
            this.txtDniEmpDes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "NOMBRES Y APELLIDOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "AREA";
            // 
            // grpCodigoFecha
            // 
            this.grpCodigoFecha.Controls.Add(this.txtCodigoMovimiento);
            this.grpCodigoFecha.Controls.Add(this.dtpFechaDeMovimiento);
            this.grpCodigoFecha.Controls.Add(this.label7);
            this.grpCodigoFecha.Controls.Add(this.label10);
            this.grpCodigoFecha.Location = new System.Drawing.Point(769, 26);
            this.grpCodigoFecha.Name = "grpCodigoFecha";
            this.grpCodigoFecha.Size = new System.Drawing.Size(237, 102);
            this.grpCodigoFecha.TabIndex = 2;
            this.grpCodigoFecha.TabStop = false;
            // 
            // txtCodigoMovimiento
            // 
            this.txtCodigoMovimiento.Location = new System.Drawing.Point(67, 32);
            this.txtCodigoMovimiento.MaxLength = 4;
            this.txtCodigoMovimiento.Name = "txtCodigoMovimiento";
            this.txtCodigoMovimiento.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMovimiento.TabIndex = 3;
            this.txtCodigoMovimiento.TextChanged += new System.EventHandler(this.txtCodigoMovimiento_TextChanged);
            // 
            // dtpFechaDeMovimiento
            // 
            this.dtpFechaDeMovimiento.Enabled = false;
            this.dtpFechaDeMovimiento.Location = new System.Drawing.Point(17, 71);
            this.dtpFechaDeMovimiento.Name = "dtpFechaDeMovimiento";
            this.dtpFechaDeMovimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDeMovimiento.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "FECHA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "CODIGO DE MOVIMIENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "MOTIVO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "ASUNTO";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(537, 131);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(200, 49);
            this.txtAsunto.TabIndex = 3;
            // 
            // cboMotivo
            // 
            this.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Items.AddRange(new object[] {
            "Rotación",
            "Vacaciones",
            "Cese de Contrato",
            "Reincorporacion",
            "Otro"});
            this.cboMotivo.Location = new System.Drawing.Point(540, 68);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Size = new System.Drawing.Size(200, 21);
            this.cboMotivo.TabIndex = 4;
            // 
            // btnAgregarUno
            // 
            this.btnAgregarUno.Location = new System.Drawing.Point(492, 302);
            this.btnAgregarUno.Name = "btnAgregarUno";
            this.btnAgregarUno.Size = new System.Drawing.Size(53, 23);
            this.btnAgregarUno.TabIndex = 6;
            this.btnAgregarUno.Text = ">";
            this.btnAgregarUno.UseVisualStyleBackColor = true;
            this.btnAgregarUno.Click += new System.EventHandler(this.btnAgregarUno_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.Location = new System.Drawing.Point(492, 347);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(53, 23);
            this.btnAgregarTodo.TabIndex = 6;
            this.btnAgregarTodo.Text = ">>";
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(327, 433);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 52);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(578, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 52);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(670, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "VALOR ACTUAL DE BIENES A MOVER";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(876, 201);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(112, 20);
            this.txtMontoTotal.TabIndex = 7;
            // 
            // dgvEmpOrigen
            // 
            this.dgvEmpOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpOrigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvEmpOrigen.Location = new System.Drawing.Point(12, 266);
            this.dgvEmpOrigen.Name = "dgvEmpOrigen";
            this.dgvEmpOrigen.Size = new System.Drawing.Size(454, 150);
            this.dgvEmpOrigen.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modelo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Marca";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Serie";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Precio";
            this.Column7.Name = "Column7";
            // 
            // dgvEmpDestino
            // 
            this.dgvEmpDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvEmpDestino.Location = new System.Drawing.Point(570, 266);
            this.dgvEmpDestino.Name = "dgvEmpDestino";
            this.dgvEmpDestino.Size = new System.Drawing.Size(454, 150);
            this.dgvEmpDestino.TabIndex = 10;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Codigo";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Categoria";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Modelo";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Marca";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Serie";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Estado";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Precio";
            this.Column14.Name = "Column14";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "BIENES DEL EMPLEADO ORIGEN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(575, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "BIENES A MOVER";
            // 
            // FormMovimientoDeBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 498);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvEmpDestino);
            this.Controls.Add(this.dgvEmpOrigen);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.btnAgregarUno);
            this.Controls.Add(this.cboMotivo);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.grpCodigoFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grpEmpleadoDestino);
            this.Controls.Add(this.grpEmpleadoOrigen);
            this.Controls.Add(this.label9);
            this.Name = "FormMovimientoDeBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMovimientoDeBien";
            this.Load += new System.EventHandler(this.FormMovimientoDeBien_Load);
            this.grpEmpleadoOrigen.ResumeLayout(false);
            this.grpEmpleadoOrigen.PerformLayout();
            this.grpEmpleadoDestino.ResumeLayout(false);
            this.grpEmpleadoDestino.PerformLayout();
            this.grpCodigoFecha.ResumeLayout(false);
            this.grpCodigoFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmpleadoOrigen;
        private System.Windows.Forms.TextBox txtAreEmpOri;
        private System.Windows.Forms.TextBox txtNomEmpOri;
        private System.Windows.Forms.TextBox txtDniEmpOri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEmpOri;
        private System.Windows.Forms.GroupBox grpEmpleadoDestino;
        private System.Windows.Forms.TextBox txtAreEmpDes;
        private System.Windows.Forms.TextBox txtNomEmpDes;
        private System.Windows.Forms.TextBox txtDniEmpDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarEmpDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCodigoFecha;
        private System.Windows.Forms.TextBox txtCodigoMovimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaDeMovimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.ComboBox cboMotivo;
        private System.Windows.Forms.Button btnAgregarUno;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.DataGridView dgvEmpOrigen;
        private System.Windows.Forms.DataGridView dgvEmpDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}