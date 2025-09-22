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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registrarPaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarTelePase registrarTelePase = new RegistrarTelePase();
            registrarTelePase.MdiParent = this;
            registrarTelePase.Show();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenTelePase resumenTelePase = new ResumenTelePase();
            resumenTelePase.MdiParent = this;
            resumenTelePase.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVehiculo agregarVehiculo = new AgregarVehiculo();
            agregarVehiculo.MdiParent = this;
            agregarVehiculo.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarVehiculo editarVehiculo = new EditarVehiculo();
            editarVehiculo .MdiParent = this;
            editarVehiculo .Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarVechiculo eliminarVehiculo = new EliminarVechiculo();
            eliminarVehiculo.MdiParent= this;
            eliminarVehiculo .Show();
        }
    }
}
