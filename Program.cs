Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
Console.WriteLine();



Console.WriteLine("Enter Length:" );
double lengthEntered = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Width: ");
double widthEntered = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Height: ");
double heightEntered = double.Parse(Console.ReadLine());

double areaCalculated = lengthEntered * widthEntered;
Console.WriteLine("Area: " +areaCalculated);
double perimeterCalculated = 2*(lengthEntered + widthEntered);
Console.WriteLine("Perimeter: " +perimeterCalculated);
double volCalculated = lengthEntered * widthEntered * heightEntered;
Console.WriteLine("Volume: " + volCalculated);
double surfCalculated = 2 * ((lengthEntered * widthEntered) + (heightEntered * lengthEntered) + (heightEntered * widthEntered));
Console.WriteLine("Surface Area: " + surfCalculated);


if (areaCalculated <= 250)
{
    Console.WriteLine("This is a small-sized room.");
}
else if (areaCalculated < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else
    Console.WriteLine("This is a large-sized room.");

Console.WriteLine("Thank you for using the Room Detail Generator!");