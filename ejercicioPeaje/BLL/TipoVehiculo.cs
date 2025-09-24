using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TipoVehiculo
    {
        MpTipoVehiculo mapper = new MpTipoVehiculo();
        public DataTable ObtenerListaTipoVehiculos()
        {
            return mapper.ObtenerListaTipoVehiculos();
        }

    }
}
