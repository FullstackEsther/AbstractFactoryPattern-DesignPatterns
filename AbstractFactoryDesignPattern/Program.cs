// See https://aka.ms/new-console-template for more information
using AbstractFactoryDesignPattern;
using AbstractFactoryDesignPattern.Dominos;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter 1 to order from Dominos Kitchen");
Console.WriteLine("Enter 2 to order from Chicken Republic");
FoodFactory foodFactory = null;
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        foodFactory = new DominosKitchen();
        break;
    case 2:
        foodFactory = new ChickenRepublic();
        break;
}

Console.WriteLine("Enter 1 for Burger");
Console.WriteLine("Enter 2 for FriedRice");
int secondChoice = int.Parse(Console.ReadLine());
switch (secondChoice)
{
    case 1:
        foodFactory.CreateBurger().Order();
        break;
    case 2:
        foodFactory.CreateFriedRice().Order();
        break;
}