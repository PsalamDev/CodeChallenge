using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Pet
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthday { get; set; }
        public double weight { get; set; }
        public DateTime lastAppointmentDate { get; set; }

        public Pet(int id, string name, DateTime birthday, double weight, DateTime lastAppointmentDate)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.weight = weight;
            this.lastAppointmentDate = lastAppointmentDate;
        }
    }
}
 