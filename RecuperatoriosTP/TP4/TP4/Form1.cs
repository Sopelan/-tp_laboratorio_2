using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.Entidades;
namespace TP4
{
    public partial class FrmPpal : Form
    {
        private Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            this.Text = "Correo UTN por Marcos.Sopelana.2A";
            this.correo = new Correo();
        }
        private void ActualizarEstados()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();
            foreach (Paquete item in this.correo.Paquetes)
            {
                if (item.Estado == Paquete.EEstado.Ingresado)
                {
                    this.lstEstadoIngresado.Items.Add(item);
                }
                else if (item.Estado == Paquete.EEstado.EnViaje)
                {
                    this.lstEstadoEnViaje.Items.Add(item);
                }
                else if (item.Estado == Paquete.EEstado.Entregado)
                {
                    this.lstEstadoEntregado.Items.Add(item);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
                paquete.InformaEstado += paq_InformaEstado;
                this.correo += paquete;
                this.ActualizarEstados();
            }
            catch (TrackingIdRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
                this.ActualizarEstados();
        }
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(elemento != null)
            {
                this.rtbMostrar.Clear();
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                if (elemento is Correo)
                    elemento.MostrarDatos(elemento).Guardar("salida");

            }
        }
    }
}