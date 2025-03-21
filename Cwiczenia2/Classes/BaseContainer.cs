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
    private SerialNumber serialNumber = new(containerType);
    private double _mass = mass;

    public void empty()
    {
        throw new NotImplementedException();
    }

    public virtual void fill(double fillWith)
    {
        if (_mass > capacity) {
            throw new OverfillException("Container overloaded!");
        } else {
            _mass = fillWith;
        }
    }

    public string GetSerialNumber()
    {
        return serialNumber.GetSerialNumber();
    }
}