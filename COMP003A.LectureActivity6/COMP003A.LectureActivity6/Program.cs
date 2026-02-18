using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace COMP003A.LectureActivity6
{
    class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo() 
        { Console.WriteLine($"Student Name: {Name}, Age: {Age}"); }
        static void Main(string[] args)
        {
            Student student1 = new Student("Stephen", 37);
            Student student2 = new Student("Josh", 18);

            student1.DisplayInfo();
			student2.DisplayInfo();
		}

	}
}
