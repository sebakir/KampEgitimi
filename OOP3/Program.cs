using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerServices fileloggerServices = new FileBaseLoggerService();
            ILoggerServices databaseloggerServices = new DataBaseLoggerService();
            List<ILoggerServices> loggerServices = new List<ILoggerServices> { new SmsLoggerService(), new FileBaseLoggerService() };


            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggerServices);

            databaseloggerServices.Log();
            fileloggerServices.Log();


            List<IKrediManager> krediler = new List<IKrediManager>();
            krediler.Add(ihtiyacKrediManager);
            krediler.Add(tasitKrediManager);
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
