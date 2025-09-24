using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegistrarTelePase : Form
    {
        public RegistrarTelePase()
        {
            InitializeComponent();
        }

        BE.TelePase telepase;
        BLL.TelePase bllTelepase;
        BLL.Vehiculo bllVehiculo;
        private void registrarTelePase_Load(object sender, EventArgs e)
        {
            bllVehiculo = new BLL.Vehiculo();
            bllTelepase = new BLL.TelePase();
            patenteComboBox.DataSource = bllVehiculo.ObtenerListaPatentes();
            patenteComboBox.DisplayMember = "patente";
            mostrarTelePases();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            int fa = 0;

            telepase = new BE.TelePase();
            telepase.ID = bllTelepase.ObtenerNuevoId();
            telepase.Fecha = DateTime.Now.Date;
            telepase.Hora = DateTime.Now.TimeOfDay;
            telepase.Vehiculo.Patente=patenteComboBox.Text;
            telepase.Importe = bllTelepase.ObtenerImporte(telepase.Vehiculo.Patente);

            fa = bllTelepase.Agregar(telepase);
            
            if (fa == 0)
            {
                MessageBox.Show("ERROR: no se pudo procesar TelePase");
            }
            else
            {
               MessageBox.Show("TelePase registrado correctamente");
            }
            mostrarTelePases();


        }

        private void mostrarTelePases()
        {
            dgvTelePases.DataSource = null;
            dgvTelePases.DataSource = bllTelepase.ObtenerTelePases();
            dgvTelePases.Columns["hora"].DefaultCellStyle.Format = @"hh\:mm\:ss";

        }
    }
}
