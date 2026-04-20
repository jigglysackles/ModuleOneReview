using System.IO.Pipelines;

Console.WriteLine("Hello! Welcome to the Area application.\n\nI can provide the area of a Circle, a Triangle, a Rectangle, or a Square. \nWhich would you like to see? (C,T,R,S)");

string? readResultCharSelect = Console.ReadLine();
do
{
    Console.Clear();
    Console.WriteLine("That entry was invalid. Please Enter C for Circle, T for Triangle, R for Rectangle, or S for Square."); 
} while (readResultCharSelect !=
         "C" || readResultCharSelect != "T" || readResultCharSelect != "R" || readResultCharSelect != "S");
bool validUserInput = false;
switch (readResultCharSelect)
{
    case "C":
        do
        {
            Console.Clear();
            Console.WriteLine("Area of a Circle\n");
            Console.WriteLine($"Please enter the radius of the circle: ");
            string? readResultUserRadius = Console.ReadLine();
            if (int.TryParse(readResultUserRadius, out int userRadius))
            {
                AreaOfCircle(userRadius);
                validUserInput = true;
            }
            
        } while (!validUserInput);

        break;
    case "T":
        Console.Clear();
        Console.WriteLine("Area of a Triangle");
        break;
    case "R":
        Console.Clear();
        Console.WriteLine("Area of a Rectangle");
        break;
    case "S":
        Console.Clear();
        Console.WriteLine("Area of a Square");
        break;
}


public static double AreaOfCircle(double radius) => Math.PI * radius * radius;


