using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public class RefrigeratingContainer(double height, double weight, double depth, double capacity, ProductType productType) 
    : BaseContainer(height, weight, depth, capacity, ContainerType.Refrigerating)
{
    private double _temperature;
    private static readonly ProductTemperatureInfo TemperatureInfo = new ProductTemperatureInfo();

    public void SetTemperature(double temperature)
    {
        if (temperature < TemperatureInfo.GetMinTemperatureForProduct(productType))
            throw new TemperatureLowException("Temperature too low");
        _temperature = temperature;
    }
    
    public double GetTemperature() => _temperature;
}