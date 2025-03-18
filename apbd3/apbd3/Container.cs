namespace apbd3;

public class Container
{
    public Container(double loadWeight, double height, double rawWeight, double depth, int id, double maxLoadWeight)
    {
        _loadWeight = loadWeight;
        _height = height;
        _rawWeight = rawWeight;
        _depth = depth;
        _id = id;
        _maxLoadWeight = maxLoadWeight;
    }

    protected  double _loadWeight;
    protected  double _height;
    protected  double _rawWeight;
    protected  double _depth;
    protected int _id;
    
    private double _maxLoadWeight;

    public virtual void Unload()
    {
        _loadWeight = 0.0;
    }

    public virtual void Load(Product product)
    {
        _loadWeight += product._weight;
        if(_loadWeight + _rawWeight > _maxLoadWeight)
            throw new OverFillException();
    }

}