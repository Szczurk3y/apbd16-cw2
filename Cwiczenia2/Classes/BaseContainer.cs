using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

abstract class BaseContainer(
    float mass,
    float height,
    float weight,
    float depth,
    float capacity,
    ContainerType containerType
): IContainer
{
    private SerialNumber serialNumber = new(containerType);
    private float _mass = mass;

    public void empty()
    {
        throw new NotImplementedException();
    }

    public void fill(float fillWith)
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