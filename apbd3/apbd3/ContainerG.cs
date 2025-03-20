namespace apbd3;

public class ContainerG : Container, IHazardNotifier
{
    private double _pressure;

    public ContainerG(double height, double rawWeight, double depth, double maxLoadWeight,double pressure)
        : base(height, rawWeight, depth, maxLoadWeight)
    {
        _pressure = pressure;
        type = Type.G;
    }

    public override void Unload()
    {
        LoadWeight = 0.05 * LoadWeight;
    }
    
    public void Notify()
    {
        Console.WriteLine("danger "+GetId());
    }

    public override string ToString()
    {
        return base.ToString()+", pressure: "+_pressure;
    }
}