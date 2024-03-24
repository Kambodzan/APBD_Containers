namespace Containers;

public class LiquidContainer : Container
{
    public bool isHazardous { get; set; }

    public LiquidContainer(double cargoMass, double height, double ownWeight, double depth, string serialNumber, double maxLoadMass, bool isHazardous) : base(cargoMass, height, ownWeight, depth, serialNumber, maxLoadMass)
    {
        this.isHazardous = isHazardous;
    }
}