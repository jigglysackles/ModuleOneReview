using System.IO.Pipelines;


namespace ModuleOneReview
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                "Hello! Welcome to the Area application.\n\nI can provide the area of a Circle, a Triangle, a Rectangle, or a Square. \nWhich would you like to see? (C,T,R,S)");
            string? readResultCharSelect;
            char resultChar;
            
            do
            {
                readResultCharSelect = Console.ReadLine().ToLower();
                if (!char.TryParse(readResultCharSelect, out resultChar) || (resultChar != 'c' && resultChar != 't' && resultChar != 'r' && resultChar != 's'))
                {
                    Console.WriteLine(
                        "That entry was invalid. Please Enter C for Circle, T for Triangle, R for Rectangle, or S for Square.");
                }
                
            } while (resultChar != 'c' && resultChar != 't' && resultChar != 'r' && resultChar != 's');

            bool validUserInput = false;
            switch (resultChar)
            {
                case 'c':
                    do
                    {
                        Console.WriteLine("Area of a Circle\n");
                        Console.WriteLine($"Please enter the radius of the circle: ");
                        string? readResultUserRadius = Console.ReadLine();
                        if (int.TryParse(readResultUserRadius, out int userRadius))
                        {
                            validUserInput = true;
                            Console.WriteLine($"The area of the Circle is {AreaOfCircle(userRadius)}!\nPress enter to continue.");
                            Console.ReadLine();
                        }
                        
                    } while (!validUserInput);

                    break;
                case 't':
                    do
                    {
                        Console.WriteLine("Area of a Triangle\n");
                        
                        Console.WriteLine($"Please enter the base length of the triangle: ");
                        bool goodTriangleBaseLength = true;
                        bool goodTriangleHeight = true;
                        string? readResultUserTriangleBase = Console.ReadLine();
                        if (!int.TryParse(readResultUserTriangleBase, out int userTriangleBase))
                        {
                            goodTriangleBaseLength = false;
                        }
                        
                        Console.WriteLine($"Please enter the height of the triangle: ");
                        string? readResultUserTriangleHeight = Console.ReadLine();
                        if (!int.TryParse(readResultUserTriangleHeight, out int userTriangleHeight) || !goodTriangleBaseLength)
                        {
                            Console.WriteLine("Invalid input detected. Please use valid numbers only.\n\nPress enter to try again.");
                            Console.ReadLine();
                            goodTriangleBaseLength = false;
                        }

                        if (goodTriangleBaseLength && goodTriangleHeight)
                        {
                            validUserInput = true;
                            Console.WriteLine(
                                $"The area of the Triangle is {AreaOfTriangle(userTriangleBase, userTriangleHeight)}!\nPress enter to continue.");
                            Console.ReadLine();
                        }
                        

                    }while (!validUserInput);
                    break;
             
                case 'r':
                    do
                    {
                        Console.WriteLine("Area of a Rectangle\n");
                        
                        Console.WriteLine($"Please enter the base length of the rectangle: ");
                        bool goodRectangleLength = true;
                        bool goodRectangleWidth = true;
                        string? readResultUserRectangleLength = Console.ReadLine();
                        if (!int.TryParse(readResultUserRectangleLength, out int userRectangleLength))
                        {
                            goodRectangleLength = false;
                        }
                        
                        Console.WriteLine($"Please enter the height of the rectangle: ");
                        string? readResultUserRectangleWidth = Console.ReadLine();
                        if (!int.TryParse(readResultUserRectangleWidth, out int userRectangleWidth) || !goodRectangleLength)
                        {
                            Console.WriteLine("Invalid input detected. Please use valid numbers only.\n\nPress enter to try again.");
                            Console.ReadLine();
                            goodRectangleWidth = false;
                        }

                        if (goodRectangleLength && goodRectangleWidth)
                        {
                            validUserInput = true;
                            Console.WriteLine(
                                $"The area of the Rectangle is {AreaOfRectangle(userRectangleLength, userRectangleWidth)}!\nPress enter to continue.");
                            Console.ReadLine();
                        }
                        

                    }while (!validUserInput);
                    break;
                
                
                case 's':
                    do
                    {
                        Console.WriteLine("Area of a Square\n");
                        Console.WriteLine($"Please enter one side of the square: ");
                        string? readResultUserSquare = Console.ReadLine();
                        if (int.TryParse(readResultUserSquare, out int userSquare))
                        {
                            validUserInput = true;
                            Console.WriteLine($"The area of the Square is {AreaOfSquare(userSquare)}!\nPress enter to continue.");
                            Console.ReadLine();
                        }
                        

                    } while (!validUserInput);
                    break;
            }
            Console.WriteLine("Hope that helped! Press enter to exit.");
            Console.ReadLine();

        }

        public static double AreaOfCircle(double radius) => Math.PI * radius * radius;

        public static double AreaOfTriangle(double baseLength, double height) => .5 * baseLength * height;
        
        public static double AreaOfRectangle(double length, double width) => length * width;
        
        public static double AreaOfSquare(double side) => side * side;
        
        
    }
}


