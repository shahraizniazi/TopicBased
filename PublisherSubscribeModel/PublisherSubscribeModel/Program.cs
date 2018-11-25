using System;
using System.Threading;



namespace PublisherSubscribeModel
{
    class Program
    {

      

        static void Main(string[] args)
        {
            PublisherSysLogs logs = new PublisherSysLogs();
            PublisherAppLogs logs1 = new PublisherAppLogs();
            Thread t1 = new Thread(logs.SysLogs);
            Thread t2 = new Thread(logs1.AppLogs);

            t1.Start();
            t2.Start();

            


        }
    }
}


