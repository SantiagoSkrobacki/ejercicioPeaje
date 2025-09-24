using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

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
            SqlParameter[] parametro = new SqlParameter[1];
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

        public DataTable ObtenerTelePases()
        {
            return acc.Leer("ObtenerTelePases", null);
        }
        public int ObtenerImporte(string patente)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("patente", patente);
            int importe = 0;
            importe = Convert.ToInt32(acc.ObtenerDato("ObtenerImporteTelePase", parametro));
            return importe;
        }
    }
}
