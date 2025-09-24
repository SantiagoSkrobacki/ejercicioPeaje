using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    internal class Acceso
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction TR = null;

        public void Conectar()
        {
            connection.ConnectionString = "Data Source=.;Initial Catalog=Peaje;Integrated Security=True";
            connection.Open();


        }
        public void Desconectar()
        {
            connection.Close();
            cmd.Parameters.Clear();
            cmd.Dispose();
        }


        public int Escribir(string sp, SqlParameter[] parametros)
        {
            int fa = 0;
            try
            {
                Conectar();

                TR = connection.BeginTransaction();

                cmd.Connection = connection;
                cmd.Transaction = TR;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if(parametros != null && parametros.Length > 0)
                    cmd.Parameters.AddRange(parametros);

                fa = cmd.ExecuteNonQuery();

                TR.Commit();
                return fa;

            }
            catch (Exception ex)
            {
                TR.Rollback();
                throw new Exception("Rollback en transaccion");
            }
            finally
            {
                Desconectar();
                
            }

        }

        public DataTable Leer(string sp, SqlParameter[] parametros)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter();
                Conectar();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (parametros != null && parametros.Length > 0)
                    cmd.Parameters.AddRange(parametros);

                adaptador.SelectCommand = cmd;
                adaptador.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error en base de datos: "+ ex.ToString());
            }
            finally
            {
                Desconectar();
            }
        }

        public Object ObtenerDato(string sp, SqlParameter[] parametros)
        {
            object result = null;
            try
            {
                Conectar();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (parametros != null && parametros.Length > 0)
                    cmd.Parameters.AddRange(parametros);

                result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en base de datos");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
