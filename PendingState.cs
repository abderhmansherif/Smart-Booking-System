using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public class PendingState : IAppointmentState
    {
        public void CancelledState(AppointmentProcess AppointmentProcess)
        {
            AppointmentProcess.SetState(new CancelledState());
            AppointmentProcess.Notifi("The Appointment is Canceled");
        }

        public void ChangeProcess(AppointmentProcess AppointmentProcess,string Appointmentdescription, string AppointmentDate)
        {
            AppointmentProcess.Notifi("Changing The Data....");
            AppointmentProcess.SetAppointmentdescription(Appointmentdescription);
            AppointmentProcess.SetAppointmentDate(AppointmentDate);
            AppointmentProcess.Notifi("Tha Data Changed Secessfully.");

        }

        public void ProcessState(AppointmentProcess AppointmentProcess)
        {
            AppointmentProcess.SetState(new ConfirmState());
            AppointmentProcess.Notifi("Now The Appointment is Confirmed");
        }
    }
}