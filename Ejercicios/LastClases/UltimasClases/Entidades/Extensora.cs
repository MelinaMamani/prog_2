using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class Extensora
    {
        public static string ObtenerDatos(this PersonaExternaSellada personaExterna)
        {
            return personaExterna.Nombre +" "+personaExterna.Apellido+" "+personaExterna.Edad+" "+personaExterna.Sexo;
        }

        public static bool EsNulo(this Object obj)
        {
            return obj == null;
        }

        public static Int32 CantidadDigitos(this Int32 num)
        {
            return (Int32)(Math.Log10(num) + 1);
        }

        public static bool TieneLaMismaCantidad(this Int32 num1, Int32 num2)
        {
            return Extensora.CantidadDigitos(num1) == num2;
        }

        public static List<Persona> TraerBD (this Persona p)
        {
            List<Persona> personas = new List<Persona>();

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM dbo.personas";
            comando.Connection = conexion;

            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                p = new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(3), (ESexo)(reader.GetInt32(4)));
                personas.Add(p);
            }
            conexion.Close();

            return personas;
        }

        public static bool AgregarBD(this Persona p)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO dbo.personas (nombre,apellido,edad,sexo) " +
                "VALUES ('" + p.Nombre + "','" + p.Apellido + "'," + p.Edad + "," + (int)p.Sexo + ")";
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static bool ModificarBD(this Persona p, int id)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE dbo.personas SET nombre='" + p.Nombre + "', apellido='" + p.Apellido + "',edad=" + p.Edad + "," +
              "sexo=" + (int)(p.Sexo) + " WHERE id=" +id+ "";
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static bool QuitarBD(int id)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE dbo.personas WHERE id=" + id + "";
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
