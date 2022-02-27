using ClassLibrary1;

Console.Write("Enter username: ");
var username = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(username))
{
    ConcatetionLogic library = new ConcatetionLogic(username);
    Console.WriteLine(library.Output());
}