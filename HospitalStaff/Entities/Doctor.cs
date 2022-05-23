using HospitalStaff.AbstractEntitites;
using System.Collections.Generic;

namespace HospitalStaff.Entities
{
    public class Doctor : Person
    {
        public int? Shift { get; set; }
        public static List<Doctor> Doctors { get; set; }
        public TypeOfDoctor TypeOfDoctor { get; set; }
        public override string ToString()
        {
            return ($"Doctor's name: {Name} -------- Shift hour: {Shift}");
        }
    }
    public enum TypeOfDoctor : byte
    {
        Doctor = 0,
        AsistantDoctor = 1,
        SurgicalDoctor = 2
    }
}
