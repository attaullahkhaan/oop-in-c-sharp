class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();

        // Accessing members using different access modifiers
        myCar.publicField = "Public Field"; // Accessible
        myCar.PublicMethod(); // Accessible

        // Uncomment the lines below to see access restrictions
        //myCar.privateField = "Private Field"; // Not accessible
        //myCar.PrivateMethod(); // Not accessible

        //myCar.protectedField = "Protected Field"; // Not accessible
        //myCar.ProtectedMethod(); // Not accessible

        //myCar.internalField = "Internal Field"; // Accessible
        //myCar.InternalMethod(); // Accessible

        //myCar.protectedInternalField = "Protected Internal Field"; // Accessible
        //myCar.ProtectedInternalMethod(); // Accessible

        Console.ReadLine();
    }
}