using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmalingApp
{
    public class Email
    {
        const string filePath = @"C:\Users\natalia.levinta\OneDrive - Amdaris\Internship\Disposal&GarbageCollection\EmailBody.txt";      
        public string? EmailAdress { get; set; }
        public bool SendEmail (string emailAdress)
        {
            using var emailText = new EmailText(filePath);
            string emailBody = emailText.GetEmailtext();

            if (emailBody != null)
            {
                Console.WriteLine($"EmailText: {emailBody}");
                Console.WriteLine("Your first email is on the way.");
                return true;
            }

            return false;
        }
    }
}
