namespace apbd3;

public class ContainerG : Container, IHazardNotifier
{
    private double _pressure;

    public ContainerG(double pressure, double loadWeight, double height, double rawWeight, double depth, int id, double maxLoadWeight)
        : base(loadWeight, height, rawWeight, depth, id, maxLoadWeight) // Call base constructor with the parameters
    {
        _pressure = pressure;
    }

    public override void Unload()
    {
        _loadWeight = 0.05 * _loadWeight;
    }
    
    public string Notify()
    {
        return "danger " + _id;
    }

    public string Id()
    {
        return "KON-G-" + _id;
    }
    
}