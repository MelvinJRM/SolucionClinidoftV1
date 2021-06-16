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
    public partial class FormReporteDePerdidas : Form
    {
        ReportarTotalDePerdidasEnBienesServicio perdidasEnBienesServicio;
        List<Bien> bienes;
        public FormReporteDePerdidas()
        {
            InitializeComponent();
            perdidasEnBienesServicio = new ReportarTotalDePerdidasEnBienesServicio();
            //bienes= new List<Bien>();

            cargarAreas();
            cboArea.SelectedIndex = 0;
            dgvBienesPerdidos.AllowUserToAddRows = false;


        }
        private void cargarAreas()
        {
            List<Area> areas = perdidasEnBienesServicio.ListarAreas();
            foreach (Area a in areas)
            {
                cboArea.Items.Add(a.Nombre);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime min=dtpFechaInicial.Value;
                DateTime max=dtpFechaFinal.Value;
                string area=cboArea.Text.Trim();

                //bienes.Clear();
                bienes = perdidasEnBienesServicio.BuscarBienes(min,max,area);
                dgvBienesPerdidos.Rows.Clear();
                foreach (Bien bien in bienes)
                {
                    Object[] filaBien = { bien.IdBien, bien.Categoria, bien.Modelo, bien.Marca, bien.Serie, (bien.Encontrado) ? "Encontrado" : "No encontrado", bien.Precio };
                    dgvBienesPerdidos.Rows.Add(filaBien);
                }                
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularPerdida_Click(object sender, EventArgs e)
        {

        }
    }
}
