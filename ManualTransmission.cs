using System;

public class ManualTransmission : Transmission
{
    public override string TransmissionType()
    {
        return string.Format("Manual Transmission");
    }
}