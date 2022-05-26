namespace HospitalStaff.Interfaces
{
    public interface IShift
    {
        int Shift { get; set; }
        double CalculateShift();
    }
}
