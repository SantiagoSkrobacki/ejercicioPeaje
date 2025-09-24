using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpVehiculo
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.Vehiculo vehiculo)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@patente", vehiculo.Patente);
            parametro[1] = new SqlParameter("@marca", vehiculo.Marca);
            parametro[2] = new SqlParameter("@modelo", vehiculo.Modelo);
            parametro[3] = new SqlParameter("@idTipoVehiculo", vehiculo.TipoVehiculo.ID);
            fa = acc.Escribir("AgregarVehiculo", parametro);
            return fa;
        }
        public int Editar(BE.Vehiculo vehiculo)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@patente", vehiculo.Patente);
            parametro[1] = new SqlParameter("@marca", vehiculo.Marca);
            parametro[2] = new SqlParameter("@modelo", vehiculo.Modelo);
            parametro[3] = new SqlParameter("@idCategoria", vehiculo.TipoVehiculo.ID);
            fa = acc.Escribir("ModificarVehiculo", parametro);
            return fa;
        }

        public int Eliminar(BE.Vehiculo vehiculo)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", vehiculo.Patente);
            fa = acc.Escribir("EliminarVehiculo", parametro);
            return fa;
        }

        public List<string> ObtenerListaPatentes()
        {
            DataTable dt = acc.Leer("ListarPatentes", null);
            List<string> patentes = dt.AsEnumerable()
                             .Select(r => r[0].ToString()) 
                             .ToList();
            return patentes;
        }

    }
}
