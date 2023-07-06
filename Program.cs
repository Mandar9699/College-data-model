using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace College_data_model
{
    public class College
    {
        public int CollegeId { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        public string Location { get; set; }
        public double CollegeFees { get; set; }
        public string Pricipal { get; set; }
        public string exam_pattern { get; set; }
        
        public List<Student> Students { get; set; }
        public List<Branch> Courses { get; set; }

       public College()
        {
            Students = new List<Student>();
            Courses = new List<Branch>();
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public List<Branch> Courses { get; set; }

        public Student()
        {
            Courses = new List<Branch>();
        }
    }

    public class Branch
    {
        public int CourseId { get; set; }
        public double CourseFees { get; set; }
        public string Name { get; set; }
        public string HOD { get; set; }
        public int No_of_Seats { get; set; }
        public int Non_teaching { get; set; }
        public int Teaching { get; set; }
        public string labs { get; set; }
        public int lab_capacity { get; set; }
        public string first_sem { get; set; }
        public string second_sem { get; set; }
        public string third_sem { get; set; }
        public string fourth_sem { get; set; }
        
        public List<Student> EnrolledStudents { get; set; }

        public Branch()
        {
            EnrolledStudents = new List<Student>();
        }

       
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            
            College college = new College { CollegeId=2133, Name="MBES",University="DBATU",Pricipal="DR.AAA",CollegeFees=32500,Location="Ambajogai",exam_pattern="60 theory 20 CA1 20 CA2"};
             

            
            Student student1 = new Student { StudentId = 1, Name = "Ajay", Age = 21 };
            Student student2 = new Student { StudentId = 2, Name = "Avinash", Age = 21 };
            Student student3 = new Student { StudentId = 3, Name = "Akshay", Age = 21 };
            Student student4 = new Student { StudentId = 4, Name = "Arvind", Age = 21 };

            college.Students.Add(student1);
            college.Students.Add(student2);
            college.Students.Add((student3));
            college.Students.Add((student4));

            
            Branch course1 = new Branch { CourseId = 1,CourseFees=35000,  Name = "Civil", HOD = "Dr.A",labs="Geology lab,Soil lab, Survey lab",first_sem="6 subjects and 3 labs",second_sem="5 subjects and 4 labs",third_sem="7 subjects and 2 labs",fourth_sem="6 subjects and 3 labs",lab_capacity=30,Non_teaching=2,Teaching=5, No_of_Seats = 60 };
            Branch course2 = new Branch { CourseId = 2, CourseFees=45000,Name = "CSE", HOD = "Dr.B",labs="Computer lab",first_sem = "6 subjects and 2 labs",second_sem = "6 subjects and 4 labs", third_sem = "6 subjects and 4 labs", fourth_sem = "7 subjects and 3 labs",lab_capacity =30,Non_teaching=3,Teaching=6, No_of_Seats = 60 };
            college.Courses.Add(course1);
            college.Courses.Add(course2);

            
            course1.EnrolledStudents.Add(student1);
            course1.EnrolledStudents.Add(student4);
            course2.EnrolledStudents.Add(student2);
           course2.EnrolledStudents.Add(student3);


            Console.WriteLine("College id= "+college.CollegeId);
            Console.WriteLine("College name= "+college.Name);
            Console.WriteLine("University= " + college.University);
            Console.WriteLine("Exam Pattern= "+college.exam_pattern);
            Console.WriteLine("Principal= "+college.Pricipal);
            Console.WriteLine("College Fees= "+college.CollegeFees);
            Console.WriteLine("College Location= "+college.Location);

            

           
            foreach (Branch course in college.Courses)
            {
                Console.WriteLine($"\nBranch: {course.Name}");
                Console.WriteLine($"Course fees: {course.CourseFees}");
                Console.WriteLine($"HOD: {course.HOD}");
                Console.WriteLine($"Teaching Staff: {course.Teaching}");
                Console.WriteLine($"Non Teaching Staff: {course.Non_teaching}");
                Console.WriteLine($"Lab Facility: {course.labs}");
                Console.WriteLine($"Lab Capacity: {course.lab_capacity}");
                Console.WriteLine($"Seats: {course.No_of_Seats}");
                Console.WriteLine("\nCurriculum: ");
                Console.WriteLine("First Sem: "+course.first_sem);
                Console.WriteLine("Second Sem: "+course.second_sem);
                Console.WriteLine("Third Sem: "+course.third_sem);
                Console.WriteLine("Fourth Sem: "+course.fourth_sem);
                Console.WriteLine("\nStudents enrolled in Branches:");
                foreach (Student student in course.EnrolledStudents)
                {
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Student Id: {student.StudentId}");
                    Console.WriteLine($"Student Age: {student.Age}\n");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

}
