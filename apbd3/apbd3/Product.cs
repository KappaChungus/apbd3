namespace apbd3;

public class Product
{
    public readonly string _type;
    public readonly bool _isDangerous;
    public readonly double _weight;
    public readonly double _temperature;

    Product(string type, bool isDangerous, double weight, double temperature)
    {
        _type = type;
        _isDangerous = isDangerous;
        _weight = weight;
        _temperature = temperature;
    }
}