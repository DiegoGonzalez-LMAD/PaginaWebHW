using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace PaginaWebHW.Data
{
    public class DataAcces
    {
        private readonly string connectionString;
        public DataAcces(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DataAcces()
        {
            var Server = "DIEGOLAP";
            var database = "HW_APP";
            connectionString = $"Data Source={Server};Initial Catalog={database};Integrated Security=True;Trusted_Connection=True ";
        }
        public void Execute(string spName, SqlParameter[] SQLParams)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(SQLParams);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Database error: " + ex.Message);
                    }
                }
            }
        }
        public object ExecuteFunction(string functionName, SqlParameter[] SQLParams)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    // ✅ Ejecutar la función como una consulta SELECT
                    cmd.CommandText = $"SELECT dbo.{functionName}({string.Join(",", SQLParams.Select(p => p.ParameterName))})";
                    cmd.Parameters.AddRange(SQLParams);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteScalar(); // Devuelve el valor BIT de la función (1 o 0)
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Database error: " + ex.Message);
                    }
                }
            }
        }


    }
}
