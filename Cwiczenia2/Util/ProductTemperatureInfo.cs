namespace Cwiczenia2.Util;

public class ProductTemperatureInfo
{
    private Dictionary<ProductType, double> _productTemperature;

    public ProductTemperatureInfo()
    {
        _productTemperature = new();
        _productTemperature.Add(ProductType.BANANAS, 13.3);
        _productTemperature.Add(ProductType.CHOCOLATE, 18);
        _productTemperature.Add(ProductType.FISH, 2);
        _productTemperature.Add(ProductType.MEAT, -15);
        _productTemperature.Add(ProductType.ICE_CREAM, -18);
        _productTemperature.Add(ProductType.FROZEN_PIZZA, -30);
        _productTemperature.Add(ProductType.CHEESE, 7.2);
        _productTemperature.Add(ProductType.SAUSAGES, 5);
        _productTemperature.Add(ProductType.BUTTER, 20.5);
        _productTemperature.Add(ProductType.EGGS, 19);
    }
    
    public double GetMinTemperatureForProduct(ProductType productType) => _productTemperature[productType];
}