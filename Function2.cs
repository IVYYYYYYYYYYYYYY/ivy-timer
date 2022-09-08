using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function2
    {
        [FunctionName("Function2")]
        //[ExponentialBackoffRetry(2, "00:00:04", "00:15:00")]
        public void Run([ServiceBusTrigger("myqueue", Connection = "WERT")]string myQueueItem, ILogger log)
        {
            int a = 0;
            int b = 0;
            int c = a / b;
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {c}");
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
