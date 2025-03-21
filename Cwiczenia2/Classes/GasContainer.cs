using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public class GasContainer(float mass, float height, float weight, float depth, float capacity, ContainerType containerType) 
    : BaseContainer(mass, height, weight, depth, capacity, containerType), IHazardNotifier
{
    private AtmosphereUnit _pressure = new(1, AtmosphereUnitType.ATM);

    public override void Empty()
    {
        
    } 
    
    public void Hazard(string containerId, string msg)
    {
        Console.WriteLine(containerId + ": " + msg);
    }
    
    public string GetPressure() => _pressure.GetFullPressureInfo();
}