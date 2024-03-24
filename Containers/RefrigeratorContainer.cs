namespace Containers;

public class RefrigeratorContainer : Container
{
    public double temperature { get; set; }

    public RefrigeratorContainer(double cargoMass, double height, double ownWeight, double depth, string serialNumber, double maxLoadMass, double temperature) : base(cargoMass, height, ownWeight, depth, serialNumber, maxLoadMass)
    {
        this.temperature = temperature;
    }
}