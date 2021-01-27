using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerServices> loggerServices)
        {
            // Başvuran bilgilerini degerlendirme
            //
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            krediManager.Hesapla();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
        }
    }
}
