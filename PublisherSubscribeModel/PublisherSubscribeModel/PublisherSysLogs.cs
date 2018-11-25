using System;
using System.Collections.Generic;
using System.Linq;

using System.Diagnostics;
using Apache.NMS.ActiveMQ;
using Spring.Messaging.Nms.Core;

namespace PublisherSubscribeModel
{
    class PublisherSysLogs
    {
        private const string URI = "tcp://localhost:61616";
        private const string DESTINATION = "SystemLogs.queue";

        public void SysLogs() {


            ConnectionFactory connectionFactory = new ConnectionFactory(URI);
            NmsTemplate template = new NmsTemplate(connectionFactory);


            string eventLogName = "System";

            EventLog eventLog = new EventLog();
            eventLog.Log = eventLogName;

            foreach (EventLogEntry log in eventLog.Entries)
            {
                
                template.ConvertAndSend(DESTINATION, log.Message);
            }
            
        
        }




    }
}
