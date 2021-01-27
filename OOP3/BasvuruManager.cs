using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //

           // KonutKrediManager konutKrediManager = new KonutKrediManager();
            krediManager.Hesapla();
            //loggerService.Log();
            //birden fazla yollamak için aşağıda
            foreach (var loggerService in loggerService)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
