using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public abstract class BaseContainer(
    float mass,
    double height,
    double weight,
    double depth,
    double capacity,
    ContainerType containerType
): IContainer
{
    private readonly SerialNumber _serialNumber = new(containerType);
    private double _mass = mass;

    public virtual void Empty()
    {
        _mass = weight;
    }

    public virtual void Fill(double fillWith)
    {
        if (fillWith > capacity) {
            throw new OverfillException("Container overloaded!");
        }
        _mass = fillWith + weight;
    }

    protected string GetSerialNumber()
    {
        return _serialNumber.GetSerialNumber();
    }
}