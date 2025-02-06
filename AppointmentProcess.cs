using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public class AppointmentProcess
    {
        private Appointment _appointment;

        private IAppointmentState _appointmentState;

        public event StateNotification StateNotification;

        public AppointmentProcess(Appointment Appointment)
        {
            _appointment = Appointment;
            _appointmentState = new PendingState();
            
        }
        public string GetAppointmentdescription() => _appointment.GetAppointmentdescription();

        public string GetAppointmentDate() => _appointment.GetAppointmentDate();

        public string GetAppointmentScheduled() => _appointment.AppointmentScheduled();

        public void SetAppointmentdescription(string appointmentdescription)
        {
            _appointment.SetAppointmentdescription(appointmentdescription) ;
        }
        public void SetAppointmentDate(string appointmentDate)
        {
            _appointment.SetAppointmentDate(appointmentDate); 
        }

        public void Notifi(string message)
        {
            StateNotification.Invoke(message);
        }
        public void SetState (IAppointmentState appointmentState)
        {
            _appointmentState = appointmentState;
        }

        public void Process()
        {
            _appointmentState.ProcessState(this);
        }

        
        public void Change(string Appointmentdescription, string AppointmentDate)
        {
            _appointmentState.ChangeProcess(this,Appointmentdescription, AppointmentDate);
        }

        public void Cancel()
        {
            _appointmentState.CancelledState(this);
        }
    }
}