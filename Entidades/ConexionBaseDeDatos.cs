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
                CerrarConexion();
            }

            return rta;
        }
        public List<Usuario> ObtenerListaDeUsuarios()
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
                CerrarConexion();
            }

            return lista;
        }
        public bool Agregarsuarios(Usuario param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO Usuario (Nombre, Apellido, Correo, Clave) VALUES(";
                sql = sql + "'" + param.Nombre + "','" + param.Apellido + "','" + param.Correo + "','" + param.Clave + "')";

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
                CerrarConexion();
            }

            return rta;
        }

        public List<Jugador> ObtenerListaDeJugadores()
        {
            List<Jugador> lista = new List<Jugador>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Jugadores";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Jugador item = new Jugador();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.Id = (int)lector["Id"];
                    item.Nombre = lector["Nombre"].ToString();
                    item.PartidasJugadas = int.Parse(lector["PartidasJugadas"].ToString());
                    item.PartidasGanadas = int.Parse(lector["PartidasGanadas"].ToString());
                    item.PartidasPerdidas = int.Parse(lector["PartidasPerdidas"].ToString());
                    item.PuntajeTotal = int.Parse(lector["PuntajeTotal"].ToString());
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
                CerrarConexion();
            }

            return lista;
        }
        public bool AgregarJugador(Jugador param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO Jugadores (Nombre, PartidasJugadas, PartidasGanadas, PartidasPerdidas, PuntajeTotal) VALUES(";
                sql = sql + "'" + param.Nombre + "'," +param.PartidasJugadas.ToString() + "," + param.PartidasGanadas.ToString() + "," + param.PartidasPerdidas.ToString() +"," + param.PuntajeTotal + ")";


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
                CerrarConexion();
            }

            return rta;
        }
        public bool ModificarJugador(Jugador param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@Id", param.Id);
                this.comando.Parameters.AddWithValue("@Nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@PartidasJugadas", param.PartidasJugadas);
                this.comando.Parameters.AddWithValue("@PartidasGanadas", param.PartidasGanadas);
                this.comando.Parameters.AddWithValue("@PartidasPerdidas", param.PartidasPerdidas);
                this.comando.Parameters.AddWithValue("@PuntajeTotal", param.PuntajeTotal);



                string sql = "UPDATE Jugadores ";
                sql += "SET Nombre = @Nombre,PartidasJugadas=@PartidasJugadas,PartidasGanadas=@PartidasGanadas,PartidasPerdidas=@PartidasPerdidas,PuntajeTotal=@PuntajeTotal ";
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
                CerrarConexion();
            }
            return rta;
        }
        public bool EliminarJugador(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@Id", id);

                string sql = "DELETE FROM Jugadores ";
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
                CerrarConexion();
            }

            return rta;
        }
        public void CerrarConexion() 
        {
            if (this.conexion.State == ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }

    }
}
