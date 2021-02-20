using System;

namespace Demo_Log4Net
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {
            log.Info("Bienvenidos a nuestra demo de Log4Net");
            for (int i = 0; i < 1000; i++)
            {
                String rowMessage = String.Empty;
                rowMessage = String.Format("Registro {0} - {1} - {2}", i, "PRUEBA NOMBRE", "PRUEBA APELLIDO");
                log.Error(rowMessage);
            }
            Console.WriteLine("Presione enter");
            Console.ReadLine();
        }
    }
}
