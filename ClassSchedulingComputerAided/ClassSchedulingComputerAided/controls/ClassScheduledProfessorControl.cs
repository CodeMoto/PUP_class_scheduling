﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class ClassScheduledProfessorControl : UserControl
    {
        public ClassScheduledProfessorControl()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void ClassScheduledProfessorControl_Load(object sender, EventArgs e)
        {
            pnlStart.BringToFront();

            string fname = md.UsersInformation(usersData.p_id).GetValue(2).ToString();
            string mname = md.UsersInformation(usersData.p_id).GetValue(3).ToString();
            string lname = md.UsersInformation(usersData.p_id).GetValue(4).ToString();

            lblName.Text = fname + " " + mname + " " + lname + "(Class Scheduled)";

            cboSemester.Items.Add("1ST");
            cboSemester.Items.Add("2ND");
            cboSemester.Items.Add("3RD");

            //to fill the school year
            string sy = "";
            DateTime dt = new DateTime(2015, DateTime.Now.Month, DateTime.Now.Day);
            bool flag = true;
            while (flag)
            {
                if (dt.Year != DateTime.Now.Year)
                {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                }
                else
                {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                    flag = false;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmProfessorHomePage prof = new frmProfessorHomePage();
            this.Hide();
            prof.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;

            lblSemester.Text = "[" + cboSemester.Text + " Semester] [SY:" + cboSchoolYear.Text + "]";

            string fname = md.UsersInformation(usersData.p_id).GetValue(2).ToString();
            string mname = md.UsersInformation(usersData.p_id).GetValue(3).ToString();
            string lname = md.UsersInformation(usersData.p_id).GetValue(4).ToString();

            SummaryData.professor = fname + " " + mname + " " + lname;
            SummaryData.semester = cboSemester.Text;
            SummaryData.schoolYear = cboSchoolYear.Text;

            btnSettings.Visible = true;

            profScheduledControl psc = new profScheduledControl();
            pnlProfessor.Controls.Clear();
            pnlProfessor.Controls.Add(psc);
        }

        private void cboSectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
        }
    }
}