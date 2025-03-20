namespace apbd3;

public class Container
{
    private static int _idCounter;
    public Container(double height, double rawWeight, double depth, double maxLoadWeight)
    {
        Height = height;
        RawWeight = rawWeight;
        Depth = depth;
        Id = _idCounter++;
        MaxLoadWeight = maxLoadWeight;
    }

    protected double LoadWeight;
    protected double Height;
    protected double RawWeight;
    protected double Depth;
    protected int Id;
    protected Type? type;
    protected double MaxLoadWeight;

    public virtual void Unload()
    {
        LoadWeight = 0.0;
    }

    public virtual void Load(Product product)
    {
        if(LoadWeight + product.Weight> MaxLoadWeight)
            throw new OverFillException("load weight overflow");
        LoadWeight += product.Weight;
    }

    public string GetId()
    {
        return "KON-"+type+"-"+Id;
    }

    public override string ToString()
    {
        return GetId()+", raw weight: "+RawWeight+", load weight: "+LoadWeight+", depth: "+Depth+", height: "+Height;
    }

    public double TotalTonsWeight()
    {
        return (LoadWeight + RawWeight) / 1000.0;
    }
}