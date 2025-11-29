using SmartAppDatabasenes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Databusiness
{
    public class DataUser
    {
        public int UserID { get; set; }
        public int currentUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
      
        enum enMode { AddNewUser = 0, UpdateUser = 1 }

        enMode _Mode = enMode.AddNewUser;

        public DataUser()
        {
            UserID = 0;
            currentUser = 0;
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
            Phone = "";
            _Mode = enMode.AddNewUser;
        }

        public DataUser(int userID, string username, string password, string role,int currentUser,string Phone)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Role = role;
            this.Phone = Phone;
            this.currentUser = currentUser;
           _Mode = enMode.UpdateUser;
        }

        public DataUser(int userID, string username, string password, string role,string Phone)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Role = role;
            this.Phone = Phone;
            _Mode = enMode.UpdateUser;
        }

        private bool _AddNewUser()
        {
            DataUser user = new DataUser();
            this.UserID =SmartAppDatabasenes.DataUsers.AddNewUser(this.Username,this.Password,this.Role,this.currentUser,this.Phone);       
            return this.UserID != 0;
        }

        private bool _UpdateUser()
        {

            return SmartAppDatabasenes.DataUsers.UpdateUser(this.UserID,this.currentUser,this.Username,this.Password,this.Role,this.Phone);
        }

        public static bool DeleteUser(int UserID, int currentUser)
        {
            return SmartAppDatabasenes.DataUsers.DelectUser(UserID, currentUser);
        }

        public static DataUser  CheackUser(string username , string password)
        {
            string Role = "", Phone ="";
            int Userid = 0;
            if ( SmartAppDatabasenes.DataUsers.Checklogin(username,password,ref Role,ref Userid,ref Phone) )
            {
                return new DataUser(Userid, username, password, Role, Phone);
            }
            else
                return null;
        }

        public static bool IsUserExist(string username)
        {
            return SmartAppDatabasenes.DataUsers.IsUserExist(username);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNewUser:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.UpdateUser;
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                case enMode.UpdateUser:
                    {
                        return _UpdateUser();
                    }
                    
            }
            return false;
        }

     

        public static DataUser FindUserById(int Userid)
        {

            string username = "", Reloe = "", Password = "", Phone = "";

            bool Fund = SmartAppDatabasenes.DataUsers.FindUserById(Userid, ref username, ref Reloe, ref Password,ref Phone);

            if (Fund != false)
                return new DataUser(Userid, username, Password, Reloe, 1, Phone);

            else
                return null;

        }

        public static DataUser FindUserById(int Userid, int CurrentUser)
        {
            string username = "",Reloe = "", Password = "", Phone ="";
           
            bool Fund = SmartAppDatabasenes.DataUsers.FindUserById(Userid,ref username,ref Reloe,ref Password,ref Phone);

            if (Fund != false)
                return new DataUser(Userid, username, Password, Reloe, CurrentUser, Phone);

            else
                return null;


        }


    }
}
