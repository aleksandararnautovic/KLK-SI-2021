using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDesktop
{
    public partial class StudentApp : Form
    {
        readonly StudentBusiness studentBusiness = new StudentBusiness();
        public StudentApp()
        {
            InitializeComponent();
        }

        private void StudentApp_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        
        private void RefreshList()
        {
            listBoxStudents.Items.Clear();
            foreach (Student student in studentBusiness .GetStudents())
            {
                listBoxStudents.Items.Add($"{student.Id}. {student.Name }. {student.IndexNumber}. {student.PointsESPB}. {student.StudyYear}");
            }
        }

        private void buttonInsertStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = textBoxName.Text,
                IndexNumber = textBoxIndexNumber.Text,
                PointsESPB = Convert.ToInt32(textBoxAverageMark.Text),
                StudyYear = Convert.ToInt32(textBoxStudyYear.Text),
                AverageMark = Convert.ToDecimal(textBoxAverageMark.Text),
                IsBudget =Convert .ToBoolean( radioButtonIsBudget.Text ),

            };

            studentBusiness.InsertStudent(student);

            RefreshList();

            textBoxName.Text = string.Empty;
            textBoxIndexNumber.Text = string.Empty;
            textBoxPointsESPB.Text = string.Empty;
            textBoxStudyYear.Text = string.Empty;
            textBoxAverageMark.Text = string.Empty;
            radioButtonIsBudget.Checked = true;
            
        }
    }
}
