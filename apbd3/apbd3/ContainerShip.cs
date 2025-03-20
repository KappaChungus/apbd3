namespace apbd3;

public class ContainerShip
{
    
    List<Container> _containers = new List<Container>();
    private double maxVelocity;
    private int maxNoContainers;
    private double maxContainersWeight; //in tons

    public ContainerShip(double maxVelocity, int maxNoContainers, double maxContainersWeight)
    {
        this.maxVelocity = maxVelocity;
        this.maxNoContainers = maxNoContainers;
        this.maxContainersWeight = maxContainersWeight;
    }

    public void Load(Container container)
    {
        
        if(_containers.Count==maxNoContainers)
            throw new OverFillException("Too many containers!");
        if(container.TotalTonsWeight()+_containers.Sum((c)=>c.TotalTonsWeight())>maxContainersWeight)
            throw new OverFillException("Total weight exceeded!");
        _containers.Add(container);
    }
    public void Load(List<Container> containers)
    {
        if (_containers.Count +containers.Count > maxNoContainers)
            throw new OverFillException("Too many containers");
        if(containers.Sum((c)=>c.TotalTonsWeight())+_containers.Sum((c)=>c.TotalTonsWeight())>maxContainersWeight)
            throw new OverFillException("Total weight exceeded!");
        _containers.AddRange(containers);
    }

    public Container removeContainer(string containerId)
    {
        var containerToRemove = _containers.FirstOrDefault(container => container.GetId() == containerId);
        if (containerToRemove == null)
            throw new InvalidOperationException("Container not found");
        _containers.Remove(containerToRemove);
        return containerToRemove;
    }
    
    public void ReplaceContainer(string containerId, Container container)
    {
        removeContainer(containerId);
        _containers.Add(container);
        
    }

    public static void MoveContainer(ContainerShip from, ContainerShip to, string containerId)
    {
        to.Load(from.removeContainer(containerId));
    }

    public override string ToString()
    {
        return "maxVelocity: " + maxVelocity +
               "\nmaxNoContainers: " + maxNoContainers +
               "\nmaxContainersWeight: " + maxContainersWeight +
               "\nCarriage:\n{\n\t" +
               string.Join("\n\t", _containers.Select(c => c.ToString())) +
               "\n}\n";
    }
}