using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Databusiness
{
    public class DataPaitent 
    {
        public int PatientId {  get; set; }
        public string fullname { get; set; }
        public DateTime DateOfBarth {  get; set; }
        public DateTime LastUpdatedDate {  get; set; }
        public DateTime RegistrationDate {  get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public string NationalID { get; set; }
        public short Gender { get; set; }
        enum Mode { enAddPaiten =0, enUpdate =1 }

        Mode _Mode = Mode.enAddPaiten;

        public DataPaitent()
        {
            PatientId = 0;
            fullname = string.Empty;
            DateOfBarth = DateTime.MinValue;
            Email = string.Empty;
            phone = string.Empty;
          
            _Mode = Mode.enAddPaiten;
        }

        public DataPaitent(int PatientId, string Fullname, DateTime DateOfBarth, string Email, string Phone,
           string Notes,string Address,string NationalID,short Gender)
        {
            this.PatientId = PatientId;
            this.fullname = Fullname;
            this.DateOfBarth = DateOfBarth;
            this.Email = Email;
            this.phone = Phone;
            this.Notes = Notes;
            this.NationalID = NationalID;
            this.Gender = Gender;
            this.Address = Address;

            _Mode = Mode.enUpdate;
        }

         
        public static DataPaitent FindPaitentByID(int PatientId)
        {
            string Fullname  = " ",Email = "",Phone = "",Address = "", Notes = "", NationalID = "";
                DateTime DateOfBarth = DateTime.Now;
            
            short Gender = 0;

            bool IsFound = SmartAppDatabasenes.DataPatinet.FindPatientByID(PatientId,ref Phone,ref Fullname, ref Email,
                ref DateOfBarth, ref Gender, ref Address, ref NationalID, ref Notes);

            if(IsFound) 
                return new DataPaitent(PatientId,Fullname,DateOfBarth,Email,Phone,Notes,Address,NationalID,Gender);
            else
                return null;

        }

        public static DataPaitent FindPatientByNationalID(string NationalID)
        {
            string Fullname = " ", Email = "", Phone = "", Address = "", Notes = "";
            DateTime DateOfBarth = DateTime.Now;
            short Gender = 0;
            int PatientId = 0;

            bool IsFound = SmartAppDatabasenes.DataPatinet.FindPatientByNationalID(ref PatientId, ref Phone, ref Fullname, ref Email,
                ref DateOfBarth, ref Gender, ref Address,  NationalID, ref Notes);

            if (IsFound)
                return new DataPaitent(PatientId, Fullname, DateOfBarth, Email, Phone, Notes, Address, NationalID, Gender);
            else
                return null;

        }
        private bool _AddPatientAndAppointment()
        {
       
            this.RegistrationDate = DateTime.Now;
               this.PatientId = SmartAppDatabasenes.DataPatinet.AddPatientAndAppointment(this.phone, this.fullname, this.Email,
                this.DateOfBarth,this.Gender,this.Address,this.NationalID,this.Notes, RegistrationDate
                );
            return this.PatientId !=  0;

        }

        private bool Updatapatient()
        {
            return SmartAppDatabasenes.DataPatinet.UpdatePatien(this.PatientId,this.phone, this.fullname, this.Email
               , this.DateOfBarth, this.Gender, this.Address, this.NationalID, this.Notes);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case Mode.enAddPaiten:
                    {
                        if(_AddPatientAndAppointment())
                        {
                            _Mode = Mode.enUpdate;
                            return true;
                        }
                        else
                        {
                            return false;
                        }           
                    }
                    case Mode.enUpdate:
                    {
                        return Updatapatient();
                    }
            }
            return false;
        }

        public static  DataTable GetPatientsPaginated(int pageNumber, int pageSize)
        {
            return SmartAppDatabasenes.DataPatinet.GetPatientsPaginated(pageNumber, pageSize);
        }

        public bool ISPatienExistByNationalID(string NationalID)
        {
         return SmartAppDatabasenes. DataPatinet.ISPatienExistByNationalID(NationalID);
         
        }

        public static bool DeletePatient(int PatientId)
        {
            return SmartAppDatabasenes.DataPatinet.DeletePatient(PatientId);
        }

       public static void GetPatientSummary(ref decimal Blance,ref DateTime RegistrationDate,int PatientId)
        {
            SmartAppDatabasenes.DataPatinet.GetPatientSummary(ref Blance,ref RegistrationDate, PatientId);
        }
    }
}
