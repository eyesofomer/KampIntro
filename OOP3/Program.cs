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

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.BasvuruYap(consumerCreditManager);

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager, vehicleCreditManager };

            applicationManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
