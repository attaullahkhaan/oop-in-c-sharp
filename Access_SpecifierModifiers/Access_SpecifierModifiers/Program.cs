
using ClassLibrary;

namespace Access_SpecifierModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.carModel);
            Console.WriteLine(car.my_age);

            //Library library = new Library();
            //library.Show("Ikram");


            Person person = new Person();
            person.age = 1;

            //person.name = "A"; // Inaccessible due to its protectin Level


        }
    }
}