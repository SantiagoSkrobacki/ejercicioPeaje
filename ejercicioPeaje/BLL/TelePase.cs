using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TelePase
    {
        MpTelePase mapper = new MpTelePase();
        public int Agregar(BE.TelePase telePase)
        {
           return mapper.Agregar(telePase);
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

        public DataTable ObtenerTelePases()
        {
            return mapper.ObtenerTelePases();
        }

        public int ObtenerImporte(string patente)
        {
            return mapper.ObtenerImporte(patente);
        }
    }   
}
