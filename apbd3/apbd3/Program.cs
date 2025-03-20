// See https://aka.ms/new-console-template for more information

using apbd3;
using Type = apbd3.Type;

var containerL = new ContainerL(123,12,312,500);
var containerG = new ContainerG(123,12,312,200,1.3);
var containerC = new ContainerC(123,12,312,600,13);

var milk = new Product(Type.L, "milk",false, 300, 5);  // milk
var toxicChemical = new Product(Type.L, "toxicChemical",true, 100, 13);  // Toxic Chemical
var helium = new Product(Type.G,"helium", false, 100, 12);  // helium
var watermelon = new Product(Type.C,"watermelon", false, 250, 12);  // Watermelon
var bananas = new Product(Type.C, "bananas",false, 250, 13);  // Bananas
try
{
    containerL.Load(milk);
    containerL.Load(toxicChemical);

    containerG.Load(helium);

    containerC.Load(watermelon);
    containerC.Load(bananas);
}
catch (Exception e)
{
    Console.WriteLine(e);
}


ContainerShip containerShip = new ContainerShip(20,3,10);
containerShip.Load(containerL);
containerShip.Load(containerG);
containerShip.Load(containerC);

Console.WriteLine(containerShip);

ContainerShip containerShip2 = new ContainerShip(20,3,10);
ContainerShip.MoveContainer(containerShip, containerShip2,"KON-L-0");

Console.WriteLine(containerShip);
Console.WriteLine(containerShip2);


