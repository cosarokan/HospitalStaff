namespace HospitalStaff
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddDoctor = new System.Windows.Forms.TabPage();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctorGender = new System.Windows.Forms.ComboBox();
            this.lblDoctorType = new System.Windows.Forms.Label();
            this.comboBoxDoctorType = new System.Windows.Forms.ComboBox();
            this.btnDoctorAdd = new System.Windows.Forms.Button();
            this.txtDoctorShift = new System.Windows.Forms.TextBox();
            this.txtDoctorPhone = new System.Windows.Forms.TextBox();
            this.lblDoctorShiftHour = new System.Windows.Forms.Label();
            this.lblDoctorGender = new System.Windows.Forms.Label();
            this.lblDoctorPhone = new System.Windows.Forms.Label();
            this.txtDoctorSalary = new System.Windows.Forms.TextBox();
            this.lblDoctorSalary = new System.Windows.Forms.Label();
            this.txtDoctorSurname = new System.Windows.Forms.TextBox();
            this.lblDoctorSurname = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtDoctorTCIdentity = new System.Windows.Forms.TextBox();
            this.lblDoctorTCIdentity = new System.Windows.Forms.Label();
            this.tabPageAddNurse = new System.Windows.Forms.TabPage();
            this.comboBoxNurseGender = new System.Windows.Forms.ComboBox();
            this.comboBoxNurses = new System.Windows.Forms.ComboBox();
            this.btnNurseAdd = new System.Windows.Forms.Button();
            this.txtNurseShift = new System.Windows.Forms.TextBox();
            this.lblNurseShift = new System.Windows.Forms.Label();
            this.txtNursePhone = new System.Windows.Forms.TextBox();
            this.lblNurseGender = new System.Windows.Forms.Label();
            this.lblNursePhone = new System.Windows.Forms.Label();
            this.txtNurseSalary = new System.Windows.Forms.TextBox();
            this.lblNurseSalary = new System.Windows.Forms.Label();
            this.txtNurseSurname = new System.Windows.Forms.TextBox();
            this.lblNurseSurname = new System.Windows.Forms.Label();
            this.txtNurseName = new System.Windows.Forms.TextBox();
            this.lblNurseName = new System.Windows.Forms.Label();
            this.txtNurseTCIdentity = new System.Windows.Forms.TextBox();
            this.lblNursetTCIdentity = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSalaryDisplayCalculateShift = new System.Windows.Forms.Button();
            this.listBoxSalary = new System.Windows.Forms.ListBox();
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAddDoctor.SuspendLayout();
            this.tabPageAddNurse.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddDoctor);
            this.tabControl1.Controls.Add(this.tabPageAddNurse);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAddDoctor
            // 
            this.tabPageAddDoctor.Controls.Add(this.comboBoxDoctors);
            this.tabPageAddDoctor.Controls.Add(this.comboBoxDoctorGender);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorType);
            this.tabPageAddDoctor.Controls.Add(this.comboBoxDoctorType);
            this.tabPageAddDoctor.Controls.Add(this.btnDoctorAdd);
            this.tabPageAddDoctor.Controls.Add(this.txtDoctorShift);
            this.tabPageAddDoctor.Controls.Add(this.txtDoctorPhone);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorShiftHour);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorGender);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorPhone);
            this.tabPageAddDoctor.Controls.Add(this.txtDoctorSalary);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorSalary);
            this.tabPageAddDoctor.Controls.Add(this.txtDoctorSurname);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorSurname);
            this.tabPageAddDoctor.Controls.Add(this.txtDoctorName);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorName);
            this.tabPageAddDoctor.Controls.Add(this.txtDoctorTCIdentity);
            this.tabPageAddDoctor.Controls.Add(this.lblDoctorTCIdentity);
            this.tabPageAddDoctor.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddDoctor.Name = "tabPageAddDoctor";
            this.tabPageAddDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDoctor.Size = new System.Drawing.Size(566, 358);
            this.tabPageAddDoctor.TabIndex = 0;
            this.tabPageAddDoctor.Text = "Add Doctor";
            this.tabPageAddDoctor.UseVisualStyleBackColor = true;
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(239, 147);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(243, 21);
            this.comboBoxDoctors.TabIndex = 24;
            this.comboBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctors_SelectedIndexChanged);
            // 
            // comboBoxDoctorGender
            // 
            this.comboBoxDoctorGender.FormattingEnabled = true;
            this.comboBoxDoctorGender.Location = new System.Drawing.Point(105, 298);
            this.comboBoxDoctorGender.Name = "comboBoxDoctorGender";
            this.comboBoxDoctorGender.Size = new System.Drawing.Size(31, 21);
            this.comboBoxDoctorGender.TabIndex = 7;
            // 
            // lblDoctorType
            // 
            this.lblDoctorType.AutoSize = true;
            this.lblDoctorType.Location = new System.Drawing.Point(32, 225);
            this.lblDoctorType.Name = "lblDoctorType";
            this.lblDoctorType.Size = new System.Drawing.Size(66, 13);
            this.lblDoctorType.TabIndex = 21;
            this.lblDoctorType.Text = "Doctor Type";
            // 
            // comboBoxDoctorType
            // 
            this.comboBoxDoctorType.FormattingEnabled = true;
            this.comboBoxDoctorType.Location = new System.Drawing.Point(105, 222);
            this.comboBoxDoctorType.Name = "comboBoxDoctorType";
            this.comboBoxDoctorType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDoctorType.TabIndex = 5;
            // 
            // btnDoctorAdd
            // 
            this.btnDoctorAdd.BackColor = System.Drawing.Color.White;
            this.btnDoctorAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDoctorAdd.Location = new System.Drawing.Point(300, 195);
            this.btnDoctorAdd.Name = "btnDoctorAdd";
            this.btnDoctorAdd.Size = new System.Drawing.Size(116, 43);
            this.btnDoctorAdd.TabIndex = 7;
            this.btnDoctorAdd.Text = "Add Doctor";
            this.btnDoctorAdd.UseVisualStyleBackColor = false;
            this.btnDoctorAdd.Click += new System.EventHandler(this.btnDoctorAdd_Click);
            // 
            // txtDoctorShift
            // 
            this.txtDoctorShift.Location = new System.Drawing.Point(105, 261);
            this.txtDoctorShift.Name = "txtDoctorShift";
            this.txtDoctorShift.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorShift.TabIndex = 6;
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.Location = new System.Drawing.Point(105, 185);
            this.txtDoctorPhone.MaxLength = 10;
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorPhone.TabIndex = 4;
            // 
            // lblDoctorShiftHour
            // 
            this.lblDoctorShiftHour.AutoSize = true;
            this.lblDoctorShiftHour.Location = new System.Drawing.Point(32, 264);
            this.lblDoctorShiftHour.Name = "lblDoctorShiftHour";
            this.lblDoctorShiftHour.Size = new System.Drawing.Size(28, 13);
            this.lblDoctorShiftHour.TabIndex = 0;
            this.lblDoctorShiftHour.Text = "Shift";
            // 
            // lblDoctorGender
            // 
            this.lblDoctorGender.AutoSize = true;
            this.lblDoctorGender.Location = new System.Drawing.Point(32, 307);
            this.lblDoctorGender.Name = "lblDoctorGender";
            this.lblDoctorGender.Size = new System.Drawing.Size(42, 13);
            this.lblDoctorGender.TabIndex = 0;
            this.lblDoctorGender.Text = "Gender";
            // 
            // lblDoctorPhone
            // 
            this.lblDoctorPhone.AutoSize = true;
            this.lblDoctorPhone.Location = new System.Drawing.Point(32, 188);
            this.lblDoctorPhone.Name = "lblDoctorPhone";
            this.lblDoctorPhone.Size = new System.Drawing.Size(38, 13);
            this.lblDoctorPhone.TabIndex = 0;
            this.lblDoctorPhone.Text = "Phone";
            // 
            // txtDoctorSalary
            // 
            this.txtDoctorSalary.Location = new System.Drawing.Point(105, 147);
            this.txtDoctorSalary.Name = "txtDoctorSalary";
            this.txtDoctorSalary.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorSalary.TabIndex = 3;
            // 
            // lblDoctorSalary
            // 
            this.lblDoctorSalary.AutoSize = true;
            this.lblDoctorSalary.Location = new System.Drawing.Point(32, 150);
            this.lblDoctorSalary.Name = "lblDoctorSalary";
            this.lblDoctorSalary.Size = new System.Drawing.Size(36, 13);
            this.lblDoctorSalary.TabIndex = 0;
            this.lblDoctorSalary.Text = "Salary";
            // 
            // txtDoctorSurname
            // 
            this.txtDoctorSurname.Location = new System.Drawing.Point(105, 109);
            this.txtDoctorSurname.Name = "txtDoctorSurname";
            this.txtDoctorSurname.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorSurname.TabIndex = 2;
            // 
            // lblDoctorSurname
            // 
            this.lblDoctorSurname.AutoSize = true;
            this.lblDoctorSurname.Location = new System.Drawing.Point(32, 112);
            this.lblDoctorSurname.Name = "lblDoctorSurname";
            this.lblDoctorSurname.Size = new System.Drawing.Size(49, 13);
            this.lblDoctorSurname.TabIndex = 0;
            this.lblDoctorSurname.Text = "Surname";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(105, 72);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorName.TabIndex = 1;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(32, 75);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(35, 13);
            this.lblDoctorName.TabIndex = 0;
            this.lblDoctorName.Text = "Name";
            // 
            // txtDoctorTCIdentity
            // 
            this.txtDoctorTCIdentity.Location = new System.Drawing.Point(105, 35);
            this.txtDoctorTCIdentity.MaxLength = 11;
            this.txtDoctorTCIdentity.Name = "txtDoctorTCIdentity";
            this.txtDoctorTCIdentity.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorTCIdentity.TabIndex = 0;
            // 
            // lblDoctorTCIdentity
            // 
            this.lblDoctorTCIdentity.AutoSize = true;
            this.lblDoctorTCIdentity.Location = new System.Drawing.Point(32, 38);
            this.lblDoctorTCIdentity.Name = "lblDoctorTCIdentity";
            this.lblDoctorTCIdentity.Size = new System.Drawing.Size(58, 13);
            this.lblDoctorTCIdentity.TabIndex = 0;
            this.lblDoctorTCIdentity.Text = "TC Identity";
            // 
            // tabPageAddNurse
            // 
            this.tabPageAddNurse.Controls.Add(this.comboBoxNurseGender);
            this.tabPageAddNurse.Controls.Add(this.comboBoxNurses);
            this.tabPageAddNurse.Controls.Add(this.btnNurseAdd);
            this.tabPageAddNurse.Controls.Add(this.txtNurseShift);
            this.tabPageAddNurse.Controls.Add(this.lblNurseShift);
            this.tabPageAddNurse.Controls.Add(this.txtNursePhone);
            this.tabPageAddNurse.Controls.Add(this.lblNurseGender);
            this.tabPageAddNurse.Controls.Add(this.lblNursePhone);
            this.tabPageAddNurse.Controls.Add(this.txtNurseSalary);
            this.tabPageAddNurse.Controls.Add(this.lblNurseSalary);
            this.tabPageAddNurse.Controls.Add(this.txtNurseSurname);
            this.tabPageAddNurse.Controls.Add(this.lblNurseSurname);
            this.tabPageAddNurse.Controls.Add(this.txtNurseName);
            this.tabPageAddNurse.Controls.Add(this.lblNurseName);
            this.tabPageAddNurse.Controls.Add(this.txtNurseTCIdentity);
            this.tabPageAddNurse.Controls.Add(this.lblNursetTCIdentity);
            this.tabPageAddNurse.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddNurse.Name = "tabPageAddNurse";
            this.tabPageAddNurse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddNurse.Size = new System.Drawing.Size(566, 358);
            this.tabPageAddNurse.TabIndex = 1;
            this.tabPageAddNurse.Text = "Add Nurse";
            this.tabPageAddNurse.UseVisualStyleBackColor = true;
            // 
            // comboBoxNurseGender
            // 
            this.comboBoxNurseGender.FormattingEnabled = true;
            this.comboBoxNurseGender.Location = new System.Drawing.Point(105, 251);
            this.comboBoxNurseGender.Name = "comboBoxNurseGender";
            this.comboBoxNurseGender.Size = new System.Drawing.Size(31, 21);
            this.comboBoxNurseGender.TabIndex = 6;
            // 
            // comboBoxNurses
            // 
            this.comboBoxNurses.FormattingEnabled = true;
            this.comboBoxNurses.Location = new System.Drawing.Point(249, 141);
            this.comboBoxNurses.Name = "comboBoxNurses";
            this.comboBoxNurses.Size = new System.Drawing.Size(233, 21);
            this.comboBoxNurses.TabIndex = 21;
            this.comboBoxNurses.SelectedIndexChanged += new System.EventHandler(this.comboBoxNurses_SelectedIndexChanged);
            // 
            // btnNurseAdd
            // 
            this.btnNurseAdd.BackColor = System.Drawing.Color.White;
            this.btnNurseAdd.Location = new System.Drawing.Point(301, 187);
            this.btnNurseAdd.Name = "btnNurseAdd";
            this.btnNurseAdd.Size = new System.Drawing.Size(116, 43);
            this.btnNurseAdd.TabIndex = 7;
            this.btnNurseAdd.Text = "Add Nurse";
            this.btnNurseAdd.UseVisualStyleBackColor = false;
            this.btnNurseAdd.Click += new System.EventHandler(this.btnNurseAdd_Click);
            // 
            // txtNurseShift
            // 
            this.txtNurseShift.Location = new System.Drawing.Point(105, 213);
            this.txtNurseShift.Name = "txtNurseShift";
            this.txtNurseShift.Size = new System.Drawing.Size(100, 20);
            this.txtNurseShift.TabIndex = 5;
            // 
            // lblNurseShift
            // 
            this.lblNurseShift.AutoSize = true;
            this.lblNurseShift.Location = new System.Drawing.Point(32, 219);
            this.lblNurseShift.Name = "lblNurseShift";
            this.lblNurseShift.Size = new System.Drawing.Size(28, 13);
            this.lblNurseShift.TabIndex = 18;
            this.lblNurseShift.Text = "Shift";
            // 
            // txtNursePhone
            // 
            this.txtNursePhone.Location = new System.Drawing.Point(105, 177);
            this.txtNursePhone.MaxLength = 10;
            this.txtNursePhone.Name = "txtNursePhone";
            this.txtNursePhone.Size = new System.Drawing.Size(100, 20);
            this.txtNursePhone.TabIndex = 4;
            // 
            // lblNurseGender
            // 
            this.lblNurseGender.AutoSize = true;
            this.lblNurseGender.Location = new System.Drawing.Point(32, 259);
            this.lblNurseGender.Name = "lblNurseGender";
            this.lblNurseGender.Size = new System.Drawing.Size(42, 13);
            this.lblNurseGender.TabIndex = 5;
            this.lblNurseGender.Text = "Gender";
            // 
            // lblNursePhone
            // 
            this.lblNursePhone.AutoSize = true;
            this.lblNursePhone.Location = new System.Drawing.Point(32, 187);
            this.lblNursePhone.Name = "lblNursePhone";
            this.lblNursePhone.Size = new System.Drawing.Size(38, 13);
            this.lblNursePhone.TabIndex = 6;
            this.lblNursePhone.Text = "Phone";
            // 
            // txtNurseSalary
            // 
            this.txtNurseSalary.Location = new System.Drawing.Point(105, 141);
            this.txtNurseSalary.Name = "txtNurseSalary";
            this.txtNurseSalary.Size = new System.Drawing.Size(100, 20);
            this.txtNurseSalary.TabIndex = 3;
            // 
            // lblNurseSalary
            // 
            this.lblNurseSalary.AutoSize = true;
            this.lblNurseSalary.Location = new System.Drawing.Point(32, 147);
            this.lblNurseSalary.Name = "lblNurseSalary";
            this.lblNurseSalary.Size = new System.Drawing.Size(36, 13);
            this.lblNurseSalary.TabIndex = 7;
            this.lblNurseSalary.Text = "Salary";
            // 
            // txtNurseSurname
            // 
            this.txtNurseSurname.Location = new System.Drawing.Point(105, 105);
            this.txtNurseSurname.Name = "txtNurseSurname";
            this.txtNurseSurname.Size = new System.Drawing.Size(100, 20);
            this.txtNurseSurname.TabIndex = 2;
            // 
            // lblNurseSurname
            // 
            this.lblNurseSurname.AutoSize = true;
            this.lblNurseSurname.Location = new System.Drawing.Point(32, 108);
            this.lblNurseSurname.Name = "lblNurseSurname";
            this.lblNurseSurname.Size = new System.Drawing.Size(49, 13);
            this.lblNurseSurname.TabIndex = 7;
            this.lblNurseSurname.Text = "Surname";
            // 
            // txtNurseName
            // 
            this.txtNurseName.Location = new System.Drawing.Point(105, 69);
            this.txtNurseName.Name = "txtNurseName";
            this.txtNurseName.Size = new System.Drawing.Size(100, 20);
            this.txtNurseName.TabIndex = 1;
            // 
            // lblNurseName
            // 
            this.lblNurseName.AutoSize = true;
            this.lblNurseName.Location = new System.Drawing.Point(32, 72);
            this.lblNurseName.Name = "lblNurseName";
            this.lblNurseName.Size = new System.Drawing.Size(35, 13);
            this.lblNurseName.TabIndex = 8;
            this.lblNurseName.Text = "Name";
            // 
            // txtNurseTCIdentity
            // 
            this.txtNurseTCIdentity.Location = new System.Drawing.Point(105, 33);
            this.txtNurseTCIdentity.MaxLength = 11;
            this.txtNurseTCIdentity.Name = "txtNurseTCIdentity";
            this.txtNurseTCIdentity.Size = new System.Drawing.Size(100, 20);
            this.txtNurseTCIdentity.TabIndex = 0;
            // 
            // lblNursetTCIdentity
            // 
            this.lblNursetTCIdentity.AutoSize = true;
            this.lblNursetTCIdentity.Location = new System.Drawing.Point(32, 36);
            this.lblNursetTCIdentity.Name = "lblNursetTCIdentity";
            this.lblNursetTCIdentity.Size = new System.Drawing.Size(58, 13);
            this.lblNursetTCIdentity.TabIndex = 9;
            this.lblNursetTCIdentity.Text = "TC Identity";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor);
            this.tabPage1.Controls.Add(this.buttonSalaryDisplayCalculateShift);
            this.tabPage1.Controls.Add(this.listBoxSalary);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 358);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Salary Display";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSalaryDisplayCalculateShift
            // 
            this.buttonSalaryDisplayCalculateShift.BackColor = System.Drawing.Color.White;
            this.buttonSalaryDisplayCalculateShift.Location = new System.Drawing.Point(156, 256);
            this.buttonSalaryDisplayCalculateShift.Name = "buttonSalaryDisplayCalculateShift";
            this.buttonSalaryDisplayCalculateShift.Size = new System.Drawing.Size(101, 45);
            this.buttonSalaryDisplayCalculateShift.TabIndex = 2;
            this.buttonSalaryDisplayCalculateShift.Text = "Calculate Shift";
            this.buttonSalaryDisplayCalculateShift.UseVisualStyleBackColor = false;
            this.buttonSalaryDisplayCalculateShift.Click += new System.EventHandler(this.buttonSalaryDisplayCalculateShift_Click);
            // 
            // listBoxSalary
            // 
            this.listBoxSalary.FormattingEnabled = true;
            this.listBoxSalary.Location = new System.Drawing.Point(94, 40);
            this.listBoxSalary.Name = "listBoxSalary";
            this.listBoxSalary.Size = new System.Drawing.Size(360, 199);
            this.listBoxSalary.TabIndex = 1;
            // 
            // buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor
            // 
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.BackColor = System.Drawing.Color.White;
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.Location = new System.Drawing.Point(295, 256);
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.Name = "buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor";
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.Size = new System.Drawing.Size(101, 43);
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.TabIndex = 3;
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.Text = "Calculate Extra Pay";
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.UseVisualStyleBackColor = false;
            this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor.Click += new System.EventHandler(this.buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddDoctor.ResumeLayout(false);
            this.tabPageAddDoctor.PerformLayout();
            this.tabPageAddNurse.ResumeLayout(false);
            this.tabPageAddNurse.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddDoctor;
        private System.Windows.Forms.TabPage tabPageAddNurse;
        private System.Windows.Forms.TextBox txtDoctorPhone;
        private System.Windows.Forms.Label lblDoctorGender;
        private System.Windows.Forms.Label lblDoctorPhone;
        private System.Windows.Forms.TextBox txtDoctorSurname;
        private System.Windows.Forms.Label lblDoctorSurname;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorTCIdentity;
        private System.Windows.Forms.Label lblDoctorTCIdentity;
        private System.Windows.Forms.TextBox txtNursePhone;
        private System.Windows.Forms.Label lblNurseGender;
        private System.Windows.Forms.Label lblNursePhone;
        private System.Windows.Forms.TextBox txtNurseSurname;
        private System.Windows.Forms.Label lblNurseSurname;
        private System.Windows.Forms.TextBox txtNurseName;
        private System.Windows.Forms.Label lblNurseName;
        private System.Windows.Forms.TextBox txtNurseTCIdentity;
        private System.Windows.Forms.Label lblNursetTCIdentity;
        private System.Windows.Forms.Label lblDoctorType;
        private System.Windows.Forms.ComboBox comboBoxDoctorType;
        private System.Windows.Forms.TextBox txtDoctorShift;
        private System.Windows.Forms.Label lblDoctorShiftHour;
        private System.Windows.Forms.TextBox txtNurseShift;
        private System.Windows.Forms.Label lblNurseShift;
        private System.Windows.Forms.Button btnNurseAdd;
        private System.Windows.Forms.ComboBox comboBoxDoctorGender;
        private System.Windows.Forms.TextBox txtDoctorSalary;
        private System.Windows.Forms.Label lblDoctorSalary;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDoctorAdd;
        private System.Windows.Forms.Button buttonSalaryDisplayCalculateShift;
        private System.Windows.Forms.ComboBox comboBoxNurses;
        private System.Windows.Forms.ComboBox comboBoxNurseGender;
        private System.Windows.Forms.TextBox txtNurseSalary;
        private System.Windows.Forms.Label lblNurseSalary;
        private System.Windows.Forms.ListBox listBoxSalary;
        private System.Windows.Forms.Button buttonSalaryDisplayCalculateExtraPayForSurgicalDoctor;
    }
}

