﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.Xml;

namespace BDConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

            conexion.Open();

            SqlCommand comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM dbo.Televisores";
            comando.Connection = conexion;

            SqlDataReader reader = comando.ExecuteReader();
            Televisor lista = new Televisor();
            lista.televisores = new List<Televisor>();

            while (reader.Read())
            {
                //Se pueden usar numeros en vez del nombre del campo
                //Console.WriteLine(reader[0] + " - " + reader[1] + " - " + reader[2] + " - " + reader[3]+ " - "+reader[4]);

                //Primera opcion
                Televisor t1 = new Televisor(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetString(4));
                lista.televisores.Add(t1);
                
                //Casteo
                //Televisor t2 = new Televisor((int)reader[0], (string)reader[1], (double)reader[2], (int)reader[3], (string)reader[4]);
                //lista.televisores.Add(t2);

                Console.WriteLine(reader["codigo"]+" - "+reader["marca"]+" - "+reader["pulgadas"]+" - "+reader["pais"]);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Televisor>));
            XmlTextWriter xmlWriter = new XmlTextWriter("televisores.xml",Encoding.UTF8);
            XmlTextReader xmlReader = new XmlTextReader("televisores.xml");

            serializer.Serialize(xmlWriter, lista.televisores);
            xmlWriter.Close();

            List<Televisor> televisors =  (List<Televisor>)serializer.Deserialize(xmlReader);
            xmlReader.Close();

            conexion.Close();
            conexion.Open();

            reader = comando.ExecuteReader();

            DataTable dataTable = new DataTable("Televisores");
            dataTable.Load(reader);
            conexion.Close();

            //.
            dataTable.WriteXmlSchema("televisoresEsquema.xml");
            dataTable.WriteXml("televisoresDT.xml");

            DataTable dataTable2 = new DataTable();
            
            dataTable2.ReadXmlSchema("televisoresEsquema.xml");
            dataTable2.ReadXml("televisoresDT.xml");

            //Inserto algo
            Televisor tele = new Televisor(125,"Samsung",16999,50,"Argentina");
            if (tele.Insertar())
            {
                Console.WriteLine("Se insertó.");
            }

            conexion.Close();
            Console.ReadKey();
        }
    }
}
