using HospitalStaff.AbstractEntitites;
using HospitalStaff.Interfaces;

namespace HospitalStaff.Entities
{
    public class Nurse : Person, IShift
    {
        private int _shift;
        public int Shift 
        {
            get 
            {
                return _shift;
            } 
            set 
            {
                if (value == 0)
                {
                    value = 20;
                }
                _shift = value;
            } 
        }

        public override string ToString()
        {
            return ($"{Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower()} " +
                        $"{Surname.Substring(0, 1).ToUpper() + Surname.Substring(1).ToLower()}, Salary: " +
                        $"{Salary}, Shift: {Shift}");
        }

        public double CalculateShift()
        {
            try
            {
                return Shift * ((Salary / 100) * 4);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
