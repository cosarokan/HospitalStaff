using HospitalStaff.Interfaces;

namespace HospitalStaff.Entities
{
    public class AssistantDoctor : Doctor, IShift
    {
        public int Shift { get; set; }

        public double CalculateShift()
        {
            try
            {
                return Shift * ((Salary / 100) * 8);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public override string ToString()
        {
            return ($"{Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower()} " +
                        $"{Surname.Substring(0, 1).ToUpper() + Surname.Substring(1).ToLower()}, " +
                        $"Doctor Type: {TypeOfDoctor}, Salary: " +
                        $"{Salary}, Shift: {Shift}");
        }
    }
}
