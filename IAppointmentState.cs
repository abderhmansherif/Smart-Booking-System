using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public interface IAppointmentState
    {
        void ProcessState(AppointmentProcess AppointmentProcess);
        void CancelledState(AppointmentProcess AppointmentProcess);
        void ChangeProcess(AppointmentProcess AppointmentProcess ,string Appointmentdescription
        , string AppointmentDate);
    }
}