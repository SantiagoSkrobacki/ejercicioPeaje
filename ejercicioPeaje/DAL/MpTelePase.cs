using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpTelePase
    {
        Acceso acc = new Acceso();
        public int Agregar(BE.TelePase telepase)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[5];
            parametro[0] = new SqlParameter("id", telepase.ID);
            parametro[1] = new SqlParameter("fecha",telepase.Fecha);
            parametro[2] = new SqlParameter("hora", telepase.Hora);
            parametro[3] = new SqlParameter("patente", telepase.Vehiculo.Patente);
            parametro[4] = new SqlParameter("importe",telepase.Importe);
            fa = acc.Escribir("AgregarTelepase",parametro);
            return fa;
        }

        public int Modificar(BE.TelePase telepase)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[5];
            parametro[0] = new SqlParameter("id", telepase.ID);
            parametro[1] = new SqlParameter("fecha", telepase.Fecha);
            parametro[2] = new SqlParameter("hora", telepase.Hora);
            parametro[3] = new SqlParameter("patente", telepase.Vehiculo.Patente);
            parametro[4] = new SqlParameter("importe", telepase.Importe);
            fa = acc.Escribir("ModificarTelepase", parametro);
            return fa;
        }

        public int Eliminar(BE.TelePase telepase)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[0];
            parametro[0] = new SqlParameter("id",telepase.ID);
            fa = acc.Escribir("EliminarTelepase", parametro);
            return fa;
        }

        public int ObtenerNuevoId()
        {
            int idTelepase = -1;
            idTelepase = Convert.ToInt32(acc.ObtenerDato("ObtenerNuevoIdTelepase", null));
            return idTelepase;
        }
    }
}
