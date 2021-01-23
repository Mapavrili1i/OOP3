using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager ,List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }

        }
        public void KrediOnBilgilendirme(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
