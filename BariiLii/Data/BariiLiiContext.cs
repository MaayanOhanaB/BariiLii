using BariiLii.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BariiLii.Data
{
    public class BariiLiiContext: DbContext
    {
        public BariiLiiContext(DbContextOptions<BariiLiiContext> options): base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<AppointmentSystem> AppointmentSystems { get; set; }
        
    }
}
