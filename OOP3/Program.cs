using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(new VehicleCreditManager(), loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { consumerCreditManager, vehicleCreditManager };

            //applicationManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
