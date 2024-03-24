﻿namespace Containers;

public abstract class Container
{
    private static int containerNumber = 1;
    public double cargoMass { get; protected set; }
    public double height { get; protected set; }
    public double ownWeight { get; protected set; }
    public double depth { get; protected set; }
    public string serialNumber { get; protected set; }
    public double maxLoadMass { get; protected set; }

    protected Container(double cargoMass, double height, double ownWeight, double depth, double maxLoadMass, char containerType)
    {
        this.cargoMass = cargoMass;
        this.height = height;
        this.ownWeight = ownWeight;
        this.depth = depth;
        this.serialNumber = prepareSerialNumber(containerType);
        this.maxLoadMass = maxLoadMass;
    }

    public void loadCargo(double loadMass)
    {
        Console.WriteLine("Parent job");
        if (loadMass > maxLoadMass)
        {
            throw new OverfillException($"Container {serialNumber} max load mass was exceeded!");
        }

        cargoMass = loadMass;
    }

    public void unloadCargo()
    {
        cargoMass = 0;
    }

    public string prepareSerialNumber(char containerType)
    {
        string result = "KON-" + containerType + "-" + containerNumber;
        containerNumber++;

        return result;
    }
}