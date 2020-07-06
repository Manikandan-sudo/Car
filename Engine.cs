using System;

public abstract class Engine
{

    public abstract string EngineType();

    
    public string Start()
    {
        return string.Format("Engine is started");
    }

    public string Stop()
    {
        return string.Format("Engine is stopped");
    }

    public string Accelerate()
    {
        return string.Format("Engine is accelerating");
    }
} 
