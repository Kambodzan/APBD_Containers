namespace Containers;

public class Ship
{
    public List<Container> Containers { get; set; } = new List<Container>();
    public double maxSpeed { get; set; }
    public int maxContainers { get; set; }
    public double maxWeight { get; set; }
}