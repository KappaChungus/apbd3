using System.Transactions;

namespace apbd3;

public class ContainerL : Container,IHazardNotifier
{

    private bool? _hasDangerousCarriage;

    public ContainerL(double height, double rawWeight, double depth, double maxLoadWeight)
        : base(height, rawWeight, depth, maxLoadWeight)
    {
        type = Type.L;
    }
    
    public void Notify()
    {
        Console.WriteLine("danger "+GetId());
    }

    public override void Load(Product product)
    {
        _hasDangerousCarriage ??= product.IsDangerous;
        if (LoadWeight+ product.Weight> ((bool)_hasDangerousCarriage ? 0.5 : 0.9)*MaxLoadWeight)
            throw new Exception("attempt dangerous operation");
        base.Load(product);
        
    }

    public override string ToString()
    {
        if (_hasDangerousCarriage == null)
            return base.ToString();
        return base.ToString()+((bool)_hasDangerousCarriage!?", safe carriage":", dangerous carriage");
    }
}