using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppDatabasenes
{
    public class DataPatinet
    {

        public static bool FindPatientByID(int PatienIid, ref string Phone, ref string FullName, ref string Email
           , ref DateTime DataOfBirth, ref short Gender, ref string Address, ref string NationalID, ref string Notes)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("FindPatientByID", connection))
                {

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientId", PatienIid);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                FullName = (string)reader["FullName"];
                                Phone = reader["Phone"] == (object)DBNull.Value ? "" : (string)reader["Phone"];
                                Email = reader["Email"] == (object)DBNull.Value ? "" : (string)reader["Email"];
                                Notes = reader["Notes"] == (object)DBNull.Value ? "" : (string)reader["Notes"];
                                NationalID = (string)reader["NationalID"];
                                Address = (string)reader["Address"];
                                Gender = Convert.ToByte(reader["Gender"]);
                                DataOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                        ErrorLogger.LogErrorToEventLog($"Error Find Patent {ex.Message}");
                    }

                }
            }

            return IsFound;
        }

        public static bool FindPatientByNationalID(ref int PatienIid, ref string Phone, ref string FullName, ref string Email
          , ref DateTime DataOfBirth, ref short Gender, ref string Address, string NationalID, ref string Notes)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindPatientByNationalID", connection))
                {

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalID", NationalID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                PatienIid = (int)reader["PatientID"];
                                FullName = (string)reader["FullName"];
                                Phone = reader["Phone"] == (object)DBNull.Value ? "" : (string)reader["Phone"];
                                Email = reader["Email"] == (object)DBNull.Value ? "" : (string)reader["Email"];
                                Notes = reader["Notes"] == (object)DBNull.Value ? "" : (string)reader["Notes"];
                                Address = (string)reader["Address"];
                                Gender = Convert.ToByte(reader["Gender"]);
                                DataOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                        ErrorLogger.LogErrorToEventLog($"Error Find Patent {ex.Message}");
                    }

                }
            }

            return IsFound;
        }


        public static int AddPatientAndAppointment(string Phone, string FullName, string Email
           , DateTime DataOfBirth, short Gender, string Address, string NationalID, string Notes,DateTime RegistrationDate)
        {
            int PatientID = 0;

            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPatien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Phone", Phone == "" ? (object)DBNull.Value : Phone);
                        command.Parameters.AddWithValue("@Emil", Email == "" ? (object)DBNull.Value : Email);
                        command.Parameters.AddWithValue("@DataOfBirth", DataOfBirth);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@Notes ", Notes == "" ? (object)DBNull.Value : Notes);
                        command.Parameters.AddWithValue("@Address ", Address == "" ? (object)DBNull.Value : Address);
                        command.Parameters.AddWithValue("@Gender ", Gender);
                        command.Parameters.AddWithValue("@RegistrationDate ", RegistrationDate);


                        connection.Open();
                        object newId = command.ExecuteScalar();

                        if (newId != null && int.TryParse(newId.ToString(), out int Paietnt))
                        {
                            PatientID = Paietnt;
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogErrorToEventLog($"Dont add New Patient {ex.Message}");
                    }

                }
                return PatientID;
            }
        }

        public static bool UpdatePatien(int PatienIid, string Phone, string FullName, string Email,
           DateTime DataOfBirth, short Gender, string Address, string NationalID, string Notes)
        {
            int Result = 0;
            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_Updatepatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@PatientId", PatienIid);
                        command.Parameters.AddWithValue("@Phone", Phone == "" ? (object)DBNull.Value : Phone);
                        command.Parameters.AddWithValue("@Emil", Email == "" ? (object)DBNull.Value : Email);
                        command.Parameters.AddWithValue("@DataOfBirth", DataOfBirth);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@Notes ", Notes == "" ? (object)DBNull.Value : Notes);
                        command.Parameters.AddWithValue("@Address ", Address == "" ? (object)DBNull.Value : Address);
                        command.Parameters.AddWithValue("@Gender ", Gender);

                        connection.Open();

                        Result = command.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {

                        ErrorLogger.LogErrorToEventLog($"Faild Update : {ex.Message}");
                    }
                }
                return Result > 0;
            }
        }

        public static bool GetPatientDetailsForm(int PatienIid, ref string Phone, ref string FullName, ref string Email
         , ref DateTime DataOfBirth, ref DateTime LastUpdatedDate, ref short Gender, ref string Address, ref int NationalID, ref string Notes)
        {
            bool IsFount = false;
            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_PatientDetailsForm", connection))
                {

                    try
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        connection.Open();

                        command.Parameters.AddWithValue("@PatientId", PatienIid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFount = true;
                                Phone = (string)reader["Phone"];
                                Gender = Convert.ToByte(reader["Gender"]);
                                FullName = (string)reader["FullName"];
                                NationalID = (int)reader["NationalID"];
                                LastUpdatedDate = Convert.ToDateTime(reader["LastUpdatedDate"]);
                                DataOfBirth = Convert.ToDateTime(reader["DataOfBirth"]);
                                Address = reader["Address"] == System.DBNull.Value ? "" : (string)reader["Address"];
                                Notes = reader["Notes"] == System.DBNull.Value ? "" : (string)reader["Notes"];
                                Email = reader["Email"] == System.DBNull.Value ? "" : (string)reader["Email"];

                            }


                        }
                    }
                    catch (Exception ex)
                    {

                        ErrorLogger.LogErrorToEventLog($"Filad Get All Patient : {ex.Message}");
                    }
                }
                return IsFount;

            }
        }


        public static DataTable GetPatientsPaginated(int pageNumber, int pageSize)
        {
            DataTable dtPatients = new DataTable();

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPatientsPaginated", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PageNumber", pageNumber);
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtPatients.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogErrorToEventLog($"Filad Get Patients Paginated : {ex.Message}");
                    }
                }
            }
            return dtPatients;
        }


        public static bool ISPatienExistByNationalID(string NationalID)
        {
            bool ISFound = false;
            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("ISPatienExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalID", NationalID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ISFound = reader.Read();
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogErrorToEventLog($"Filad Know Patient is Exist By Nationtal Id : {ex.Message}");
                     
                    }
                }
            }
            return ISFound;
        }

        public static bool DeletePatient(int Patientid)
        {
            int ISdeleted = 0;
            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientId", Patientid);

                    try
                    {
                        connection.Open();

                        ISdeleted = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) 
                    {
                        ErrorLogger.LogErrorToEventLog($"Filad Delete Patient : {ex.Message}");                   
                    }
                }
            }
            return ISdeleted > 0;
        }

        public static bool GetPatientSummary(ref decimal balance,ref DateTime RegistrationDate,int PatientID)
        {
            bool Isfound = false;
            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPatientSummary", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientID", PatientID);

                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.Read())
                            {
                                Isfound = true;
                                balance = Convert.ToDecimal(reader["CurrentBalance"]);
                                RegistrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                            }
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogErrorToEventLog($"Filad don not Get to  CurrentBalance & RegistrationDate : {ex.Message}");
                    }
                }
            }
            return Isfound;
        }
    }

}
