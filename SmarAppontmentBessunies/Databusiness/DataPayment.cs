using Databasenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databusiness
{
    public class DataPayment
    {
        public int Patientid { get; set; }
        public int AppointmentId { get; set; }
        public float Amount { get; set; }
        public string Note { get; set; }
        enum Mode { Add = 0, Update = 1 }
        Mode _Mode;

        public DataPayment()
        {
            Patientid = 0;
            AppointmentId = 0;
            Amount = 0;
             Note = "";
            _Mode = Mode.Add;

        }

        public DataPayment(int Patientid, int AppointmentId, float Amount, string Note)
        {
            this.Patientid = Patientid;
            this.AppointmentId = AppointmentId;
            this.Amount = Amount;
            this.Note = Note;
            _Mode = Mode.Update;

        }

        private bool _AddnewPayment()
        {
            this.Patientid =  Payment.AddNewPayment(this.Patientid,this.AppointmentId,this.Amount,this.Note);

            return this.Patientid != 0;
        }

    }
}
