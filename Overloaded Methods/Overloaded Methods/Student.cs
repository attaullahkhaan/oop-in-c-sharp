using Microsoft.VisualBasic;

namespace Overloaded_Methods
{
    class Student
    {
        private int age;

        public Student(int a) 
        { 
            age = a;
        }

        public Student() 
        {
            age = 20;
        }

        public void show()
        {
            Console.WriteLine(age);
        }

        public void show (string message)
        {
            Console.WriteLine(message + age);
        }

        public void show(int a, string message)
        {
            age = a;
            Console.WriteLine(message + age);
        }
    }
}
