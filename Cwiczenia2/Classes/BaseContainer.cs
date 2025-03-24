using Cwiczenia2.Interfaces;
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

    public string GetSerialNumber()
    {
        return _serialNumber.GetSerialNumber();
    }
    
    public void PrintContainerInfo()
    {
        Console.WriteLine("Max height: " + height);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Container depth: " + depth);
        Console.WriteLine("Container capacity: " + capacity);
        Console.WriteLine("Container type: " + containerType);
        Console.WriteLine("Container serial number: " + GetSerialNumber());
    }
}