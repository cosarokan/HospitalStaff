using HospitalStaff.AbstractEntitites;
using HospitalStaff.Interfaces;

namespace HospitalStaff.Entities
{
    public class Nurse : Person, IShift
    {
        public int Shift { get; set; }

        public double CalculateShift(byte hour = 20)
        {
            try
            {
                return hour * ((Shift / 100) * 4);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
