namespace apbd3;

public class ContainerC : Container
{
    private string? _typeOfProduct;
    private double _temperature;

    public ContainerC(double temperature, double loadWeight, double height, double rawWeight, double depth, int id, double maxLoadWeight)
        : base(loadWeight, height, rawWeight, depth, id, maxLoadWeight)
    {
        _temperature = temperature;
    }

    public override void Load(Product product)
    {
        if(_typeOfProduct == null)
            _typeOfProduct = product._type;
        if(_temperature < product._temperature)
            throw new Exception("Temperature too low");
        if(_typeOfProduct != product._type)
            throw new Exception("Cointainer must have same type of product");
        base.Load(product);
    }
    
    public string Id()
    {
        return "KON-C-" + _id;
    }
}