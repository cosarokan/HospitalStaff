using HospitalStaff.AbstractEntitites;
using HospitalStaff.Interfaces;
using System.Collections.Generic;

namespace HospitalStaff.Entities
{
    public class Nurse : Person, IShift
    {
        public static List<Nurse> Nurses { get; set; }
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
