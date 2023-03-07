using consoleProject;
using consoleProject.HR;

List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("*************************");
Console.WriteLine("****** Console app ******");
Console.WriteLine("*************************");

string userSelect;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employees \n\n");
    Console.WriteLine("********************");
    Console.WriteLine("* Select An Action *");
    Console.WriteLine("********************");
    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Load specific employee");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelect = Console.ReadLine();

    switch (userSelect)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.LoadEmployeeById(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }

}
while (userSelect != "9");
Console.WriteLine("Thanks for using the application");