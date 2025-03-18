// See https://aka.ms/new-console-template for more information

using apbd3;

ContainerL containerL = new ContainerL(121,123,12,312,231,312);

Console.WriteLine(containerL.Id());

ContainerShip containerShip = new ContainerShip();

containerShip.Add(containerL);