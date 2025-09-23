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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            telepase = new BE.TelePase();
            telepase.ID = bllTelepase.ObtenerNuevoId();
            telepase.Fecha = DateTime.Now;
            telepase.Hora = DateTime.Now;
            telepase.Vehiculo.Patente=patenteComboBox.Text;
            
        }
    }
}
