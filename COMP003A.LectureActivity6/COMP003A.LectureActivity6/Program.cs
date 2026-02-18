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
        /* Each student object have its own data because if everyone shared the same form, there would be constant
         * erasing and overwriting. 
         * Main does not need to know how DisplayInfo works because it doesn't need to know the "what" details of the program,
         * but it must need to know "how" it is supposed to display the information.
         * This demonstrates encapsulation conceptually by just "clumping" the variables and methods into one "Student"
         * container so everything is organized. This keeps the code clean and wraps everything together instead of being
         * scattered everywhere.
         */
	}
}
