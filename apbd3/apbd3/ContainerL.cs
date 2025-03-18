using System.Transactions;

namespace apbd3;

public class ContainerL : Container,IHazardNotifier
{

    private bool _hasDangerousCarriage;
    
    public ContainerL(double loadWeight, double height, double rawWeight, double depth, int id, double maxLoadWeight)
        : base(loadWeight, height, rawWeight, depth, id, maxLoadWeight)  // Call the base constructor with the same parameters
    {}
    
    public string Notify()
    {
        return "danger "+ _id;
    }

    public override void Load(Product product)
    {
        if(product._isDangerous)
            _hasDangerousCarriage = true;
        if (_loadWeight+_rawWeight +_loadWeight> (_hasDangerousCarriage ? 0.5 : 0.9)*product._weight)
        {
            throw new Exception("attempt dangerous operation");
        }
        base.Load(product);
        
    }
    
    public string Id()
    {
        return "KON-L-" + _id;
    }
}