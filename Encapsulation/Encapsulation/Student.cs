namespace Encapsulation
{
    class Student
    {
        private int age;
        private int marks;
        private string name;

        public void SetAgeData (int a)
        {
            if (a > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("you're entered an invalid value, please try again");
            }
        }

        public void SetMarks (int m)
        {
            if (m > 0)
            {
                marks = m;
            }
        }

        public void SetName (string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                name = n;
            }
            else
            {
                Console.WriteLine("You cannot empty or null value in name");
            }
        }

        public void detail()
        {
            Console.WriteLine("Name = {0} Age = {1} Marks = {2}", name, age, marks);
        }
    }
}
