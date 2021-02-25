using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //birden çok loglanma
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuru bigilerini değerlendirme
            //

            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }

    }
}
