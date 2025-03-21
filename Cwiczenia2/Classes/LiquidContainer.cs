using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public class LiquidContainer(float mass, float height, float weight, float depth, float capacity, ContainerType containerType) 
    : BaseContainer(mass, height, weight, depth, capacity, containerType), IHazardNotifier
{
    public void Fill(double fillWith, bool isDanger)
    {
        if (isDanger) {
            if (fillWith / capacity > 0.5) {
                fillWith = capacity * 0.5;    
            }
        } else {
            fillWith = capacity * 0.9;
        }

        try {
            base.Fill(fillWith);
        }
        catch (OverfillException e) {
            Hazard(base.GetSerialNumber(), e.Message);
            throw;
        }
    }
    
    public void Hazard(string containerId, string msg)
    {
        Console.WriteLine(containerId + ": " + msg);
    }
}