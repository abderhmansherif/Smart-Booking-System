using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public class ComplitedState : IAppointmentState
    {
        public void CancelledState(AppointmentProcess AppointmentProcess)
        {
            AppointmentProcess.Notifi("you Can Not to Cancel Appointment is Confirmed");
            AppointmentProcess.Notifi("The Appointment is Completed");
        }

        public void ChangeProcess(AppointmentProcess AppointmentProcess,string Appointmentdescription, string AppointmentDate)
        {
            AppointmentProcess.Notifi("You Can Not Change Tha Data, Tha Data is Completed");   
        }

        public void ProcessState(AppointmentProcess AppointmentProcess)
        {
            AppointmentProcess.Notifi("The Appointment is already Completed");
        }
    }
}