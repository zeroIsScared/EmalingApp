using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmalingApp
{
    public class Email
    {
        const string filePath = @"C:\Users\natalia.levinta\OneDrive - Amdaris\Internship\Disposal&GarbageCollection\EmailBody.txt";

        private DateTime _emailDate;
        public string? EmailAdress { get; set; }
        public string? Log { get; set; }
        public void SendEmail (string emailAdress)
        {
            var smtp = new EmailConfuguration();
            using var smtpClient = smtp.EstablishSMTPConnection();
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("mysite@gmail.com");           
            mailMessage.To.Add(emailAdress);
            mailMessage.Subject = "Subcribe to newslatter";
            using var emailText = new EmailText(filePath);           
            _emailDate = DateTime.Now;
            string emailSendDate = _emailDate.ToString("dd.MM.yyyy HH:mm:ss");
            
            try
            {               
                mailMessage.Body = emailText.GetEmailtext();
                smtpClient.Send(mailMessage);
                Log = $"Success: An email was sent to {emailAdress} on {emailSendDate} ";                
                Logs.AddLog(Log);
                Console.WriteLine("Your first email is on the way.");
            }
            catch
            {
                Log = $"Failure: There was an error when sending an email to {emailAdress} on {emailSendDate}";
                Logs.AddLog(Log);
                throw;
            }
                      
        }
    }
}
