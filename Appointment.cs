using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    // context
    public delegate void StateNotification(string message);
    
    public class Appointment
    {
        public string Appointmentdescription { get; set; }
        public string AppointmentDate { get; set; }

        public Appointment ()
        {
            Appointmentdescription = "";
            AppointmentDate = "";
        }

        public string AppointmentScheduled() => $"{AppointmentDate}-{Appointmentdescription}";

        public string GetAppointmentdescription() => Appointmentdescription;

        public string GetAppointmentDate() => AppointmentDate;

        public void SetAppointmentdescription(string appointmentdescription)
        {
            Appointmentdescription = appointmentdescription;
        }
        public void SetAppointmentDate(string appointmentDate)
        {
            AppointmentDate = appointmentDate;
        }
    }
}