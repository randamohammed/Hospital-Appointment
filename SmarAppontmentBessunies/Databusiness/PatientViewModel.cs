using SmartAppDatabasenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databusiness
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
        public DateTime DateOfBarth { get; set; }
        public string Gender { get; set; }
        public decimal Blance { get; set; }
        public DateTime RegistrationDate { get; set; }

        public PatientViewModel()
        {

        }
        public PatientViewModel(int patientid, string fullname, string phone, DateTime DateOfBarth,
            string Gender, decimal Balance, DateTime RegistrationDate)
        {
            this.phone = phone;
            this.fullname = fullname;
            this.PatientId = patientid;
            this.DateOfBarth = DateOfBarth;
            this.Gender = Gender;
            this.Blance = Balance;
            this.RegistrationDate = RegistrationDate;

               
        }

        public static List<PatientViewModel> GetPatientsPaginated(int pagNumber,int pagsize )
        {
            DataTable dt =  DataPaitent.GetPatientsPaginated(pagNumber,pagsize);
            
            int  dd = dt.Rows.Count;
            List<PatientViewModel> list = dt.AsEnumerable().Select(row => new PatientViewModel
            (
                (int)row["PatientId"],
                (string)row["fullname"],
                row["phone"] == DBNull.Value ? " " :(string)row["phone"],
                Convert.ToDateTime( row["DateOfBirth"]),
                (string)row["Gender"],
                row["Balance"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Balance"]),
                 Convert.ToDateTime( row["RegistrationDate"])
                
            )).ToList();


           return list;
        }

    }
}
