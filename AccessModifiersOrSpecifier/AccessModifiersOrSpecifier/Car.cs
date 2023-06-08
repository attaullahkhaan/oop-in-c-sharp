public class Car
{
    private string privateField; // Private field
    public string publicField; // Public field
    protected string protectedField; // Protected field
    internal string internalField; // Internal field
    protected internal string protectedInternalField; // Protected Internal field

    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public Method");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected Method");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal Method");
    }

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal Method");
    }
}