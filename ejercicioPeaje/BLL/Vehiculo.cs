using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Vehiculo
    {
        MpVehiculo mapper = new MpVehiculo();

        public void AgregarVehiculo(BE.Vehiculo ve)
        {
            mapper.Agregar(ve);
        }

        public void ModificarVehiculo(BE.Vehiculo ve)
        {
            mapper.Editar(ve);
        }

        public void EliminarVehiculo(BE.Vehiculo ve)
        {
            mapper.Eliminar(ve);
        }

        public List<string> ObtenerListaPatentes()
        {
            return mapper.ObtenerListaPatentes();
            
        } 
    }
}
