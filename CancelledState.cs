using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public class CancelledState : IAppointmentState
    {
        public void ChangeProcess(AppointmentProcess AppointmentProcess,string Appointmentdescription, string AppointmentDate)
        {
            AppointmentProcess.Notifi("You Can Not Change Data With Canceled Appointment");
        }

        public void ProcessState(AppointmentProcess AppointmentProcess)
        {
            AppointmentProcess.Notifi("You Can Not Process State With Canceled Appointment");
        }

        void IAppointmentState.CancelledState(AppointmentProcess AppointmentProcess)
        {
            AppointmentProcess.Notifi("The Appointment is already Canceled");
        }
    }
}