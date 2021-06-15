using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa2_Aplicación.Servicios;
using Capa3_Dominio.Entidades;

namespace Capa1_Presentacion.WinForms
{
    public partial class FormMovimientoDeBien : Form
    {

        RealizarMovimientoDeBienServicio procesarMovimiento ;
        FormLogin login;
        Usuario usuarioDestino;
        Usuario usuarioOrigen;
        Usuario usuarioTecnico;

        public FormMovimientoDeBien(Usuario usuarioTecnico, FormLogin login)
        {
            InitializeComponent();
            IniciarProcesoDeMovimiento();
            this.usuarioTecnico = usuarioTecnico;
            this.login = login;
            cboMotivo.SelectedIndex = 0;

            dgvEmpOrigen.AllowUserToAddRows = false;
            dgvEmpDestino.AllowUserToAddRows = false;
            btnBuscarEmpDes.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnAgregarUno.Enabled = false;
        }

        public void IniciarProcesoDeMovimiento() 
        {
            procesarMovimiento = new RealizarMovimientoDeBienServicio();
        }



        private void FormMovimientoDeBien_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmpOri_Click(object sender, EventArgs e)
        {
            String dniOrigen = txtDniEmpOri.Text.Trim();
                        
            try
            {
                usuarioOrigen = procesarMovimiento.BuscarUsuarioPorDni(dniOrigen);
                procesarMovimiento.ValidarEmpleado(usuarioOrigen);
                
                    txtAreEmpOri.Text = usuarioOrigen.Area1.Nombre;
                    txtNomEmpOri.Text = usuarioOrigen.Nombres + " " + usuarioOrigen.Apellidos;

                    List<Bien> bienes = procesarMovimiento.BuscarBienPorDniUsuario(dniOrigen);
                    dgvEmpOrigen.Rows.Clear();
                    foreach (Bien bien in bienes)
                    {
                        Object[] filaBien = { bien.IdBien, bien.Categoria, bien.Modelo, bien.Marca, bien.Serie, (bien.Encontrado)?"Encontrado":"No encontrado" , bien.Precio };
                        dgvEmpOrigen.Rows.Add(filaBien);

                    }
                    btnBuscarEmpDes.Enabled = true;
               

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema Clinica",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void btnBuscarEmpDes_Click(object sender, EventArgs e)
        {
            String dniDestino = txtDniEmpDes.Text.Trim();
            try
            {
                usuarioDestino = procesarMovimiento.BuscarUsuarioPorDni(dniDestino);

                procesarMovimiento.ValidarEmpleado(usuarioDestino);
                procesarMovimiento.ValidarIdEmpleado(usuarioDestino, usuarioOrigen.IdUsuario);

                
                    txtAreEmpDes.Text = usuarioDestino.Area1.Nombre;
                    txtNomEmpDes.Text = usuarioDestino.Nombres + " " + usuarioDestino.Apellidos;
                    btnAgregarUno.Enabled = true;
                    btnAgregarTodo.Enabled = true;
                    btnBuscarEmpOri.Enabled = false;
                
                
            }
            catch (Exception err)
            {

                MessageBox.Show(this, err.Message, "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAgregarUno_Click(object sender, EventArgs e)
        {
            if (dgvEmpOrigen.Rows.Count >= 1)
            {
                String codigoBien;
                DataGridViewRow filaBien = dgvEmpOrigen.CurrentRow;


                if (filaBien == null)
                {
                    MessageBox.Show(this, "No ha seleccionado un bien.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                codigoBien = filaBien.Cells[0].Value.ToString();
                Boolean seMovioTabla = MoverBienEnTablas(codigoBien);
                if (seMovioTabla)
                {
                    dgvEmpOrigen.Rows.RemoveAt(dgvEmpOrigen.CurrentRow.Index);                   
                    btnBuscarEmpDes.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(this, "No hay mas bienes para mover.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            if (dgvEmpOrigen.Rows.Count >= 1)
            {
                String codigoBien;
                Boolean seMovioTabla;
                DataGridViewRow filaBien;
                int aux = 0;
                int cantidad = dgvEmpOrigen.Rows.Count;
                for (int i = 0; i < cantidad; i++)
                {
                    filaBien = dgvEmpOrigen.Rows[aux];
                    codigoBien = filaBien.Cells[0].Value.ToString();
                    seMovioTabla = MoverBienEnTablas(codigoBien);
                    if (seMovioTabla)
                    {
                        dgvEmpOrigen.Rows.RemoveAt(aux);
                       
                        btnBuscarEmpDes.Enabled = false;
                    }
                    else
                    {
                        aux++;
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "No hay mas bienes para mover.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Boolean MoverBienEnTablas(string codigoBien) 
        {
            Boolean seAgrego = true;
            try
            {
                procesarMovimiento.AgregarDetalleDeMovimiento(codigoBien);
                MovimientoDeBien auxMovimientoDeBien = procesarMovimiento.Movimiento;
                DetalleMovimiento auxDetalleMovimiento = auxMovimientoDeBien.RetornarUltimoDetalleMovimiento();
                Bien auxBien = auxDetalleMovimiento.Bien;

                Object[] auxfila = { auxBien.IdBien, auxBien.Categoria, auxBien.Modelo, auxBien.Marca, auxBien.Serie, (auxBien.Encontrado) ? "Encontrado" : "No encontrado", auxBien.Precio };
                dgvEmpDestino.Rows.Add(auxfila);

                txtMontoTotal.Text = auxMovimientoDeBien.CalcularMontoTotalDeBienesAMover().ToString();

            }
            catch (Exception err)
            {
                seAgrego = false;
                MessageBox.Show(this, err.Message, "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            return seAgrego;


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            MovimientoDeBien mov = procesarMovimiento.Movimiento;

            mov.UsuarioOrigen = usuarioOrigen;
            if (usuarioOrigen == null)
            {
                MessageBox.Show(this, "No existe Usuario Origen.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mov.UsuarioDestino = usuarioDestino;
            if (usuarioDestino == null)
            {
                MessageBox.Show(this, "No existe Usuario Destino.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mov.Motivo = cboMotivo.SelectedItem.ToString();

            mov.UsuarioTecnico = usuarioTecnico;

            mov.IdMovimiento = txtCodigoMovimiento.Text.Trim();
            if (mov.IdMovimiento == "")
            {
                MessageBox.Show(this, "Es necesario registrar un id de Movimiento.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mov.Asunto = txtAsunto.Text.Trim();
            if (mov.Asunto=="")
            {
                MessageBox.Show(this, "Es necesario registrar un Asunto.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                procesarMovimiento.GuardarMovimientoDeBien();
                MessageBox.Show(this, "El movimiento sido registrado.", "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cerrar();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoMovimiento.Text= "";
            }

        }

        private void txtCodigoMovimiento_TextChanged(object sender, EventArgs e)
        {

        }
        void cerrar()
        {
            this.Hide();
            login.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
    }
}
