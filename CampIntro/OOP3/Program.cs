using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new FileLoggerService(),
                new SmsLoggerService(),

            };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalFinanceCreditManager,loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {
                personalFinanceCreditManager,
                vehicleCreditManager
            };

            applicationManager.MakeACreditPreInformation(credits);
            
        }
    }
}
