using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace GUI
{
    public partial class AgregarVehiculo : Form
    {
        public AgregarVehiculo()
        {
            InitializeComponent();
        }

        BE.Vehiculo vehiculo;
        BLL.Vehiculo bllVehiculo = new BLL.Vehiculo();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vehiculo = new BE.Vehiculo();
                vehiculo.Patente = patenteBOX.Text;
                vehiculo.Marca = marcaBOX.Text;
                vehiculo.Modelo = modeloBOX.Text;
                vehiculo.TipoVehiculo.ID = Convert.ToInt32(tipoVehiculoCmb.SelectedValue);
                bllVehiculo.AgregarVehiculo(vehiculo);
                MessageBox.Show("Se agrego");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {
            BLL.TipoVehiculo bllTipoVehiculo = new BLL.TipoVehiculo();
            DataTable tiposVehiculos = new DataTable();
            tiposVehiculos = bllTipoVehiculo.ObtenerListaTipoVehiculos();
            tipoVehiculoCmb.DisplayMember = "Nombre";
            tipoVehiculoCmb.ValueMember = "ID";
            tipoVehiculoCmb.DataSource = tiposVehiculos;
        }
    }
}
