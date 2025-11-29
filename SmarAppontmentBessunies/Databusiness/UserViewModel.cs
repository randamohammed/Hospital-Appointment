using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SmartAppDatabasenes;

namespace Databusiness
{
    public class UserViewModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }

        public UserViewModel()
        {

        }
        public UserViewModel(int userID, string username,  string role, string Phone)
        {
            UserID = userID;
            Username = username;
            Role = role;
            this.Phone = Phone;
        
        }

      

        public static void GetPatientSummary(ref decimal balance, ref DateTime RegistrationDate, int PatientID)
        {
            DataPatinet.GetPatientSummary(ref balance, ref RegistrationDate, PatientID); 
        }
        public static async Task<List<UserViewModel>> GetAllUserInList()
        {
            var dt = await DataUsers.GetAllUser();

            List<UserViewModel> list = dt.AsEnumerable().Select(row => new UserViewModel((int)row["UserID"], (string)row["Username"], (string)row["Role"],(row["Phone"] ==(object)System.DBNull.Value )?"" : (string)row["Phone"]))
              // 3. تحويل النتيجة إلى قائمة
              .ToList();

            return list;
        }
    }
}
