using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediMAnager = new TasitKrediMAnager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKrediManager(); 

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            List<ILoggerService> loggerServices = new List<ILoggerService>();
            loggerServices.Add(databaseLoggerService);
            loggerServices.Add(smsLoggerService);

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>();
            krediler.Add(konutKrediManager);
            krediler.Add(tasitKrediMAnager);
            krediler.Add(ihtiyacKrediManager);
            //basvuruManager.KrediOnBilgilendirme(krediler);
        }
    }
}
