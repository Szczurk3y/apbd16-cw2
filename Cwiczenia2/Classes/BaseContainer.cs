using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

abstract class BaseContainer(
    float mass,
    float height,
    float weight,
    float depth,
    float capacity,
    SerialNumber serialNumber
): IContainer
{
    public void empty()
    {
        throw new NotImplementedException();
    }

    public void fill(float fillWith)
    {
        if (mass > capacity) {
            throw new OverfillException("Container overloaded!");
        } else {
            mass = fillWith;
        }
    }

    public string GetSerialNumber()
    {
        return serialNumber.GetSerialNumber();
    }
}