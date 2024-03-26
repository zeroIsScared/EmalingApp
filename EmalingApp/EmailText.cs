using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmalingApp
{
    public class EmailText : IDisposable
    {
        private bool  isDisposed = false;

        private readonly StreamReader _streamReader;

        public EmailText (string filePath)
        {
            _streamReader = new StreamReader (filePath);
        }

        public string GetEmailtext() 
        { 
            try
            {
                return _streamReader.ReadToEnd();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Dispose()
        {
           if (!isDisposed)
            {
                isDisposed = true;
                _streamReader.Dispose();
            }
        }
    }
}
