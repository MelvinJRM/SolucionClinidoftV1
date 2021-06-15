using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa3_Dominio.Entidades;
using Capa2_Aplicación.Servicios;

namespace Capa1_Presentacion.WinForms
{
    public partial class FormLogin : Form
    {
        Usuario usuarioTecnico;
        RealizarLoginServicio realizarLoginServicio;
        FormMovimientoDeBien movimientoDeBien;

        public FormLogin()
        {
            InitializeComponent();
            realizarLoginServicio = new RealizarLoginServicio();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
     
                try
                {
                    realizarLoginServicio.ValidarLogin(dni, contrasena);
                    usuarioTecnico = realizarLoginServicio.BuscarUsuarioPorDni(dni);
                    realizarLoginServicio.ValidarTecnico(usuarioTecnico);

                    MessageBox.Show("Logeado");
                    movimientoDeBien = new FormMovimientoDeBien(usuarioTecnico, this);
                    txtDni.Text = "";
                    txtContrasena.Text = "";
                    this.Hide();
                    movimientoDeBien.Show();
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, err.Message, "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }     

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
