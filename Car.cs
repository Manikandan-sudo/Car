using System;

public class Car : Vehicle
{
    public string CarName{get; set;}

    public PetrolEngine petrolengine;

    public ManualTransmission manualTransmission;

    public override string Move()
    {
        return string.Format("The Car is Moving");
    }

    public string Start()
    {
        return string.Format("The car {0}",petrolengine.Start());
    }
    public string Stop()
    {
        return string.Format("The car {0}",petrolengine.Stop());
    }

    public string Accelerate()
    {
        return string.Format("The car {0}",petrolengine.Accelerate());
    }

    public virtual string TransmissionType()
    {
        return string.Format("The car is using {0}",manualTransmission.TransmissionType());
    }
}