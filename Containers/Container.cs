namespace Containers;

public abstract class Container
{
    public double cargoMass { get; protected set; }
    public double height { get; protected set; }
    public double ownWeight { get; protected set; }
    public double depth { get; protected set; }
    public string serialNumber { get; protected set; }
    public double maxLoadMass { get; protected set; }
    
    
}