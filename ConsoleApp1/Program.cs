// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Pattern.Result;

Console.WriteLine("Hello, World!");

UserService service = new UserService();

ResultValue<User> result = service.GetUserById(1);

if (!result.IsSuccess)
{
    Console.WriteLine(result.ErrorMessage);
}