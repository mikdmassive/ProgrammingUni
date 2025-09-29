Login AdminLogin = new Login("admin", "w34kPa55w0rd");

Console.Write("Enter your username: ");
string username = Console.ReadLine();
Console.Write("Enter your password: ");
string password = Console.ReadLine();
if (username == AdminLogin.username && password == AdminLogin.password)
{
    Console.WriteLine("Login successful!");
}
else
{
    Console.WriteLine("Login failed. Invalid username or password.");
}
//CLASSES

// example
class Login
{
    public string username;
    public string password;

    public Login(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
}