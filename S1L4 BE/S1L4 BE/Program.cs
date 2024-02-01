public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsLogged { get; private set; }
    public DateTime LoginTime { get; private set; }

    public void Login()
    {
        Console.WriteLine("Enter username:");
        Username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        Password = Console.ReadLine();

        Console.WriteLine("Confirm password:");
        string confirmPassword = Console.ReadLine();

        if (Password == confirmPassword && !string.IsNullOrEmpty(Username))
        {
            IsLogged = true;
            LoginTime = DateTime.Now;
            Console.WriteLine($"User successfully logged in at {LoginTime}");
        }
        else
        {
            Console.WriteLine("Unable to log in");
        }
    }

    public void Logout()
    {
        Username = "";
        Password = "";
        IsLogged = false;
        Console.WriteLine("No user logged into the system");
    }

    public void PrintLoginDateTime()
    {
        if (IsLogged)
        {
            Console.WriteLine($"User {Username} logged in at {LoginTime}");
        }
        else
        {
            Console.WriteLine("No users logged into the system");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        RunMenu();
    }

    public static void RunMenu()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("==============OPERATIONS===============");
            Console.WriteLine("Choose the operation to perform:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.WriteLine("3. Check login date and time");
            Console.WriteLine("4. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    User user = new User();
                    user.Login();
                    break;
                case "2":
                    user.Logout();
                    break;
                case "3":
                    user.PrintLoginDateTime();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
