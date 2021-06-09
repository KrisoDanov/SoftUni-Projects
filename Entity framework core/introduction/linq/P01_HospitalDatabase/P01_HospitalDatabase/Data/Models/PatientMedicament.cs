using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class PatientMedicament
    {
        public PatientMedicament()
        {
            Patients = new HashSet<Patient>();
            Medicaments = new HashSet<Medicament>();
        }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Medicament> Medicaments { get; set; }
    }
}
