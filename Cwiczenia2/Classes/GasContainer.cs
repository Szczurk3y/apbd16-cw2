using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public class GasContainer(float height, float weight, float depth, float capacity) 
    : BaseContainer(height, weight, depth, capacity, ContainerType.Gas), IHazardNotifier
{
    private AtmosphereUnit _pressure = new(1, AtmosphereUnitType.ATM);

    public override void Empty()
    {
        Mass = weight + (Mass * 0.05);
    } 
    
    public void Hazard(string containerId, string msg)
    {
        Console.WriteLine(containerId + ": " + msg);
    }
    
    public string GetPressure() => _pressure.GetFullPressureInfo();
}