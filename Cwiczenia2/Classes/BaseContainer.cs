﻿using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public abstract class BaseContainer(
    double height,
    double weight,
    double depth,
    double capacity,
    ContainerType containerType
): IContainer
{
    private readonly SerialNumber _serialNumber = new(containerType);
    protected double Mass;

    public virtual void Empty()
    {
        Mass = weight;
    }

    public virtual void Fill(double fillWith)
    {
        if (fillWith > capacity) {
            throw new OverfillException("Container overloaded!");
        }
        Mass = fillWith + weight;
    }

    protected string GetSerialNumber()
    {
        return _serialNumber.GetSerialNumber();
    }
}