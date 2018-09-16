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
    public partial class SummaryControl : UserControl
    {
        public SummaryControl()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            //to list all Active Rooms

            pnlStart.BringToFront();

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

            //to list all active rooms
            SubjectForStudents.Rooms = new string[100];
            md.CSD_ListActiveRoom();
            for (int x = 0; x < 50; x++)//set to 50 loop
            {
                if (SubjectForStudents.Rooms[x] != "")
                    cboRoom.Items.Add(SubjectForStudents.Rooms[x]);
            }

            //to list all sections
            SubjectForStudents.Sections = new string[100];
            md.CSD_ListAllSections();
            for (int x = 0; x < 50; x++)//set to 50 loop
            {
                if (SubjectForStudents.Sections[x] != "")
                    cboSectionName.Items.Add(SubjectForStudents.Sections[x]);
            }

            //to list all professor that have their scheduled
            SubjectForStudents.ProfessorsName = new string[100];
            md.CSD_ListAllProfessors();
            for (int x = 0; x < 50; x++)//set to 50 loop
            {
                if (SubjectForStudents.ProfessorsName[x] != "")
                    cboProfessorName.Items.Add(SubjectForStudents.ProfessorsName[x]);
            }

            cboSemester.Text = ClassSchedule_Data.semester;
            cboSchoolYear.Text = ClassSchedule_Data.schoolYear;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            SummaryData.course = ClassSchedule_Data.course;
            SummaryData.year = ClassSchedule_Data.year;
            SummaryData.section = ClassSchedule_Data.section;
            SummaryData.semester = cboSemester.Text;
            SummaryData.schoolYear = cboSchoolYear.Text;
        }

        private void btnOKk_Click(object sender, EventArgs e)
        {

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClassSchedule_Data.roomCode = cboRoom.SelectedItem.ToString();

            SummaryData.roomCode = cboRoom.Text;

            SummaryRoomScheduledControl room = new SummaryRoomScheduledControl();
            pnlRoomSummary.Controls.Clear();
            pnlRoomSummary.Controls.Add(room);
        }

        private void cboSectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SummaryData.section = cboSectionName.Text;

            SummaryStudentScheduledControl section = new SummaryStudentScheduledControl();
            pnlSection.Controls.Clear();
            pnlSection.Controls.Add(section);
        }

        private void cboProfessorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SummaryData.professor = cboProfessorName.Text;

            SummaryProfessorScheduledControl professor = new SummaryProfessorScheduledControl();
            pnlProfessor.Controls.Clear();
            pnlProfessor.Controls.Add(professor);
        }
    }
}