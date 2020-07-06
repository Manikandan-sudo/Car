using System;

public class Client
{
    public static void Main(string[] args)
    {
        Car ciaz = new Car();

        ciaz.petrolengine = new PetrolEngine();

        ciaz.manualTransmission = new ManualTransmission();

        Console.WriteLine(ciaz.Start());
        Console.WriteLine(ciaz.Stop());
        Console.WriteLine(ciaz.Accelerate());
        Console.WriteLine(ciaz.TransmissionType());
        
    }
    
}