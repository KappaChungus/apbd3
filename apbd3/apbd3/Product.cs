namespace apbd3;

public class Product
{
    public Type Type{set;get;}
    
    public string Name{set;get;}
    public bool IsDangerous{set;get;}
    public double Weight{set;get;}
    public double Temperature{set;get;}

    public Product(Type type, string name,bool isDangerous, double weight, double temperature)
    {
        Type = type;
        Name = name;
        IsDangerous = isDangerous;
        Weight = weight;
        Temperature = temperature;
    }
}