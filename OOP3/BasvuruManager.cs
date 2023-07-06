using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager , IloggerService loggerService )

        {
            krediManager.Hesapla();
            loggerService.Log();


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }

        internal void KrediOnBilgilendirmesiYap(object krediler)
        {
            throw new NotImplementedException();
        }
    }
}