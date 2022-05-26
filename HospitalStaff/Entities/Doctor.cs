using HospitalStaff.AbstractEntitites;
using HospitalStaff.Models;
namespace HospitalStaff.Entities
{
    public class Doctor : Person
    {
        public TypeOfDoctor TypeOfDoctor { get; set; }
        public override string ToString()
        {
            return ($"{Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower()} " +
                        $"{Surname.Substring(0, 1).ToUpper() + Surname.Substring(1).ToLower()}, " +
                        $"Doctor Type: {TypeOfDoctor}, Salary: " +
                        $"{Salary}");
        }
    }
}
