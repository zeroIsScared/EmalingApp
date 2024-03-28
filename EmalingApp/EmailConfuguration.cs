using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmalingApp
{
    public class EmailConfuguration : IDisposable
    {
        public bool isDisposed = false;
        private SmtpClient? _smtpClient;
        public SmtpClient EstablishSMTPConnection()
        {
            _smtpClient = new SmtpClient();
            _smtpClient.Host = "smtp.smtp-test.maildim.com";
            _smtpClient.Port = 587;
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new NetworkCredential("bujornathalia@gmail.com", "b88f15c2650c4bb6c427");
            _smtpClient.EnableSsl = true;
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            return _smtpClient;
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                _smtpClient.Dispose();
            }
        }
    }
}
