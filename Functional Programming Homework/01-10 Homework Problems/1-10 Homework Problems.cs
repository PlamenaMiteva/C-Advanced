using _01.Class_Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Homework
{

    static void Main()
    {
        //Problem 1. Class Student
        var students = new Student[]
            {
                new Student("Ivan", "Petrov", 20, "1234140", "089945769238", "ivan@gmail.com", new List<int>{2,2,2,4}, 1),
            new Student("Maria", "Ignatova", 21, "8893746", "0264564708", "maria@abv.com", new List<int>{3,4,6}, 2),
             new Student("Simeon", "Todorov", 25, "563437", "+359266743508", "simo@abv.bg", new List<int>{5,6,6}, 6),
             new Student("Asen", "Dimov", 27, "523414466", "08882479360", "asen@abv.bg", new List<int>{5,4,6}, 2)
            };

        //Problem 2. Students by Group
        var groupTwo =
            from st in students
            where st.GroupNumber == 2
            orderby st.FirstName
            select st;
        Console.WriteLine("Students from group two:");
        foreach (var item in groupTwo)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}, Age:{2}, Faculty Number:{3}, Phone:{4}, Email:{5}, Grades:{6}", item.FirstName, item.LastName, item.Age, item.FacultyNumber, item.Phone, item.Email, string.Join(",", item.Marks));
        }
        Console.WriteLine();
        //Problem 3. Students by First and Last Name
        var firstAndLastName =
            from st in students
            where st.FirstName[0] < st.LastName[0]
            select st;

        Console.WriteLine("Students by First and Last Name:");
        foreach (var item in firstAndLastName)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}, Age:{2}, Faculty Number:{3}, Phone:{4}, Email:{5}, Grades:{6}", item.FirstName, item.LastName, item.Age, item.FacultyNumber, item.Phone, item.Email, string.Join(",", item.Marks));
        }
        Console.WriteLine();

        //Problem 4. Students by Age
        var studentsByAge =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select new { st.FirstName, st.LastName };

        Console.WriteLine("Students By Age:");
        foreach (var item in groupTwo)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();

        //Problem 5. Sort Students
        //LINQ query syntax
        var sortStudents =
                   from st in students
                   orderby st.FirstName descending,
                   st.LastName descending
                   select st;

        Console.WriteLine("Sort Students:");
        foreach (var item in sortStudents)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();
        //Extension methods 
        var sortStudentsByNames = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

        Console.WriteLine("Sort Students:");
        foreach (var item in sortStudentsByNames)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();

        //Problem 6. Filter Students by Email Domain
        var sortStudentsByEmail = students.Where(st => st.Email.EndsWith("abv.bg"));

        Console.WriteLine("Sort Students By Email:");
        foreach (var item in sortStudentsByEmail)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();

        //Problem 7. Filter Students by Phone
        var sortStudentsByPhone = students.Where(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"));

        Console.WriteLine("Sort Students By Phone:");
        foreach (var item in sortStudentsByPhone)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}, Phone:{2}", item.FirstName, item.LastName, item.Phone);
        }
        Console.WriteLine();

        //Problem 8. Excellent Students
        var excellentStudents = students.Where(st => st.Marks.Any(c => c == 6));

        Console.WriteLine("Excellent Students:");
        foreach (var item in excellentStudents)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();

        //Problem 9. Weak Students
        var weakStudents = students.Where(st => st.Marks.Count(c => c == 2) >= 2);
        Console.WriteLine("Weak Students:");
        foreach (var item in weakStudents)
        {
            Console.WriteLine("First Name: {0}, Last Name:{1}", item.FirstName, item.LastName);
        }
        Console.WriteLine();

        //Problem 10. Students Enrolled in 2014
        var enrolledStudents = students.Where(st => st.FacultyNumber[4] == '1' && st.FacultyNumber[5] == '4');
        Console.WriteLine("Students Enrolled in 2014:");
        foreach (var item in enrolledStudents)
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Marks: {2}", item.FirstName, item.LastName, string.Join(",", item.Marks));
        }
        Console.WriteLine();
    }
}
