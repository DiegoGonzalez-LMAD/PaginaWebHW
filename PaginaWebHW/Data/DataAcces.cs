using PaginaWebHW.Entities;
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
                    cmd.CommandText = $"SELECT * from dbo.{functionName}({string.Join(",", SQLParams.Select(p => p.ParameterName))})";
                    cmd.Parameters.AddRange(SQLParams);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    return new ET_Usuario
                                    {
                                        id_Usuario = Convert.ToInt32(reader["id_Usuario"]),
                                        nombreUsuario = reader["nombreUsuario"].ToString(),
                                        correoElectronico = reader["correoElectronico"].ToString(),
                                        contrasenia = reader["contrasenia"].ToString()
                                    };
                                }
                                else
                                {
                                    return null;
                                }
                            }
                            else
                            {
                                return null ;
                            }
                           
                            
                        } 
                        
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
