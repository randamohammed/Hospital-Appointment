using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Databusiness
{
    public class DataDocter
    {
       
        public int DocterID { get; set; }
        public string Fullname {  get; set; }
        public string Specialty { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }


        enum Mode { enAddNew =0, enUpdate = 1 }

         private  Mode _Mode = Mode.enAddNew;

        public DataDocter()
        {
            phone = string.Empty;
            Email = string.Empty;
            Specialty = string.Empty;   
            Fullname = string.Empty;
            DocterID = 0;    
            _Mode = Mode.enAddNew;
          
        }

        public DataDocter(string Phone ,string Email,string Specialty,string Fullname,int DocterID)
        {
            this.DocterID = DocterID;
            this.phone = Phone;
            this.Email = Email;
            this.Specialty = Specialty;
            this.Fullname = Fullname;
            _Mode =  Mode.enUpdate ;   
       
        }

        private  bool   _AddNewDocter()
        {
            this.DocterID =SmartAppDatabasenes. DataDocter.AddNewDocter(this.phone,this.Email
                ,this.Specialty,this.Fullname);

            return this.DocterID != 0;
        }

        private bool _UpdateDocter()
        {
            return SmartAppDatabasenes.DataDocter.UpdateDocter(this.DocterID,this.Fullname,this.Specialty,
                this.Email,this.phone);
        }

        public static DataDocter FindDocterById(int DocterID)
        {
            string FullName = "", Phone = "", Emial = "", Specialty = "";

            bool Find = false;

            Find = SmartAppDatabasenes.DataDocter.FindDocterById(DocterID, ref FullName, ref Specialty, ref Emial, ref Phone);
            
            if(Find)
            {
                return new DataDocter(Phone, Emial, Specialty, FullName, DocterID);
            }
            else
            {

                return null;
            }
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case Mode.enAddNew:
                    {
                        if(_AddNewDocter())
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
                        return _UpdateDocter();
                    }
            }
            return false;
        }
        public static bool Delete(int DocterId)
        {
            return SmartAppDatabasenes.DataDocter.DeleteDocter(DocterId);
        }

        public static async Task< List<DataDocter>> GetAllDataDocter()
        {
            DataTable dataTable =await SmartAppDatabasenes.DataDocter.GetAllDoctorsAsync();
            List<DataRow> rows = dataTable.AsEnumerable().ToList();

            // 2. التحويل من List<DataRow> إلى List<DataDocter>
            List<DataDocter> list = Mappers.AutoMapperConfigs.Mapper.Map<List<DataDocter>>(rows);

           return list;
        }

        public static async Task<DataTable> GetAllDocterForCombox()
        {
            return await SmartAppDatabasenes.DataDocter.GetAllDocterForCombox();
        }

    }
}
