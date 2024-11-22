using Hospital.data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {
        private ApplicationDBcontext _dbcontext = new ApplicationDBcontext();
        public IActionResult BookAppointment()
        {
            var Doctors=_dbcontext.Doctors.ToList();
            return View(Doctors);

        }

        public IActionResult CompeletAppointment(int id)
        {
            var doctor = _dbcontext.Doctors.Find(id);



             return View(doctor);

           

        }

        public IActionResult CreateAppointment(string PatientName, DateOnly AppointmentDate, TimeOnly AppointmentTime)
        {
            _dbcontext.Appointments.Add(new () {
                PatientName = PatientName,
                AppointmentDate = AppointmentDate,
                AppointmentTime = AppointmentTime
               

            });
            _dbcontext.SaveChanges();

            return RedirectToAction("Appointment");
        }


        public IActionResult Appointment()
        {
           var appointment=_dbcontext.Appointments.ToList();

            return View(model:appointment);
        }


        

        
    }
}
