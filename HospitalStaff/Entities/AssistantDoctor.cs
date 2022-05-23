using HospitalStaff.Interfaces;

namespace HospitalStaff.Entities
{
    public class AssistantDoctor : Doctor, IShift
    {
        public double CalculateShift(byte hour = 15)
        {
            try
            {
                return hour * ((Salary / 100) * 8);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
