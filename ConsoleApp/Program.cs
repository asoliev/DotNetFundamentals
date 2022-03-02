using ConcatetionLogicLibrary;

bool inputValidated = false;
while (!inputValidated)
{
    Console.Write("Enter username: ");
    var username = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(username))
    {
        inputValidated = true;
        string greeting = $"Hello, {username}";
        ConcatetionLogic library = new();
        Console.WriteLine(library.Output(greeting));
    }
    else
    {
        Console.WriteLine("Invalid input.\n");
    }
}