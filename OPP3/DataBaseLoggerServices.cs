using System;
using System.Collections.Generic;
using System.Text;

namespace OPP3
{
    class DataBaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }

        
    }
}
