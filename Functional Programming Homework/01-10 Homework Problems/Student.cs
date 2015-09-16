using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Class_Student
{
    class Student
    {
        public Student(string fName, string lName, int age, string fNumber, string tel, string mail, IList<int> grades, int number)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.FacultyNumber = fNumber;
            this.Phone = tel;
            this.Email = mail;
            this.Marks = grades;
            this.GroupNumber = number;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

    }
}