namespace Containers;

public abstract class Container
{
    public double cargoMass { get; protected set; }
    public double height { get; protected set; }
    public double ownWeight { get; protected set; }
    public double depth { get; protected set; }
    public string serialNumber { get; protected set; }
    public double maxLoadMass { get; protected set; }

    protected Container(double cargoMass, double height, double ownWeight, double depth, string serialNumber, double maxLoadMass)
    {
        this.cargoMass = cargoMass;
        this.height = height;
        this.ownWeight = ownWeight;
        this.depth = depth;
        this.serialNumber = serialNumber;
        this.maxLoadMass = maxLoadMass;
    }

    public void loadCargo(double loadMass)
    {
        if (loadMass > maxLoadMass)
        {
            // TODO Add overfill exception
        }

        cargoMass = loadMass;
    }

    public void unloadCargo()
    {
        cargoMass = 0;
    }
}