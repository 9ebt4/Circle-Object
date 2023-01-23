
using circle_objects;

List<Circle> Circles = new List<Circle>();
int i = 0;
bool runProgram = true;

while (runProgram)
{
    //user input- The application prompts the user to enter a radius; the user may enter a decimal number.
    Console.WriteLine("Please enter the Radius of the circle you would like to make.");//The application displays an error if the user enters invalid data and asks the user again for a radius.
    double radius = Valid.DoubleValidator();
    Circles.Add(new Circle(radius));
    //When the user enters valid data, the application calculates the area and circumference of the circle and rounds to the nearest 2 decimal places and prints out both.
    Console.WriteLine(Circles[i].GetDetails());
    i++;
    //The application asks the user whether they want to do another.
    exitProgram(ref runProgram);
}
//The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.
Console.WriteLine($"Goodbye and thank you for making {Circles.Count} circles.");

static void exitProgram(ref bool x)
{
    while (true)
    {
        Console.WriteLine("Would you like to make more circles?");
        string answer = Console.ReadLine().ToLower().Trim();

        if (answer.Contains('y'))
        {
            Console.Clear();
            break;
        }
        else if (answer.Contains('n'))
        {
            x = false;
            break;
        }
        else
        {
            Console.WriteLine("Please use y/n");
        }
    }
}