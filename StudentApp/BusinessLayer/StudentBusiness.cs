using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    { 
        readonly StudentRepository studentRepository = new StudentRepository();

        public List <Student> GetStudents()
        {
            return studentRepository.GetAllStudents().Where(student => student.StudyYear * 37 > 50 ).ToList();
        }

        public bool InsertStudent(Student student)
        {
            return studentRepository.InsertStudent(student) != 0; 
        }
    }
}
