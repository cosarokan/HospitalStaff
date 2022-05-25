using HospitalStaff.AbstractEntitites;
using HospitalStaff.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalStaff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTypeOfDoctor();
            ShowDoctorGenderType();
            ShowNurseGenderType();
            Doctor.Doctors = new List<Doctor>();
            Nurse.Nurses = new List<Nurse>();   
            
        }
        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorTCIdentity.Text == "" || txtDoctorName.Text ==  "" || txtDoctorSurname.Text == "" || 
                txtDoctorSalary.Text == "" || txtDoctorPhone.Text == "" || comboBoxDoctorType.Text == "" || 
                 comboBoxDoctorType.Text == "" || comboBoxDoctorGender.Text == "")
            {
                MessageBox.Show("Must not be empty area!");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Doctor doctor = new Doctor();
                    doctor.TCIdentity = txtDoctorTCIdentity.Text;
                    doctor.Name = txtDoctorName.Text;
                    doctor.Surname = txtDoctorSurname.Text;
                    doctor.Salary = Convert.ToInt32(txtDoctorSalary.Text);
                    doctor.Phone = txtDoctorPhone.Text;
                    doctor.TypeOfDoctor = (TypeOfDoctor)comboBoxDoctorType.SelectedIndex;
                    doctor.Shift = Convert.ToInt32(txtDoctorShift.Text);
                    doctor.Gender = (Gender)comboBoxDoctorGender.SelectedIndex;
                    Doctor.Doctors.Add(doctor);
                    MessageBox.Show("Recorded");
                    comboBoxDoctors.Items.Add($"{doctor.Name} " +
                        $"{doctor.Surname}, Doctor Type: {doctor.TypeOfDoctor}, Salary: " +
                        $"{doctor.Salary}, Shift: {doctor.Shift}");
                    ClearDoctorTexts();
                }
            }
        }
        private void btnNurseAdd_Click(object sender, EventArgs e)
        {
            if (txtNurseTCIdentity.Text == "" || txtNurseName.Text == "" || txtNurseSurname.Text == "" ||
                txtNurseSalary.Text == "" || txtNursePhone.Text == "" || txtNurseShift.Text == "" || 
                comboBoxNurseGender.Text == "")
            {
                MessageBox.Show("Must not be empty area!");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Nurse nurse = new Nurse();
                    nurse.TCIdentity = txtNurseTCIdentity.Text;
                    nurse.Name = txtNurseName.Text;
                    nurse.Surname = txtNurseSurname.Text;
                    nurse.Salary = Convert.ToInt32(txtNurseSalary.Text);
                    nurse.Phone = txtNursePhone.Text;
                    nurse.Shift = Convert.ToInt32(txtNurseShift.Text);
                    nurse.Gender = (Gender)comboBoxNurseGender.SelectedIndex;
                    Nurse.Nurses.Add(nurse);
                    MessageBox.Show("Recorded");
                    comboBoxNurses.Items.Add($"{nurse.Name} " +
                        $"{nurse.Surname}, Salary: " +
                        $"{nurse.Salary}, Shift: {nurse.Shift}");
                    ClearNurseTexts();
                }
            }
        }
        void ShowDoctorGenderType()
        {
            string[] gender = Enum.GetNames(typeof(Gender));
            comboBoxDoctorGender.Items.AddRange(gender);
        }
        void ShowNurseGenderType()
        {
            string[] gender = Enum.GetNames(typeof(Gender));
            comboBoxNurseGender.Items.AddRange(gender);
        }
        void ShowTypeOfDoctor()
        {
            string[] typeOfDoctor = Enum.GetNames(typeof(TypeOfDoctor));
            comboBoxDoctorType.Items.AddRange(typeOfDoctor);
        }
        void ClearDoctorTexts()
        {
            txtDoctorTCIdentity.Clear();
            txtDoctorName.Clear();
            txtDoctorSurname.Clear();
            txtDoctorSalary.Clear();
            txtDoctorPhone.Clear();
            comboBoxDoctorType.SelectedIndex = -1;
            comboBoxDoctorGender.SelectedIndex = -1;
            txtDoctorShift.Clear();
        }
        void ClearNurseTexts()
        {
            txtNurseTCIdentity.Clear();
            txtNurseName.Clear();
            txtNurseSurname.Clear();
            txtNurseSalary.Clear();
            txtNursePhone.Clear();
            txtNurseShift.Clear();
            comboBoxNurseGender.SelectedIndex = -1;
            
        }
        private void comboBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSalary.Items.Add(comboBoxDoctors.SelectedItem);
        }

        private void comboBoxNurses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSalary.Items.Add(comboBoxNurses.SelectedItem);
        }
    }
}
