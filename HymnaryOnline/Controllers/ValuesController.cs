using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace HymnaryOnline.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ValuesController : ApiController
    {
        // GET api/values
        public List<CostoDesplazamiento> Get()
        {
            var list = new List<CostoDesplazamiento>();
            SqlConnection cnn;
            var connetionString = "Data Source=66.232.22.196;Initial Catalog=FOXCLEA_TAREAS;User ID=FOXCLEA_TAREAS;Password=JACINTO2014";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                var sql = "Select * from bmcosto_desplazamiento";
                var command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    var costoDesplazamiento = new CostoDesplazamiento()
                    {
                        Provincia = dataReader.GetValue(4).ToString(),
                        PrecioHora = int.Parse(dataReader.GetValue(5).ToString()),
                        Desde = int.Parse(dataReader.GetValue(3).ToString()),
                        Hasta = int.Parse(dataReader.GetValue(1).ToString()),
                        Desplazamiento = int.Parse(dataReader.GetValue(2).ToString())
                    };

                    list.Add(costoDesplazamiento);
                }
                dataReader.Close();
                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                return new List<CostoDesplazamiento>() { new CostoDesplazamiento() { Provincia = "Error" } };
            }
            return list;
        }

        // GET api/values/5
        public List<CostoDesplazamiento> Get(string provincia)
        {
            var list = new List<CostoDesplazamiento>();
            SqlConnection cnn;
            var connetionString = "Data Source=66.232.22.196;Initial Catalog=FOXCLEA_TAREAS;User ID=FOXCLEA_TAREAS;Password=JACINTO2014";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                var sql = "Select * from bmcosto_desplazamiento WHERE provincia like '" + provincia + "'"  ;
                var command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    var costoDesplazamiento = new CostoDesplazamiento()
                    {
                        Provincia = dataReader.GetValue(4).ToString(),
                        PrecioHora = int.Parse(dataReader.GetValue(5).ToString()),
                        Desde = int.Parse(dataReader.GetValue(3).ToString()),
                        Hasta = int.Parse(dataReader.GetValue(1).ToString()),
                        Desplazamiento = int.Parse(dataReader.GetValue(2).ToString())
                    };

                    list.Add(costoDesplazamiento);
                }
                dataReader.Close();
                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                return new List<CostoDesplazamiento>() { new CostoDesplazamiento() { Provincia = "Error" } };
            }
            return list;
        }

        // POST api/values
        public List<string> Post(string provincia)
        {
            var list = new List<string>();
            SqlConnection cnn;
            var connetionString = "Data Source=66.232.22.196;Initial Catalog=FOXCLEA_TAREAS;User ID=FOXCLEA_TAREAS;Password=JACINTO2014";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                var sql = "Select * from bm_provincias where provincia like '" + provincia + "'";
                var command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {                    
                    list.Add(dataReader.GetValue(2).ToString());
                    list.Add(dataReader.GetValue(3).ToString());
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex){}
            return list;
        }
    }

    public class CostoDesplazamiento
    {
        public string Provincia { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public int Desplazamiento { get; set; }
        public int PrecioHora { get; set; }
    }
}
