using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PerthAzure.Function
{
    public static class EventHubProducerTrigger
    {
        [FunctionName("EventHubProducerTrigger")]
        [return: EventHub("kafkatest", Connection = "EventHubConnectionAppSetting")]
        public static string Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation($"function executed at: {DateTime.Now}");
            return $"{DateTime.Now}";
        }
    }
}
