using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppDatabasenes
{
    public class DataDocter
    {
        public static int AddNewDocter(string Phone, string Email, string Specialty, string Fullname)
        {
            int DocterID = 0;

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewDocter", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Doctername", Fullname);
                    command.Parameters.AddWithValue("@Specialty", Specialty);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);

                    connection.Open();

                    SqlParameter OutPramater = new SqlParameter("@DocterID", System.Data.SqlDbType.Int);
                    OutPramater.Direction = ParameterDirection.Output;

                    command.Parameters.Add(OutPramater);
                    command.ExecuteNonQuery();

                    DocterID = (int)command.Parameters["@DocterID"].Value;
                }
            }
            return DocterID;
        }

        public static bool UpdateDocter(int DocterID, string Fullname, string Specialty, string Eimal, string Phone)
        {
            bool ResultUpdate = false;

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {

                using (SqlCommand command = new SqlCommand("SP_UpdateDocter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Doctername", Fullname);
                    command.Parameters.AddWithValue("@DocterID", DocterID);
                    command.Parameters.AddWithValue("@Specialty", Specialty);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Eimal);

                    connection.Open();

                    SqlParameter OutPramater = new SqlParameter("@Result", System.Data.SqlDbType.Bit);
                    OutPramater.Direction = ParameterDirection.Output;

                    command.Parameters.Add(OutPramater);
                    command.ExecuteScalar();

                    ResultUpdate = Convert.ToBoolean(command.Parameters["@Result"].Value);
                }
                return ResultUpdate;
            }
        }
        public static bool FindDocterById(int DocterID, ref string Fullname,
            ref string Specialty, ref string Eimal, ref string Phone)
        {
            bool ResultFind = false;

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {

                using (SqlCommand command = new SqlCommand("GetDoctorByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@DoctorID", DocterID);

                    connection.Open();
                    SqlDataReader reder = command.ExecuteReader();

                    if (reder.Read())
                    {
                        ResultFind = true;
                        Fullname = Convert.ToString(reder["FullName"]);

                        Specialty = Convert.ToString(reder["Specialty"]);

                        if (reder["Phone"] != System.DBNull.Value)
                            Phone = Convert.ToString(reder["Phone"]);
                        else
                            Phone = "";

                        if (reder["Email"] != System.DBNull.Value)
                            Eimal = Convert.ToString(reder["Email"]);
                        else
                            Eimal = "";
                    }
                    else
                    {
                        ResultFind = false;
                    }

                }
                return ResultFind;
            }
        }

        public static bool DeleteDocter(int DocterID)
        {
            bool deleted = false;


            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteDocter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@DocterID", DocterID);

                    connection.Open();

                    SqlParameter OutPramater = new SqlParameter("@Reslutdelete", System.Data.SqlDbType.Int);
                    OutPramater.Direction = ParameterDirection.Output;

                    command.Parameters.Add(OutPramater);
                    command.ExecuteScalar();

                    deleted = Convert.ToBoolean(command.Parameters["@Reslutdelete"].Value);

                }
            }
            return deleted;
        }
        public static async Task<DataTable> GetAllDoctorsAsync() 
        {
            DataTable allDoctors = new DataTable();

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllDocter", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            allDoctors.Load(reader);
                        }
                    }
                } 
            } 

            return allDoctors;
        }

        public static async Task<DataTable> GetAllDocterForCombox()
        {
            DataTable allDoctors = new DataTable();

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_comAlldocters", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            allDoctors.Load(reader);
                        }
                    }
                }
            }

            return allDoctors;
        }


    }
}
