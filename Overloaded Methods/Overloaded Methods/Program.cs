namespace Overloaded_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.show();
            student.show("My age is: ");
            student.show(22, "Your age is: ");
        }
    }
}