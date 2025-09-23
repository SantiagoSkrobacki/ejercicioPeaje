using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TelePase
    {
        MpTelePase mapper = new MpTelePase();
        public void Agregar(BE.TelePase telePase)
        {
            mapper.Agregar(telePase);
        }

        public void Editar(BE.TelePase telePase)
        {
            mapper.Modificar(telePase);
        }

        public void Eliminar(BE.TelePase telePase)
        {
            mapper.Eliminar(telePase);
        }

        public int ObtenerNuevoId()
        {
           return mapper.ObtenerNuevoId();
        }
    }
}
