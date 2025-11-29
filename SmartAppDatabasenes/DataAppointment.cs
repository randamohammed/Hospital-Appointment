using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAppDatabasenes
{
    public class DataAppointment
    {
        public static int AddAppointment(int PaitentID, int DocterID,
            DateTime TimeTo, DateTime TimeForm, string Status,string ReasonForVisit)
        {
            int AppointmentD = 0;

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@PaitentID", PaitentID);
                        command.Parameters.AddWithValue("@DocterID", DocterID);
                        command.Parameters.AddWithValue("@TimeTo", TimeTo);
                        command.Parameters.AddWithValue("@TimeForm", TimeForm);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@ReasonForVisit", ReasonForVisit);

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int AddNew))
                        {
                            AppointmentD = AddNew;
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogErrorToEventLog($"Error Add New Appointment {ex.Message}");
                    }
                }
                return AppointmentD;
            }


        }
        public static async Task< DataTable> GetAllAppointment()
        {
            DataTable dtAllppointment = new DataTable();

            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllAppointments", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        await connection.OpenAsync();
                        using (SqlDataReader reader =  await command.ExecuteReaderAsync())
                        {

                            if (reader.HasRows)
                            {
                                dtAllppointment.Load(reader);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogErrorToEventLog($"Error do net Get All Appointment {ex.Message}");
                }
            }
            return dtAllppointment;

        }
    }
}
