string login = "Admin";
string password = "P@ssw0rd";

Console.Write("Enter your login: ");

string usersLogin = Console.ReadLine();

if (login == usersLogin)
{
    Console.Write("Enter your password: ");
    string usersPassword = Console.ReadLine();

    if (password == usersPassword)
    {
        Console.WriteLine("Hello {0}, you entered to system.", usersLogin);
    }
    else
    {
        Console.WriteLine("You entered wrong password.");
    }
}
else
{
    Console.WriteLine("Cannot find this user.");
}