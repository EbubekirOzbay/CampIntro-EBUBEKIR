using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        private static List<IKrediManager> krediler;

        static void Main(string[] args)
        {
           IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  
           IKrediManager tasitKrediManager  = new TasitKrediManager();
           IKrediManager konutKrediManager=new KonutKrediManager();
            IloggerService databaseLogerService = new DataBaseLoggerService();
            IloggerService fileLogerService = new FileLoggerService ();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            List<IKrediManager> Krediler = new List<IKrediManager>() { ihtiyacKrediManager ,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(Krediler);




           

        }
    }
}
