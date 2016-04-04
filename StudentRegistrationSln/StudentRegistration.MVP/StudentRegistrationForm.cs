#region Using Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StudentRegistration.Domain;

#endregion

namespace StudentRegistration.MVP
{
	public partial class StudentRegistrationForm : Form, IStudentRegistrationForm
	{

        public event EventHandler DataChanged;
        private new List<Student> mockStudentList = new List<Student>()
            {
                new Student("111-11-1212", "Bart", "Simpson", "Information Systems", "Full Time"),
                new Student("123-12-1234", "Maggie", "Simpson", "International Affairs", "Part Time"),
            };

        #region Constructors

        public StudentRegistrationForm()
        {
            InitializeComponent();
            Init();
        }

        #endregion

        #region Methods

        // good software programming practice!!
        private void Init()
        {
            LoadDepartments();
            LoadDataGridWithMockData();
            LoadDefaults();
        }

        private void LoadDepartments()
        {
            cmbDpt.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        // since we don't know ADO.NET and/or File I/O we will get static mock data
        private void LoadDataGridWithMockData()
        {


            // dirty workaround to make sure that we can bind to the static mock list
            var bindingList = new BindingList<Student>(mockStudentList);
            var source = new BindingSource(bindingList, null);
            dataGridViewStudents.DataSource = source;
        }

        private void LoadDefaults()
        {
            radFTime.Select();
            cmbDpt.SelectedIndex = 0;

        }

        #endregion

        private void HandleDataGridViewStudentsSelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                stuID.Text = row.Cells[0].Value.ToString();
                fstName.Text = row.Cells[1].Value.ToString();
                lstName.Text = row.Cells[2].Value.ToString();

                cmbDpt.SelectedIndex = cmbDpt.Items.IndexOf(row.Cells[3].Value.ToString());

                // enrollment type selection driven by the grid itself
                var enrollmentType = row.Cells[4].Value.ToString();
                if (radFTime.Text == enrollmentType)
                {
                    radFTime.Checked = true;
                }
                else if (radPTime.Text == enrollmentType)
                {
                    radPTime.Checked = true;
                }
            }
        }

        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void newStu_Click(object sender, EventArgs e)
        {
            String sutID = this.stuID.Text.Trim();
            String fstName = this.fstName.Text.Trim();
            String lstName = this.lstName.Text.Trim();
            String cmbDpt = this.cmbDpt.Text.Trim();
            String radText;
            if (this.radFTime.Checked == true)
            {
                radText = this.radFTime.Text;
            }
            else {
                radText = this.radPTime.Text;
            }
            foreach (Student stx in mockStudentList)
            {
                if (stx.StudentID == sutID)
                {
                    MessageBox.Show("Student ID can not be repeated");
                    return;
                }

            }

            Student st = new Student(sutID, fstName, lstName, cmbDpt, radText);
            mockStudentList.Add(st);
            this.dataGridViewStudents.DataSource = null;
            LoadDataGridWithMockData();

        }

        private void removeStu_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure want to remove this student?", "remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                {
                    String stuId = row.Cells[0].Value.ToString();
                    foreach (Student st in mockStudentList)
                    {

                        if (st.StudentID == stuId)
                        {
                            mockStudentList.Remove(st);
                            this.dataGridViewStudents.DataSource = null;
                            LoadDataGridWithMockData();
                            return;
                        }

                    }

                }

            }

        }

        private void editStu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to update this student?", "remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                {
                    String stuId = row.Cells[0].Value.ToString();
                    foreach (Student st in mockStudentList)
                    {

                        if (st.StudentID == stuId)
                        {
                            mockStudentList.Remove(st);
                            String sutID = this.stuID.Text.Trim();
                            String fstName = this.fstName.Text.Trim();
                            String lstName = this.lstName.Text.Trim();
                            String cmbDpt = this.cmbDpt.Text.Trim();
                            String radText;
                            if (this.radFTime.Checked == true)
                            {
                                radText = this.radFTime.Text;
                            }
                            else
                            {
                                radText = this.radPTime.Text;
                            }

                            Student st1 = new Student(sutID, fstName, lstName, cmbDpt, radText);
                            mockStudentList.Add(st1);
                            this.dataGridViewStudents.DataSource = null;
                            LoadDataGridWithMockData();
                            return;
                        }

                    }
                }
            }
        }
    }
}
