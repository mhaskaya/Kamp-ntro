using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var loggerService in LoggerServices)
            {

            }
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(EsnafKredisiManager esnafKredisiManager, SmsLoggerService smsLoggerService)
        {
            throw new NotImplementedException();
        }

        internal void BasvuruYap(EsnafKredisiManager esnafKredisiManager, ILoggerService fileLoggerService)
        {
            throw new NotImplementedException();
        }
    }
}
