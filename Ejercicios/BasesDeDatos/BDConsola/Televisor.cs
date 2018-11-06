using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BDConsola
{
    public class Televisor
    {
        public int id;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;

        public List<Televisor> televisores;

        public Televisor(int id, string marca, double precio, int pul, string pais)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pul;
            this.pais = pais;
        }

        public Televisor()
        {
            
        }

        public bool Insertar()
        { 
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO dbo.Televisores (codigo,marca,precio,pulgadas,pais) " +
                "VALUES (" + this.id + ",'" + this.marca + "'," + this.precio + "," + this.pulgadas + ",'" + this.pais + "')";
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
