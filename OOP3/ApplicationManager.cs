using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void BasvuruYap(ICreditManager creditManager)
        {
            //Başvuran bilgilerini değerlendirme
            //

            creditManager.Calculate();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var kredi in credits)
            {
                kredi.Calculate();
            }
        }
    }
}
