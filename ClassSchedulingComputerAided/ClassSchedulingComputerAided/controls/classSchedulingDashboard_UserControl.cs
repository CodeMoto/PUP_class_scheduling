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
    public partial class classSchedulingDashboard_UserControl : UserControl
    {
        public classSchedulingDashboard_UserControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        

        private void lblLecHours_4_Click(object sender, EventArgs e)
        {

        }

        private void cboDay_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEnd_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboStart_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_LabHours_4_Click(object sender, EventArgs e)
        {

        }

        private void cboRoom_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_4_Click(object sender, EventArgs e)
        {

        }

        private void lblUnits_4_Click(object sender, EventArgs e)
        {

        }

        private void lblCode_4_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnSAVE.Visible = true;

            tbl_pnl_layout.Visible = true;
            btnSet_1.Visible = true;
            btnSet_2.Visible = true;
            btnSet_3.Visible = true;
            btnSet_4.Visible = true;
            btnSet_5.Visible = true;
            btnSet_6.Visible = true;
            btnSet_7.Visible = true;
            btnSet_8.Visible = true;
            btnSet_9.Visible = true;
            btnSet_10.Visible = true;

            //instanciation of an object
            SubjectForStudents.CourseCode = new string[11];
            SubjectForStudents.SubjectDescription = new string[11];
            SubjectForStudents.Units = new string[11];
            SubjectForStudents.LecHrs = new string[11];
            SubjectForStudents.LabHrs = new string[11];

            md.CSD_ShowSubjectsForStudents(cboCourse.SelectedItem.ToString(), cboYear.SelectedItem.ToString(), cboCurriculum.SelectedItem.ToString());//to call function to get data into database

            //call a method to list data
            ListCourseCode();
            ListSubjectDescription();
            ListUnits();
            ListLecHrs();
            ListlabHrs();
            ListProfessors();
            ListStartTime();
            ListEndTime();
            ListDay();
            ListRoom();
            ListSet();
        }

        public void ListCourseCode()//list For CourseCode
        {
            lblCode_1.Text = SubjectForStudents.CourseCode[0];
            lblCode_2.Text = SubjectForStudents.CourseCode[1];
            lblCode_3.Text = SubjectForStudents.CourseCode[2];
            lblCode_4.Text = SubjectForStudents.CourseCode[3];
            lblCode_5.Text = SubjectForStudents.CourseCode[4];
            lblCode_6.Text = SubjectForStudents.CourseCode[5];
            lblCode_7.Text = SubjectForStudents.CourseCode[6];
            lblCode_8.Text = SubjectForStudents.CourseCode[7];
            lblCode_9.Text = SubjectForStudents.CourseCode[8];
            lblCode_10.Text = SubjectForStudents.CourseCode[9];

            lblCode_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            lblCode_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            lblCode_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            lblCode_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            lblCode_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            lblCode_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            lblCode_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            lblCode_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            lblCode_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            lblCode_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListSubjectDescription()//list for description
        {
            lblDescription_1.Text = SubjectForStudents.SubjectDescription[0];
            lblDescription_2.Text = SubjectForStudents.SubjectDescription[1];
            lblDescription_3.Text = SubjectForStudents.SubjectDescription[2];
            lblDescription_4.Text = SubjectForStudents.SubjectDescription[3];
            lblDescription_5.Text = SubjectForStudents.SubjectDescription[4];
            lblDescription_6.Text = SubjectForStudents.SubjectDescription[5];
            lblDescription_7.Text = SubjectForStudents.SubjectDescription[6];
            lblDescription_8.Text = SubjectForStudents.SubjectDescription[7];
            lblDescription_9.Text = SubjectForStudents.SubjectDescription[8];
            lblDescription_10.Text = SubjectForStudents.SubjectDescription[9];

            lblDescription_1.Visible = (SubjectForStudents.SubjectDescription[0] != "") ? true : false;
            lblDescription_2.Visible = (SubjectForStudents.SubjectDescription[1] != "") ? true : false;
            lblDescription_3.Visible = (SubjectForStudents.SubjectDescription[2] != "") ? true : false;
            lblDescription_4.Visible = (SubjectForStudents.SubjectDescription[3] != "") ? true : false;
            lblDescription_5.Visible = (SubjectForStudents.SubjectDescription[4] != "") ? true : false;
            lblDescription_6.Visible = (SubjectForStudents.SubjectDescription[5] != "") ? true : false;
            lblDescription_7.Visible = (SubjectForStudents.SubjectDescription[6] != "") ? true : false;
            lblDescription_8.Visible = (SubjectForStudents.SubjectDescription[7] != "") ? true : false;
            lblDescription_9.Visible = (SubjectForStudents.SubjectDescription[8] != "") ? true : false;
            lblDescription_10.Visible = (SubjectForStudents.SubjectDescription[9] != "") ? true : false;
        }

        public void ListUnits()//list for units
        {
            lblUnits_1.Text = SubjectForStudents.Units[0];
            lblUnits_2.Text = SubjectForStudents.Units[1];
            lblUnits_3.Text = SubjectForStudents.Units[2];
            lblUnits_4.Text = SubjectForStudents.Units[3];
            lblUnits_5.Text = SubjectForStudents.Units[4];
            lblUnits_6.Text = SubjectForStudents.Units[5];
            lblUnits_7.Text = SubjectForStudents.Units[6];
            lblUnits_8.Text = SubjectForStudents.Units[7];
            lblUnits_9.Text = SubjectForStudents.Units[8];
            lblUnits_10.Text = SubjectForStudents.Units[9];

            lblUnits_1.Visible = (SubjectForStudents.Units[0] != "") ? true : false;
            lblUnits_2.Visible = (SubjectForStudents.Units[1] != "") ? true : false;
            lblUnits_3.Visible = (SubjectForStudents.Units[2] != "") ? true : false;
            lblUnits_4.Visible = (SubjectForStudents.Units[3] != "") ? true : false;
            lblUnits_5.Visible = (SubjectForStudents.Units[4] != "") ? true : false;
            lblUnits_6.Visible = (SubjectForStudents.Units[5] != "") ? true : false;
            lblUnits_7.Visible = (SubjectForStudents.Units[6] != "") ? true : false;
            lblUnits_8.Visible = (SubjectForStudents.Units[7] != "") ? true : false;
            lblUnits_9.Visible = (SubjectForStudents.Units[8] != "") ? true : false;
            lblUnits_10.Visible = (SubjectForStudents.Units[9] != "") ? true : false;
        }

        public void ListLecHrs()//list for lecture hours
        {
            lblLecHours_1.Text = SubjectForStudents.LecHrs[0];
            lblLecHours_2.Text = SubjectForStudents.LecHrs[1];
            lblLecHours_3.Text = SubjectForStudents.LecHrs[2];
            lblLecHours_4.Text = SubjectForStudents.LecHrs[3];
            lblLecHours_5.Text = SubjectForStudents.LecHrs[4];
            lblLecHours_6.Text = SubjectForStudents.LecHrs[5];
            lblLecHours_7.Text = SubjectForStudents.LecHrs[6];
            lblLecHours_8.Text = SubjectForStudents.LecHrs[7];
            lblLecHours_9.Text = SubjectForStudents.LecHrs[8];
            lblLecHours_10.Text = SubjectForStudents.LecHrs[9];

            lblLecHours_1.Visible = (SubjectForStudents.LecHrs[0] != "") ? true : false;
            lblLecHours_2.Visible = (SubjectForStudents.LecHrs[1] != "") ? true : false;
            lblLecHours_3.Visible = (SubjectForStudents.LecHrs[2] != "") ? true : false;
            lblLecHours_4.Visible = (SubjectForStudents.LecHrs[3] != "") ? true : false;
            lblLecHours_5.Visible = (SubjectForStudents.LecHrs[4] != "") ? true : false;
            lblLecHours_6.Visible = (SubjectForStudents.LecHrs[5] != "") ? true : false;
            lblLecHours_7.Visible = (SubjectForStudents.LecHrs[6] != "") ? true : false;
            lblLecHours_8.Visible = (SubjectForStudents.LecHrs[7] != "") ? true : false;
            lblLecHours_9.Visible = (SubjectForStudents.LecHrs[8] != "") ? true : false;
            lblLecHours_10.Visible = (SubjectForStudents.LecHrs[9] != "") ? true : false;
        }

        public void ListlabHrs()//List for laboratory hours
        {
            lbl_LabHours_1.Text = SubjectForStudents.LabHrs[0];
            lbl_LabHours_2.Text = SubjectForStudents.LabHrs[1];
            lbl_LabHours_3.Text = SubjectForStudents.LabHrs[2];
            lbl_LabHours_4.Text = SubjectForStudents.LabHrs[3];
            lbl_LabHours_5.Text = SubjectForStudents.LabHrs[4];
            lbl_LabHours_6.Text = SubjectForStudents.LabHrs[5];
            lbl_LabHours_7.Text = SubjectForStudents.LabHrs[6];
            lbl_LabHours_8.Text = SubjectForStudents.LabHrs[7];
            lbl_LabHours_9.Text = SubjectForStudents.LabHrs[8];
            lbl_LabHours_10.Text = SubjectForStudents.LabHrs[9];

            lbl_LabHours_1.Visible = (SubjectForStudents.LabHrs[0] != "") ? true : false;
            lbl_LabHours_2.Visible = (SubjectForStudents.LabHrs[1] != "") ? true : false;
            lbl_LabHours_3.Visible = (SubjectForStudents.LabHrs[2] != "") ? true : false;
            lbl_LabHours_4.Visible = (SubjectForStudents.LabHrs[3] != "") ? true : false;
            lbl_LabHours_5.Visible = (SubjectForStudents.LabHrs[4] != "") ? true : false;
            lbl_LabHours_6.Visible = (SubjectForStudents.LabHrs[5] != "") ? true : false;
            lbl_LabHours_7.Visible = (SubjectForStudents.LabHrs[6] != "") ? true : false;
            lbl_LabHours_8.Visible = (SubjectForStudents.LabHrs[7] != "") ? true : false;
            lbl_LabHours_9.Visible = (SubjectForStudents.LabHrs[8] != "") ? true : false;
            lbl_LabHours_10.Visible = (SubjectForStudents.LabHrs[9] != "") ? true : false;
        }

        public void ListProfessors()//list of professors referring to its course code
        {
            cboProfessor_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboProfessor_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboProfessor_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboProfessor_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboProfessor_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboProfessor_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboProfessor_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboProfessor_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboProfessor_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboProfessor_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListStartTime()//list of start time referring to its course code
        {
            cboStart_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboStart_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboStart_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboStart_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboStart_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboStart_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboStart_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboStart_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboStart_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboStart_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListEndTime()//list of End time referring to its course code
        {
            cboEnd_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboEnd_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboEnd_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboEnd_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboEnd_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboEnd_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboEnd_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboEnd_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboEnd_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboEnd_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListDay()//list of Day referring to its course code
        {
            cboDay_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboDay_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboDay_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboDay_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboDay_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboDay_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboDay_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboDay_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboDay_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboDay_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListRoom()//list of Room referring to its course code
        {
            cboRoom_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboRoom_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboRoom_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboRoom_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboRoom_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboRoom_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboRoom_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboRoom_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboRoom_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboRoom_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListSet()//List of button'set' referring to its course code
        {
            btnSet_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            btnSet_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            btnSet_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            btnSet_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            btnSet_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            btnSet_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            btnSet_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            btnSet_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            btnSet_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            btnSet_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        private void classSchedulingDashboard_UserControl_Load(object sender, EventArgs e)
        {
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Add(rttc);

            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboYear.Items.Clear();
            for (int x = 0; x < md.getCourseYear(cboCourse.SelectedItem.ToString()).Length; x++)
                if (md.getCourseYear(cboCourse.SelectedItem.ToString()).GetValue(x).ToString() != "")
                    cboYear.Items.Add(md.getCourseYear(cboCourse.SelectedItem.ToString()).GetValue(x).ToString());

            for (int x = 0; x < md.getCourseSection(cboCourse.SelectedItem.ToString()).Length; x++)
                if (md.getCourseSection(cboCourse.SelectedItem.ToString()).GetValue(x).ToString() != "")
                    cboSection.Items.Add(md.getCourseSection(cboCourse.SelectedItem.ToString()).GetValue(x).ToString());
        }

        public void SetToEnabled()//method to set button 'set' to enabled
        {
            //set btnSet to Enabled
            btnSet_1.Enabled = true;
            btnSet_2.Enabled = true;
            btnSet_3.Enabled = true;
            btnSet_4.Enabled = true;
            btnSet_5.Enabled = true;
            btnSet_6.Enabled = true;
            btnSet_7.Enabled = true;
            btnSet_8.Enabled = true;
            btnSet_9.Enabled = true;
            btnSet_10.Enabled = true;
        }

        public void SetComboBoxToDisabled()//method to set comboxes to disabled
        {
            //set cboprofessor to disabled
            cboProfessor_1.Enabled = false;
            cboProfessor_2.Enabled = false;
            cboProfessor_3.Enabled = false;
            cboProfessor_4.Enabled = false;
            cboProfessor_5.Enabled = false;
            cboProfessor_6.Enabled = false;
            cboProfessor_7.Enabled = false;
            cboProfessor_8.Enabled = false;
            cboProfessor_9.Enabled = false;
            cboProfessor_10.Enabled = false;
            //set cboStart to disabled
            cboStart_1.Enabled = false;
            cboStart_2.Enabled = false;
            cboStart_3.Enabled = false;
            cboStart_4.Enabled = false;
            cboStart_5.Enabled = false;
            cboStart_6.Enabled = false;
            cboStart_7.Enabled = false;
            cboStart_8.Enabled = false;
            cboStart_9.Enabled = false;
            cboStart_10.Enabled = false;
            //set cboEnd to disabled
            cboEnd_1.Enabled = false;
            cboEnd_2.Enabled = false;
            cboEnd_3.Enabled = false;
            cboEnd_4.Enabled = false;
            cboEnd_5.Enabled = false;
            cboEnd_6.Enabled = false;
            cboEnd_7.Enabled = false;
            cboEnd_8.Enabled = false;
            cboEnd_9.Enabled = false;
            cboEnd_10.Enabled = false;
            //set cboDay to disabled
            cboDay_1.Enabled = false;
            cboDay_2.Enabled = false;
            cboDay_3.Enabled = false;
            cboDay_4.Enabled = false;
            cboDay_5.Enabled = false;
            cboDay_6.Enabled = false;
            cboDay_7.Enabled = false;
            cboDay_8.Enabled = false;
            cboDay_9.Enabled = false;
            cboDay_10.Enabled = false;
            //set cboRoom to disabled
            cboRoom_1.Enabled = false;
            cboRoom_2.Enabled = false;
            cboRoom_3.Enabled = false;
            cboRoom_4.Enabled = false;
            cboRoom_5.Enabled = false;
            cboRoom_6.Enabled = false;
            cboRoom_7.Enabled = false;
            cboRoom_8.Enabled = false;
            cboRoom_9.Enabled = false;
            cboRoom_10.Enabled = false;
            //set btnSet to Disabled
            btnSet_1.Enabled = false;
            btnSet_2.Enabled = false;
            btnSet_3.Enabled = false;
            btnSet_4.Enabled = false;
            btnSet_5.Enabled = false;
            btnSet_6.Enabled = false;
            btnSet_7.Enabled = false;
            btnSet_8.Enabled = false;
            btnSet_9.Enabled = false;
            btnSet_10.Enabled = false;
        }

        private void btnSet_1_Click(object sender, EventArgs e)
        {
            if (btnSet_1.Text == "SET")
            {
                //clear all listed items
                cboProfessor_1.Items.Clear();
                cboRoom_1.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_1.Enabled = true;
                cboProfessor_1.Enabled = true;
                cboStart_1.Enabled = true;
                cboEnd_1.Enabled = true;
                cboDay_1.Enabled = true;
                cboRoom_1.Enabled = true;
                btnSet_1.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for(int x = 0; x < 50; x++)//set to 50 loop
                {
                    if(SubjectForStudents.Rooms[x] != "")
                        cboRoom_1.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_1.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_1.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_1.Text = "SET";
            }
        }

        private void btnSet_2_Click(object sender, EventArgs e)
        {
            if (btnSet_2.Text == "SET")
            {
                //clear all listed items
                cboProfessor_2.Items.Clear();
                cboRoom_2.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_2.Enabled = true;
                cboProfessor_2.Enabled = true;
                cboStart_2.Enabled = true;
                cboEnd_2.Enabled = true;
                cboDay_2.Enabled = true;
                cboRoom_2.Enabled = true;
                btnSet_2.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_2.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_2.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_2.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_2.Text = "SET";
            }
        }

        private void btnSet_3_Click(object sender, EventArgs e)
        {
            if (btnSet_3.Text == "SET")
            {
                //clear all listed items
                cboProfessor_3.Items.Clear();
                cboRoom_3.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_3.Enabled = true;
                cboProfessor_3.Enabled = true;
                cboStart_3.Enabled = true;
                cboEnd_3.Enabled = true;
                cboDay_3.Enabled = true;
                cboRoom_3.Enabled = true;
                btnSet_3.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_3.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_3.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_3.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_3.Text = "SET";
            }
        }

        private void btnSet_4_Click(object sender, EventArgs e)
        {
            if (btnSet_4.Text == "SET")
            {
                //clear all listed items
                cboProfessor_4.Items.Clear();
                cboRoom_4.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_4.Enabled = true;
                cboProfessor_4.Enabled = true;
                cboStart_4.Enabled = true;
                cboEnd_4.Enabled = true;
                cboDay_4.Enabled = true;
                cboRoom_4.Enabled = true;
                btnSet_4.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_4.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_4.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_4.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_4.Text = "SET";
            }
        }

        private void btnSet_5_Click(object sender, EventArgs e)
        {
            if (btnSet_5.Text == "SET")
            {
                //clear all listed items
                cboProfessor_5.Items.Clear();
                cboRoom_5.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_5.Enabled = true;
                cboProfessor_5.Enabled = true;
                cboStart_5.Enabled = true;
                cboEnd_5.Enabled = true;
                cboDay_5.Enabled = true;
                cboRoom_5.Enabled = true;
                btnSet_5.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_5.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_5.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_5.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_5.Text = "SET";
            }
        }

        private void btnSet_6_Click(object sender, EventArgs e)
        {
            if (btnSet_6.Text == "SET")
            {
                //clear all listed items
                cboProfessor_6.Items.Clear();
                cboRoom_6.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_6.Enabled = true;
                cboProfessor_6.Enabled = true;
                cboStart_6.Enabled = true;
                cboEnd_6.Enabled = true;
                cboDay_6.Enabled = true;
                cboRoom_6.Enabled = true;
                btnSet_6.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_6.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_6.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_6.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_6.Text = "SET";
            }
        }

        private void btnSet_7_Click(object sender, EventArgs e)
        {
            if (btnSet_7.Text == "SET")
            {
                //clear all listed items
                cboProfessor_7.Items.Clear();
                cboRoom_7.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_7.Enabled = true;
                cboProfessor_7.Enabled = true;
                cboStart_7.Enabled = true;
                cboEnd_7.Enabled = true;
                cboDay_7.Enabled = true;
                cboRoom_7.Enabled = true;
                btnSet_7.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_7.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_7.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_7.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_7.Text = "SET";
            }
        }

        private void btnSet_8_Click(object sender, EventArgs e)
        {
            if (btnSet_8.Text == "SET")
            {
                //clear all listed items
                cboProfessor_8.Items.Clear();
                cboRoom_8.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_8.Enabled = true;
                cboProfessor_8.Enabled = true;
                cboStart_8.Enabled = true;
                cboEnd_8.Enabled = true;
                cboDay_8.Enabled = true;
                cboRoom_8.Enabled = true;
                btnSet_8.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_8.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_8.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_8.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_8.Text = "SET";
            }
        }

        private void btnSet_9_Click(object sender, EventArgs e)
        {
            if (btnSet_9.Text == "SET")
            {
                //clear all listed items
                cboProfessor_9.Items.Clear();
                cboRoom_9.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_9.Enabled = true;
                cboProfessor_9.Enabled = true;
                cboStart_9.Enabled = true;
                cboEnd_9.Enabled = true;
                cboDay_9.Enabled = true;
                cboRoom_9.Enabled = true;
                btnSet_9.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_9.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_9.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_9.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_9.Text = "SET";
            }
        }

        private void btnSet_10_Click(object sender, EventArgs e)
        {
            if (btnSet_10.Text == "SET")
            {
                //clear all listed items
                cboProfessor_10.Items.Clear();
                cboRoom_10.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_10.Enabled = true;
                cboProfessor_10.Enabled = true;
                cboStart_10.Enabled = true;
                cboEnd_10.Enabled = true;
                cboDay_10.Enabled = true;
                cboRoom_10.Enabled = true;
                btnSet_10.Text = "OK";

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_10.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_10.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_10.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_10.Text = "SET";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboProfessor_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_1.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_1.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_2.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_2.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_3.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_3.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_4.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_4.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_5.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_5.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_6.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_6.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_7.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_7.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_8.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_8.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_9.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_9.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_10.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_10.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {

        }
    }
}
