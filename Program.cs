namespace Project
{
    internal class Program
    {
        static void Main ()
        {
            Appointment appointment = new Appointment ();
            AppointmentProcess appointmentProcess= new AppointmentProcess (appointment);

            appointmentProcess.StateNotification += (string message) => System.Console.WriteLine(message);

            List<string> appointments = new List<string>();

            while(true)
            {
                System.Console.WriteLine("Welcome To Smart Booking System");
                System.Console.WriteLine("Choose an option:");
                System.Console.WriteLine("1) Add New Appointment");
                System.Console.WriteLine("2) Confirm Appointment");
                System.Console.WriteLine("3) Complete Appointment");
                System.Console.WriteLine("4) Cancel Appointment");
                System.Console.WriteLine("5) Change Appointment data");
                System.Console.WriteLine("6) Show All Appointments");
                System.Console.WriteLine("7) Exit ");

                string choice = Console.ReadLine ();

                switch (choice) 
                {
                    case "1":
                        System.Console.WriteLine("Enter The Appointment Description");
                        string Description = Console.ReadLine (); 
                        System.Console.WriteLine("Enter The Appointment date (DD/MM/YY)");
                        string date = Console.ReadLine ();

                        appointmentProcess.SetAppointmentdescription (Description);
                        appointmentProcess.SetAppointmentDate (date);
                        appointments.Add(appointmentProcess.GetAppointmentScheduled());

                        System.Console.WriteLine("The new Appointment sets Secussfully");
                        
                        break;
                    case "2":
                        appointmentProcess.Process();
                        break;
                    case "3":
                         appointmentProcess.Process();
                        break;
                    case "4":
                        appointmentProcess.Cancel();
                        break;
                    case "5":
                        System.Console.WriteLine("Enter The Appointment Description");
                        string newDescription = Console.ReadLine ();

                        System.Console.WriteLine("Enter The Appointment date (DD/MM/YY)");
                        string newdate = Console.ReadLine();

                        appointmentProcess.Change(newDescription,newdate);

                        appointments[appointments.Count-1] = appointmentProcess.GetAppointmentScheduled();
                        break;
                    case "6":
                        foreach(var item in appointments)
                        {
                            System.Console.WriteLine(item);
                        }
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Invalid Input, Please Try Again");
                        break;
                }
                
            }

        }
    }
}
/*
    --> interface (IAppointmentState)
    {   

        ProcessState():method
        cancelledState():Method
    }
    --> class (Pending State)
    --> class (confirm State)
    --> class (complited State)
    --> class (Cancelled State)

    --> Context --> class (Appointment)
    {   
        Delegate to Notifi
        IBookingState : Field
        Appointmentdescription: field
        Appointment Date: field
        AppointmentScheduled: Appointmentdescription - Appointment Date
        SetState : Method
        Notify: Method


        Process: Method
        Cancele: Method 

    }
     Add New Appointment
     Confirm Appointment
     Complete Appointment
     Cancel Appointment
     Show All Appointments
     Exit
*/
