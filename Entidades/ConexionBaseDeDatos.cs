using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class ConexionBaseDeDatos
    {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static ConexionBaseDeDatos()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.IntegratedSecurity = true;
            //builder.UserID = "usuario";
            //builder.Password = "clave";
            builder.InitialCatalog = "GeneralaDataBase";
            ConexionBaseDeDatos.cadena_conexion = builder.ConnectionString;
        }
        public ConexionBaseDeDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(ConexionBaseDeDatos.cadena_conexion);
        }
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }
        public List<Usuario> ObtenerListaDato()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Usuario";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario item = new Usuario();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.Id = (int)lector["Id"];
                    item.Nombre = lector["Nombre"].ToString();
                    item.Apellido = lector["Apellido"].ToString();
                    item.Correo = lector["Correo"].ToString();
                    item.Clave = lector["Clave"].ToString();

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }
        public bool AgregarDato(Usuario param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.tabla_jugadores (Nombre, Apellido, Correo, Clave) VALUES(";
                sql = sql + "'" + param.Nombre + "','" + param.Apellido + "','" + param.Correo + "','" + param.Clave + "'," +
                param.PartidasJugadas.ToString() + "," + param.PartidasGanadas.ToString() + "," + param.PartidasPerdidas.ToString() + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarDato(Usuario param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@Id", param.Id);
                this.comando.Parameters.AddWithValue("@Nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", param.Apellido);
                this.comando.Parameters.AddWithValue("@Correo", param.Correo);
                this.comando.Parameters.AddWithValue("@Clave", param.Clave);

                string sql = "UPDATE Usuario ";
                sql += "SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Clave = @Clave";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }
        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@Id", id);

                string sql = "DELETE FROM Usuario ";
                sql += "WHERE Id = @Id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }
    }
}
