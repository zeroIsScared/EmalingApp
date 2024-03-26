using EmalingApp;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, if you'd like to subscribe to our newsletters, please enter your email below.");

        var newEmail = new Email();

        newEmail.EmailAdress = Console.ReadLine();

        if(newEmail.EmailAdress != null) 
        { 
            newEmail.SendEmail(newEmail.EmailAdress);
        }
    }
}