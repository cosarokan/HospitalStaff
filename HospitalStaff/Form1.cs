using HospitalStaff.AbstractEntitites;
using HospitalStaff.Entities;
using HospitalStaff.Interfaces;
using HospitalStaff.Models;
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
            Data.Doctors = new List<Doctor>();
            Data.Nurses = new List<Nurse>();
        }
        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorTCIdentity.Text == "" || txtDoctorName.Text == "" || txtDoctorSurname.Text == "" ||
                txtDoctorSalary.Text == "" || txtDoctorPhone.Text == "" || comboBoxDoctorType.Text == "" ||
                 comboBoxDoctorType.Text == "" || comboBoxDoctorGender.Text == "")
            {
                MessageBox.Show("Mustn't be empty area!");
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
                    if ((TypeOfDoctor)comboBoxDoctorType.SelectedIndex == TypeOfDoctor.AsistantDoctor)
                    {
                        AssistantDoctor doctor = new AssistantDoctor();
                        doctor.TCIdentity = txtDoctorTCIdentity.Text;
                        if (txtDoctorTCIdentity.TextLength != 11)
                        {
                            MessageBox.Show("TC identity must be eleven digits!");
                            return;
                        }
                        doctor.Name = txtDoctorName.Text;
                        doctor.Surname = txtDoctorSurname.Text;
                        doctor.Salary = Convert.ToInt32(txtDoctorSalary.Text);
                        doctor.Phone = txtDoctorPhone.Text;
                        if (txtDoctorPhone.TextLength != 10)
                        {
                            MessageBox.Show("Phone number must be ten digits!");
                            return;
                        }
                        doctor.TypeOfDoctor = (TypeOfDoctor)comboBoxDoctorType.SelectedIndex;
                        doctor.Shift = Convert.ToInt32(txtDoctorShift.Text);
                        doctor.Gender = (Gender)comboBoxDoctorGender.SelectedIndex;
                        doctor.Title = "Assistant Doctor";
                        Data.Doctors.Add(doctor);
                        comboBoxDoctors.Items.Add(doctor);
                    }
                    else if ((TypeOfDoctor)comboBoxDoctorType.SelectedIndex == TypeOfDoctor.Doctor)
                    {
                        Doctor doctor = new Doctor();
                        doctor.TCIdentity = txtDoctorTCIdentity.Text;
                        if (txtDoctorTCIdentity.TextLength != 11)
                        {
                            MessageBox.Show("TC identity must be eleven digits!");
                            return;
                        }
                        doctor.Name = txtDoctorName.Text;
                        doctor.Surname = txtDoctorSurname.Text;
                        doctor.Salary = Convert.ToInt32(txtDoctorSalary.Text);
                        doctor.Phone = txtDoctorPhone.Text;
                        if (txtDoctorPhone.TextLength != 10)
                        {
                            MessageBox.Show("Phone number must be ten digits!");
                            return;
                        }
                        doctor.TypeOfDoctor = (TypeOfDoctor)comboBoxDoctorType.SelectedIndex;
                        doctor.Gender = (Gender)comboBoxDoctorGender.SelectedIndex;
                        doctor.Title = "Doctor";
                        Data.Doctors.Add(doctor);
                        comboBoxDoctors.Items.Add(doctor);
                    }
                    else if ((TypeOfDoctor)comboBoxDoctorType.SelectedIndex == TypeOfDoctor.SurgicalDoctor)
                    {
                        SurgicalDoctor doctor = new SurgicalDoctor();
                        doctor.TCIdentity = txtDoctorTCIdentity.Text;
                        if (txtDoctorTCIdentity.TextLength != 11)
                        {
                            MessageBox.Show("TC identity must be eleven digits!");
                            return;
                        }
                        doctor.Name = txtDoctorName.Text;
                        doctor.Surname = txtDoctorSurname.Text;
                        doctor.Salary = Convert.ToInt32(txtDoctorSalary.Text);
                        doctor.Phone = txtDoctorPhone.Text;
                        if (txtDoctorPhone.TextLength != 10)
                        {
                            MessageBox.Show("Phone number must be ten digits!");
                            return;
                        }
                        doctor.TypeOfDoctor = (TypeOfDoctor)comboBoxDoctorType.SelectedIndex;
                        doctor.Gender = (Gender)comboBoxDoctorGender.SelectedIndex;
                        doctor.Title = "Surgical Doctor";
                        Data.Doctors.Add(doctor);
                        comboBoxDoctors.Items.Add(doctor);
                    }
                    MessageBox.Show("Recorded");
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
                MessageBox.Show("Mustn't be empty area!");
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
                    if (txtNurseTCIdentity.TextLength != 11)
                    {
                        MessageBox.Show("TC identity must be eleven digits!");
                        return;
                    }
                    nurse.Name = txtNurseName.Text;
                    nurse.Surname = txtNurseSurname.Text;
                    nurse.Salary = Convert.ToInt32(txtNurseSalary.Text);
                    nurse.Phone = txtNursePhone.Text;
                    if (txtNursePhone.TextLength != 10)
                    {
                        MessageBox.Show("Phone number must be ten digits!");
                        return;
                    }
                    nurse.Shift = Convert.ToInt32(txtNurseShift.Text);
                    nurse.Gender = (Gender)comboBoxNurseGender.SelectedIndex;
                    nurse.Title = "Nurse";
                    Data.Nurses.Add(nurse);
                    MessageBox.Show("Recorded");
                    comboBoxNurses.Items.Add(nurse);
                    ClearNurseTexts();
                }
            }
        }
        private void comboBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSalary.Items.Add(comboBoxDoctors.SelectedItem);
        }
        private void comboBoxNurses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSalary.Items.Add(comboBoxNurses.SelectedItem);
        }
        private void buttonSalaryDisplayCalculateShift_Click(object sender, EventArgs e)
        {
            IShift personShift = listBoxSalary.SelectedItem as IShift;
            Person person = (Person)listBoxSalary.SelectedItem;
            if (personShift == null)
            {
                MessageBox.Show($"Select the assistant doctor or nurse!");
            }
            else
            {
                if (personShift == null)
                {
                    MessageBox.Show($"You can't calculate shift money for {person.Title}!");
                    return;
                }
                double result = personShift.CalculateShift();
                MessageBox.Show($"{person.Title} shift money: {result}");
            }

        }
        private void buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor_Click(object sender, EventArgs e)
        {
            IExtraPay personExtra = listBoxSalary.SelectedItem as IExtraPay;
            Person person = (Person)listBoxSalary.SelectedItem;
            if (personExtra == null)
            {
                MessageBox.Show("Select the surgical doctor!");
            }
            else
            {
                double result = personExtra.CalculateExtraPay();
                MessageBox.Show($"{person.Title} extra money: {result}");
            }
        }
        private void comboBoxDoctorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TypeOfDoctor.Doctor) == comboBoxDoctorType.SelectedIndex)
            {
                lblDoctorShiftHour.Enabled = false;
                txtDoctorShift.Enabled = false;
            }
            else if (Convert.ToInt32(TypeOfDoctor.AsistantDoctor) == comboBoxDoctorType.SelectedIndex)
            {
                lblDoctorShiftHour.Enabled = true;
                txtDoctorShift.Enabled = true;
            }
            else if (Convert.ToInt32(TypeOfDoctor.SurgicalDoctor) == comboBoxDoctorType.SelectedIndex)
            {
                lblDoctorShiftHour.Enabled = false;
                txtDoctorShift.Enabled = false;
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
        
    }
}