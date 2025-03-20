namespace apbd3;

public class ContainerC : Container
{
    string _typeOfCarriage;
    private double _temperature;

    public ContainerC(double height, double rawWeight, double depth, double maxLoadWeight,double temperature,string? typeOfCarriage= null)
        : base(height, rawWeight, depth, maxLoadWeight)
    {
        _temperature = temperature;
        _typeOfCarriage = typeOfCarriage;
        type = Type.C;
    }

    public override void Load(Product product)
    {
        _typeOfCarriage ??= product.Name;
        if(_typeOfCarriage != product.Name)
            throw new Exception("Container must have same type of product");
        if(_temperature < product.Temperature)
            throw new Exception("Temperature too low");
        base.Load(product);
    }

    public override string ToString()
    {
        return base.ToString()+", temperature: "+_temperature+ (_typeOfCarriage!=null?", type of carriage: "+_typeOfCarriage:"");
    }
}