using HospitalStaff.Interfaces;

namespace HospitalStaff.Entities
{
    public class SurgicalDoctor : Doctor, IExtraPay
    {
        public int ExtraPay { get; set; }

        public double CalculateExtraPay()
        {
            try
            {
                return 3 * (Salary / 2);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
