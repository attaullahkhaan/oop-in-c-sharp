namespace Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Car Object
            Car car = new Car();
            Console.WriteLine(car.color);

            // Creating Car1 Object 
            Car1 car1 = new Car1();
            Console.WriteLine(car1.color + " " + car1.maxSpeed);
        }
    }

    class Car
    {
        public string color = "White";
    }
}