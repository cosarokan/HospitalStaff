using System.Windows.Forms;

namespace HospitalStaff.AbstractEntitites
{
    public abstract class Person
    {
        private string _tcIdentity;
        public string TCIdentity 
        {
            get
            {
                return _tcIdentity;
            }
            set 
            {
                if (!IsElevenCharacter(value))
                {
                    MessageBox.Show("TC identity must be eleven digits!");
                }
                _tcIdentity = value;
            } 
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }
        static bool IsElevenCharacter(string text, byte countOfCharacter = 11)
        {
            if (text.Length != countOfCharacter)
            {
                return false;
            }
            return true;
        }
    }
    public enum Gender
    {
        M = 0,
        F = 1
    }
}
