using HospitalStaff.Models;
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
                _tcIdentity = value;
            } 
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        private string _phone;
        public string Phone 
        {
            get 
            {
                return _phone;
            }
            set 
            {
                if (!IsTenCharacter(value))
                _phone = value;
            } 
        }
        public int Salary { get; set; }
        public Gender Gender { get; set; }
        public string Title { get; set; }
        public static bool IsElevenCharacter(string text, byte countOfCharacter = 11)
        {
            if (text.Length != countOfCharacter)
            {
                return false;
            }
            return true;
        }
        static bool IsTenCharacter(string text, byte countOfCharacter = 10)
        {
            if (text.Length != countOfCharacter)
            {
                return false;
            }
            return true;
        }
    }

}
