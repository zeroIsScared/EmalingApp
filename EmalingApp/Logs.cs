using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmalingApp
{
    public  class Logs
    {
        private static DateTime _currentDate = DateTime.Now;

        private static string _directoryPath = @"C:\Users\natalia.levinta\OneDrive - Amdaris\Internship\Disposal&GarbageCollection\EmalingApp\";

        private  static string? _fileName;
       

        public async static void AddLog (string log)
        {
            _fileName = $"Logs_{_currentDate.ToString("dd_MM_yyyy")}";
            string filePath = $"{_directoryPath}{_fileName}";
            string createdLog = log + Environment.NewLine;          
            const int Buffer_size = 4096;
            byte[] info = new UTF8Encoding().GetBytes(createdLog);

            if (!File.Exists(filePath))
            {
               using  FileStream fs = File.Create(filePath, Buffer_size);                

                if(fs.CanWrite)
                {
                    await fs.WriteAsync(info);
                }               
            }
            else
            {
                using FileStream fs = File.Open(filePath, FileMode.Append, FileAccess.Write,FileShare.None);
                await fs.WriteAsync(info, 0, info.Length);
            }
         
        }
        
    }
}
