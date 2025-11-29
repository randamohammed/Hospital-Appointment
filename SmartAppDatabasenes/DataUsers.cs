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
    public class DataUsers
    {
        //SP_AddNewUser

        public static int AddNewUser(string username, string password,string Role,int CruenetUser,string Phone)
        {
            int AddUser = -1;


            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using(SqlCommand command = new SqlCommand( "SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@PerformBy", CruenetUser);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    connection.Open();

                    SqlParameter Outparmeter = new SqlParameter("@AddUser", SqlDbType.Int);
                    Outparmeter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(Outparmeter);

                    command.ExecuteNonQuery();

                     AddUser =(int) command.Parameters["@AddUser"].Value;
                  
                }              
            }
            return AddUser;
        }

        public static bool IsUserExist(string @Username)
        {
            bool Reslut = false;


            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {
                using (SqlCommand command = new SqlCommand("SP_isUserExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Username", Username);
                    connection.Open();

                    SqlParameter Outparmeter = new SqlParameter("@Result", SqlDbType.Bit);
                    Outparmeter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(Outparmeter);

                    command.ExecuteNonQuery();

                    Reslut = (bool)command.Parameters["@Result"].Value;

                }
            }
            return Reslut;
        }
        public static bool FindUserById(int UserID ,ref string username,ref string Role,ref string Password,ref string Phone)
        {
            bool Fund = false;
            using (SqlConnection conn = new SqlConnection(AcesseceData.CountionString))
            {
                string sql = "SELECT * FROM dbo.FindUserbyID(@UserID)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fund = true;
                            username = reader["Username"].ToString();
                            Role = reader["Role"].ToString();
                            Password = reader["Password"].ToString();
                            Phone = reader["Phone"].ToString();

                         
                        }
                    }
                }
            }
            return Fund;
            }

        public static bool FindUserWithoutPassword(int UserID, ref string username, ref string Role, ref string Phone)
        {
            bool Fund = false;
            using (SqlConnection connection = new SqlConnection(AcesseceData.CountionString))
            {
              
                using (SqlCommand command = new SqlCommand("SP_FindUserWithoutPassword", connection ))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fund = true;
                            username = reader["Username"].ToString();
                            Role = reader["Role"].ToString();                          
                            Phone = reader["Phone"].ToString();


                        }
                    }
                }
            }
            return Fund;
        }
        public static bool DelectUser(int UserID,int Cerentuser)
        {
            int delect = 0;

            using(SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DelectUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure ;

                    command.Parameters.AddWithValue("@PrefromBY", Cerentuser);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();

                    delect =command.ExecuteNonQuery();

                }

            }
            return delect ==0 ? false : true;
        }

        public static bool UpdateUser(int UserID ,int Cerentuser,string UserName ,string Password  , string Role,string Phone)
        {
            bool Update = false;

            using( SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString) )
            {
                using(SqlCommand command = new SqlCommand("SP_Updateuser",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PrefromBY", Cerentuser);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    connection.Open();

                    SqlParameter OutParamter = new SqlParameter("@Result",SqlDbType.Bit);
                    OutParamter.Direction = ParameterDirection.Output;

                    command.Parameters.Add(OutParamter);
                    command.ExecuteScalar();

                    Update = Convert.ToBoolean(command.Parameters["@Result"].Value);
                }
            }
            return Update;
        }

        public static bool Checklogin(string Username, string Password,ref string Role,ref int UserID,ref string Phone)
        {
            bool Check = false;

            using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckLogin", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            Check = true;
                            Role = (string)reader["Role"];
                            Phone = (string)reader["Phone"];
                            UserID = (int)reader["UserID"];
                        }
                    }
                    

                }
            }
            return Check;
        }

        public static async Task<DataTable> GetAllUser()
        {

            return await Task.Run(() =>
            {


                DataTable AllUser = new DataTable();



                using (SqlConnection connection = new SqlConnection(SmartAppDatabasenes.AcesseceData.CountionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AllUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                            AllUser.Load(reader);

                    }
                }
                return AllUser;
            });
        }
    }
}
