using System;

public class AutoTransmission : Transmission
{
    public override string TransmissionType()
    {
        return string.Format("Auto Transmission");
    }
}