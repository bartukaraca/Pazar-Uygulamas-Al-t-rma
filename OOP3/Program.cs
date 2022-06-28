using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            TaşıtKrediManager taşıtKrediManager = new TaşıtKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DataBaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> {new DataBaseLoggerService(), new FileLoggerService() } );

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager };
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
