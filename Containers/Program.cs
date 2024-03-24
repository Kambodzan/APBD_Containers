// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Containers;

GasContainer gasContainer = new GasContainer(5, 5, 5, 5, 15, 5);
// GasContainer gasContainer2 = new GasContainer(5, 5, 5, 5, 15, 5);
// GasContainer gasContainer3 = new GasContainer(5, 5, 5, 5, 15, 5);
// LiquidContainer lc1 = new LiquidContainer(5, 5, 5, 5, 15, true);
//
// Console.WriteLine(gasContainer.serialNumber);
// Console.WriteLine(gasContainer2.serialNumber);
// Console.WriteLine(gasContainer3.serialNumber);
// Console.WriteLine(lc1.serialNumber);

Console.WriteLine(gasContainer.maxLoadMass);
Console.Write(ProductController.getProductTemperature("BANANAS"));