using System;
using System.Collections.Specialized;
using System.Linq;

namespace HelloWorld
{

    class Student
    {
        public string name;
        public string surname;
        public int age;
        public int ID;

        public Student(string name, string surname, int age, int iD)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            ID = iD;
        }

        public void Study()
        {
            Console.WriteLine($"Student {this.name} is studying.");
        }
    }
    
    class Teacher
    {
        public string name;
        public string surname;
        public int age;
        public string subject;

        public Teacher(string name, string surname, int age, string subject)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.subject = subject;
        }

        public void Teach(Student s)
        {
            Console.WriteLine($"{this.name} is now teaching {s.name}");
        }
        

    }

    class School
    {
        public string name; 
        public List<Student> students;
        public List<Teacher> teachers;

        
        public School(string name)
        {
            this.name = name; 
            students = new List<Student>();
            teachers = new List<Teacher>();
        }
        public void EnrollStudent(Student s)
        {
            students.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            teachers.Add(t);
        }

        public void RemoveStudent(int index)
        {
            students.RemoveAt(index-1);
        }

        public void RemoveTeacher(int index)
        {
            teachers.RemoveAt(index-1);
        }

        public void ListOfStudents()
        {
            Console.WriteLine($"Ucenici skole {this.name}: "); 
            int b = students.Count(); 
            for(int i = 0; i < b; i++)
            {
                Console.WriteLine($"{i+1}. {students[i].name} {students[i].surname}"); 
            }
            Console.WriteLine();
        }

        public void ListOfTeachers()
        {
            Console.WriteLine($"Profesori skole {this.name}"); 
            int b = teachers.Count();
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine($"{i+1}. {teachers[i].name} {teachers[i].surname}");
            }
            Console.WriteLine();
        }
    }

    class Course
    {
        public string name;
        public List<Student> studentsInCourse;
        public List<Teacher> teachersInCourse;
        public Course(string name)
        {
            this.name = name;
            studentsInCourse = new List<Student>();
            teachersInCourse = new List<Teacher>();
        }

        public void EnrollStudent(Student s)
        {
            studentsInCourse.Add(s);
        }

        public void AddTeachers(Teacher t)
        {
            teachersInCourse.Add(t);
        }

        public void ListOfStudents()
        {
            Console.WriteLine($"Ucenici kursa {name}: "); 
            int b = studentsInCourse.Count;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine($"{i+1}. {studentsInCourse[i].name} {studentsInCourse[i].surname}");
            }
            Console.WriteLine(); 
        }

        public void ListOfTeachers()
        {
            Console.WriteLine("Predavaci kursa: ");
            int b = teachersInCourse.Count;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine($"{i + 1}. {teachersInCourse[i].name} {teachersInCourse[i].surname}");
            }
            Console.WriteLine();
        }

        public void RemoveStudent(int index)
        {
            studentsInCourse.RemoveAt(index-1);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Vehid", "Halilovic", 35, 12);
            

            Student student2 = new Student("Eldin", "Smajic", 40, 13);

            //student.Study();

            Teacher ucitelj = new Teacher("Sakib",  "Jusic", 55, "Matematika");

            Teacher ucitelj2 = new Teacher("Dzevdet", "Huskic", 43, "Engleski jezik"); 

            //ucitelj.Teach(student); 

            School skola = new School("O.S. Podlugovi");

            Course kurs1 = new Course("Engleski jezik");
            
            

            kurs1.EnrollStudent(student);
            kurs1.EnrollStudent(student2);
            kurs1.ListOfStudents();
            kurs1.RemoveStudent(1);
            kurs1.ListOfStudents();

            kurs1.AddTeachers(ucitelj2);
            kurs1.AddTeachers(ucitelj);
            kurs1.ListOfTeachers();


            skola.EnrollStudent(student);
            skola.EnrollStudent(student2); 
            skola.ListOfStudents();
            skola.RemoveStudent(1);
            skola.ListOfStudents(); 

            skola.AddTeacher(ucitelj);
            skola.AddTeacher(ucitelj2);
            skola.ListOfTeachers();



            //skola.ListOfStudents();
            //skola.ListOfTeachers();
        }
    }
}
