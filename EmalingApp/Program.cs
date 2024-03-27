using EmalingApp;
using System;
using System.Net;
using System.Net.Mail;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, if you'd like to subscribe to our newsletters, please enter your email below.");

        var newEmail = new Email();

        newEmail.EmailAdress = Console.ReadLine();

        if (newEmail.EmailAdress != null)
        {
            try
            {
                newEmail.SendEmail(newEmail.EmailAdress);
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
            }
            
        }
    }
}
