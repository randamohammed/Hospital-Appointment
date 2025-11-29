using SmartAppointment.Appointment;
using SmartAppointment.User;
using System;
using System.Windows.Forms;

namespace SmartAppointment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Databusiness.Mappers.AutoMapperConfigs.Initialize();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSingin());
        }
    }
}
