﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using ExcelDataReader;

namespace ClassSchedulingComputerAided
{
    public partial class frmSetCurriculum : MetroFramework.Forms.MetroForm
    {
        public frmSetCurriculum()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void SetCurriculum_Load(object sender, EventArgs e)
        {
            cboUnits.SelectedIndex = 0;
            cboLectureHours.SelectedIndex = 0;
            cboLabHours.SelectedIndex = 0;
            cboYearLevel.SelectedIndex = 0;
            dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
            dgvListSubject.Columns[0].Visible = false;

            for (int x = 0; x < md.ListCourse(curriculumData.c_id).Length; x++)
            {
                if (md.ListCourse(curriculumData.c_id).GetValue(x).ToString() != "")
                    cboCourse.Items.Add(md.ListCourse(curriculumData.c_id).GetValue(x).ToString());
            }
            cboCourse.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCurriculum c = new frmCurriculum();
            c.Show();
            this.Hide();
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmSetCourses sc = new frmSetCourses();
            //sc.Show();
            //sc.lbl_control_id.Text = curriculumData.c_id;
            //sc.lbl_title.Text = lbl_title.Text;
            //this.Hide();
            frmSemesterAndSchoolYear sas = new frmSemesterAndSchoolYear();
            sas.Show();
            this.Hide();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmViewList v = new frmViewList();
            v.Show();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            frmAddSubject a = new frmAddSubject();
            a.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added Successfully", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
            md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.Text, txtSubjectCode.Text, txtSubjectDescription.Text, cboLectureHours.SelectedItem.ToString(), cboLabHours.SelectedItem.ToString(), cboUnits.SelectedItem.ToString(), cboYearLevel.SelectedItem.ToString(), curriculumData.c_semester);
            dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
            dgvListSubject.Columns[0].Visible = false;
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_course_id.Text = md.GetCourseID(cboCourse.SelectedItem.ToString(), curriculumData.c_id);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        DataSet result;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opfd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx;*.xlsm", ValidateNames = true })
                {
                    if (opfd.ShowDialog() == DialogResult.OK)
                    {
                        txtFile.Text = opfd.FileName;
                        FileStream fs = File.Open(opfd.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);
                        result = reader.AsDataSet();
                        cboSheets.Items.Clear();
                        foreach (DataTable dt in result.Tables)
                            cboSheets.Items.Add(dt.TableName);
                        cboSheets.SelectedIndex = 0;
                        reader.Close();

                        dgvData.DataSource = result.Tables[cboSheets.Text];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            pnl_import.Visible = true;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvData.DataSource = result.Tables[cboSheets.SelectedIndex];
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            lbl_course_id.Text = md.GetCourseID(cboCourse.Text, curriculumData.c_id);// to get course id
            //dgvData.SelectAll();
            int r = 0;
            for (int i = 1; i < dgvData.Rows.Count - 1; i++)
            {
                //md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.Text, txtSubjectCode.Text, txtSubjectDescription.Text, cboLectureHours.SelectedItem.ToString(), cboLabHours.SelectedItem.ToString(), cboUnits.SelectedItem.ToString(), cboYearLevel.SelectedItem.ToString(), curriculumData.c_semester);

                string pc = dgvData.Rows[i].Cells[0].Value.ToString();
                string test = "";
                string testData = "";
                int a = 0;
                foreach (char p in pc)
                {
                    if (p != ' ') { test += p; }
                    else { if (a == 0) {  testData = test; a++; } }
                }
                string getSection;
                string getYear;

                getSection = pc.Substring(pc.Length - 1, 1);
                getYear = pc.Substring(pc.Length - 3, 1);
                //if (getSection == '1')
                //{
                    
                //}

                if (testData == cboCourse.Text)
                {
                    if (getSection == "1")
                    {
                        string subjectCode = dgvData.Rows[i].Cells[1].Value.ToString();
                        string subjecDescription = dgvData.Rows[i].Cells[2].Value.ToString();
                        string lecHours = dgvData.Rows[i].Cells[3].Value.ToString();
                        string labHours = dgvData.Rows[i].Cells[4].Value.ToString();
                        string units = dgvData.Rows[i].Cells[6].Value.ToString();
                        string yearLevel = getYear;
                        md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.Text, subjectCode, subjecDescription, lecHours, labHours, units, yearLevel, curriculumData.c_semester);
                    }
                }
            }
            dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
            dgvListSubject.Columns[0].Visible = false;
        }
    }
}
