namespace Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double pressure { get; set; }

    public GasContainer(double cargoMass, double height, double ownWeight, double depth, string serialNumber, double maxLoadMass, double pressure) : base(cargoMass, height, ownWeight, depth, serialNumber, maxLoadMass)
    {
        this.pressure = pressure;
    }

    public void notifyHazard(string containerSerialNumber)
    {
        Console.WriteLine($"Hazard in container -> {containerSerialNumber}");
    }
}