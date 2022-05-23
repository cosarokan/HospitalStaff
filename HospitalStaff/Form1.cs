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
            ViewTypeOfDoctor();
            ViewGenderType();
            Doctor.Doctors = new List<Doctor>();
        }
        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorTCIdentity.Text == " " || txtDoctorName.Text == " " || txtDoctorSurname.Text == " " 
                || txtDoctorPhone.Text == " " || comboBoxDoctorType.Text == " " || 
                 comboBoxDoctorType.Text == " " || comboBoxDoctorGender.Text == " ")
            {
                MessageBox.Show("must not be empty area!");
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.TCIdentity = txtDoctorTCIdentity.Text;
                doctor.Name = txtDoctorName.Text;
                doctor.Surname = txtDoctorSurname.Text;
                doctor.Phone = txtDoctorPhone.Text;
                doctor.TypeOfDoctor = (TypeOfDoctor)comboBoxDoctorType.SelectedIndex;
                doctor.Shift = Convert.ToInt32(txtDoctorShift.Text);
                doctor.Gender = (Gender)comboBoxDoctorGender.SelectedIndex;
                Doctor.Doctors.Add(doctor);
                listBoxDoctors.Items.Add(doctor);
                Clear();
            }
        }
        void ViewGenderType()
        {
            string[] gender = Enum.GetNames(typeof(Gender));
            comboBoxDoctorGender.Items.AddRange(gender);
        }
        void ViewTypeOfDoctor()
        {
            string[] typeOfDoctor = Enum.GetNames(typeof(TypeOfDoctor));
            comboBoxDoctorType.Items.AddRange(typeOfDoctor);
        }
        void Clear()
        {
            txtDoctorTCIdentity.Clear();
            txtDoctorName.Clear();
            txtDoctorSurname.Clear();
            txtDoctorPhone.Clear();
            comboBoxDoctorType.SelectedIndex = -1;
            comboBoxDoctorGender.SelectedIndex = -1;
            txtDoctorShift.Clear();
        }
    }
}
