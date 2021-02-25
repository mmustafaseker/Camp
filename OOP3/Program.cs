using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // open close prensip
            // yazılımda sürdürülebilirlik
            //interface'lerde implement edilen sınıfın referansını tutabiliyor
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();
            // 1
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacCreditManager , new List<ILoggerService> {dataBaseLoggerService,new SmsLoggerService() });
            // 2
            BasvuruManager basvuruManager1 = new BasvuruManager();
            basvuruManager1.BasvuruYap(konutCreditManager, new List<ILoggerService> { fileLoggerService, new SmsLoggerService() });
            // 3
            BasvuruManager basvuruManager2 = new BasvuruManager();
            basvuruManager2.BasvuruYap(new EsnafCreditManager(), new List<ILoggerService> { dataBaseLoggerService, new SmsLoggerService() });


            // 4
            List<ILoggerService> logger = new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService(), new FileBaseLoggerService() };
            BasvuruManager basvuruManager3 = new BasvuruManager();
            basvuruManager.BasvuruYap(konutCreditManager, logger);

            List<ICreditManager> credits = new List<ICreditManager>(){ihtiyacCreditManager, tasitCreditManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);
    

        }
    }
}
