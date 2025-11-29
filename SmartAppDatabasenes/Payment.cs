using System;
using System.Data.SqlClient;
using System.Data;
using SmartAppDatabasenes;


namespace Databasenes
{
    public class Payment
    {
        public static int AddNewPayment(int Patientid, int AppointmentId, float Amount, string Note)
        {
            int AddnewPlayment = 0;

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Patientid", Patientid);
                        command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@Note", Note);

                        connection.Open();

                        object newid = command.ExecuteScalar();

                        if (newid != null && int.TryParse(newid.ToString(), out int Playmentid))
                        {
                            AddnewPlayment = Playmentid;
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogErrorToEventLog($"Dont add New Patient {ex.Message}");
                    }
                }
            }
            return AddnewPlayment;
        }
    }
    }

