using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databusiness
{
    public class DataAppointment
    {
        public int PaitentID {  get; set; }
        public int DocterID {  get; set; }
        public int AppointmentID {  get; set; }
        public DateTime AppointmentDate {  get; set; }
        public DateTime DataeTo {  get; set; }
        public DateTime DateFrom {  get; set; }
        public string Status { get; set; }
        public string ReasonForVisit { get; set; }

        enum Mode { enAddnewAppointment = 0 , UpdateAppointment =1}
       Mode _Mode = Mode.enAddnewAppointment;

        public DataAppointment() 
        {
            PaitentID = 0;
            DocterID = 0;
            AppointmentID = 0;
            AppointmentDate = DateTime.Now;    
            DataeTo = DateTime.Now;
            DateFrom = DateTime.Now;
            Status = string.Empty;

            _Mode = Mode.enAddnewAppointment;
        }

        public DataAppointment(int paitentID, int docterID, int appointmentID, DateTime appointmentDate, DateTime dataeTo, DateTime dateFrom, string status,string reasonForVisit)
        {
            PaitentID = paitentID;
            DocterID = docterID;
            AppointmentID = appointmentID;
            AppointmentDate = appointmentDate;
            DataeTo = dataeTo;
            DateFrom = dateFrom;
            Status = status;
            _Mode = Mode.UpdateAppointment;
            ReasonForVisit = reasonForVisit;
        }

       private bool _AddNewPaitend()
        {
            this.AppointmentID = SmartAppDatabasenes.DataAppointment.AddAppointment(this.PaitentID, this.DocterID, this.DataeTo,
                this.DateFrom,this.Status, this.ReasonForVisit);
            return this.AppointmentID != 0;
        }

        public static async Task< DataTable> GetAllPatientList()
        {
            return await SmartAppDatabasenes.DataAppointment.GetAllAppointment();

        }

    }
}
