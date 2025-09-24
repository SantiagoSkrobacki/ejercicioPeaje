using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpTipoVehiculo
    {
        Acceso acc = new Acceso();
        public DataTable ObtenerListaTipoVehiculos()
        {
            DataTable dt = acc.Leer("ObtenerListaTipoVehiculos", null);
            return dt;
        }

    }
}
