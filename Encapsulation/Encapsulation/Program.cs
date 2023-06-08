namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.SetAgeData(20);
            std.SetMarks(60);
            std.SetName("Hello welcome to C# Programming ");

            std.detail();
        }
    }
}