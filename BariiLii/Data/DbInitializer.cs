using BariiLii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BariiLii.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BariiLiiContext context)
        {
            context.Database.EnsureCreated();
            if (context.Doctors.Any())
            {
                return; //DB is full already
            }

            //DB is empty
            var doctors = new Doctor[]
            {
                new Doctor{ DId="318465913", FullName="Eyal Moshe", Gender="M", Specialization="Rhinoplasty", Availability=DateTime.Parse("08:00"), Location="Asuta Ashdod, Belinson Petah Tikva", PreviousExprience=10},
                new Doctor{ DId="318465912", FullName="Justin Chembers", Gender="M", Specialization="Rhinoplasty", Availability=DateTime.Parse("20:01"), Location="Asaf Ha-Rofe Rishon Le Zion, Beit Ha-Rofim Tel Aviv", PreviousExprience=15},
                new Doctor{ DId="318465914", FullName="Patrick Dampsi", Gender="M", Specialization="Hyaluronic Acid", Availability=DateTime.Parse("10:00"), Location="Asuta Haifa, Ziv Zefat", PreviousExprience=5},
                new Doctor{ DId="318465919", FullName="Gadi Goldstein", Gender="M", Specialization="Hyaluronic Acid", Availability=DateTime.Parse("22:01"), Location="Rambam Hospital Haifa, Carmel hospital Haifa", PreviousExprience=20},
                new Doctor{ DId="316465920", FullName="Nurit Lerer Ben Hamo", Gender="F", Specialization="Facelift", Availability=DateTime.Parse("8:30"), Location="Volfson hospital Holon, Asaf Ha-Rofe Rishon Le Zion", PreviousExprience=25},
                new Doctor{ DId="316385919", FullName="Helen Katlin", Gender="F", Specialization="Facelift", Availability=DateTime.Parse("20:30"), Location="Kaplan hospital Rehovot, Asuta Tel Aviv", PreviousExprience=15},
                new Doctor{ DId="317165717", FullName="Gil Lahmi", Gender="M", Specialization="Gastro", Availability=DateTime.Parse("7:30"), Location="Asuta Ashdod, Belinson Petah Tikva", PreviousExprience=7},
                new Doctor{ DId="247665729", FullName="Alon Moshe", Gender="M", Specialization="Gastro", Availability=DateTime.Parse("19:31"), Location="Asuta Tel Aviv, Tel Ha-Shomer Ramat Gan", PreviousExprience=15},
                new Doctor{ DId="022165714", FullName="Shaked Roi", Gender="F", Specialization="Orthopedics", Availability=DateTime.Parse("9:30"), Location="Belinson Petah Tikva", PreviousExprience=5},
                new Doctor{ DId="319165896", FullName="Shani Cohen", Gender="F", Specialization="Orthopedics", Availability=DateTime.Parse("21:31"), Location="Kaplan hospital Rehovot, Hadasah Ein Karem Jerusalem", PreviousExprience=12},
                new Doctor{ DId="205465921", FullName="Dani Galmor", Gender="M", Specialization="dentist", Availability=DateTime.Parse("06:45"), Location="Shiba Ramat Gan, Meir Kfar Saba", PreviousExprience=16},
                new Doctor{ DId="022165847", FullName="Arik Bornstein", Gender="M", Specialization="dentist", Availability=DateTime.Parse("18:46"), Location="Kaplan hospital Rehovot, Private clinic Nahariya", PreviousExprience=24},
                new Doctor{ DId="315145815", FullName="Alex Sherman", Gender="M", Specialization="General Medicine", Availability=DateTime.Parse("9:00"), Location="Meir Kfar Sab, Maayanei Ha-Yeshua Bnei Brak", PreviousExprience=10},
                new Doctor{ DId="311145624", FullName="Maya Shaul", Gender="F", Specialization="General Medicine", Availability=DateTime.Parse("21:01"), Location="Asuta Ashdod, Hadasah Ein Karem Jerusalem", PreviousExprience=13}
            };

            foreach (Doctor d in doctors)
            {
                context.Doctors.Add(d);
            }
            context.SaveChanges();
        }
    }
}
